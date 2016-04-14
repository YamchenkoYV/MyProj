using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ParticleSwarm
{
	public class Swarm
	{
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="task">Экземпляр класса Task, описывающий задачу (целевую фукнцию)</param>
		/// <param name="swarmsize">Размер роя (количество частиц)</param>
		/// <param name="currentVelocityRatio">Коэффициент для скорости в сторону лучшей точки, найденной самой частицей</param>
		/// <param name="localVelocityRatio">Коэффициент для скорости в сторону лучшей точки, найденной самой частицей</param>
		/// <param name="globalVelocityRatio">Коэффициент для скорости в сторону наилучшей точки, найденной всеми частицами</param>
		public Swarm (
			Task task,
			int swarmsize,
			double currentVelocityRatio,
			double localVelocityRatio,
			double globalVelocityRatio,
            int method,
            int topology)
		{
			//Debug.Assert ((localVelocityRatio + globalVelocityRatio) > 4);

			_task = task;
			_currentVelocityRatio = currentVelocityRatio;
			_localVelocityRatio = localVelocityRatio;
			_globalVelocityRatio = globalVelocityRatio;
			_iteration = 0;
            _methodIndex = method;
            _topologyIndex = topology;

			_particles = CreateParticles (swarmsize);
		}

        int _methodIndex;
        public int Method
        {
            get { return _methodIndex; }
        }

        int _topologyIndex;
        public int Topology
        {
            get { return _topologyIndex; }
        }

		public void NextIteration ()
		{
			foreach (Particle particle in _particles)
			{
				particle.NextIteration ();
			}

			_iteration++;
		}

		public int Size
		{
			get { return _particles.Length; }
		}

		public int Dimension
		{
			get { return _task.MinValues.Length; }
		}


		public double[] MinValues
		{
			get { return _task.MinValues; }
		}


		public double[] MaxValues
		{
			get { return _task.MaxValues; }
		}


        bool[] neighbours;

        public bool IsNeighbours(int i, int j)
        {
            return neighbours[i*Size+j];
        }

        public void SetNeighbours(int i, int j)
        {
            neighbours[i * Size + j] = true;
            neighbours[j * Size + i] = true;
        }

        public void PrintNeighborsMatr()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (neighbours[i * Size + j] == true)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
        }

        public System.Collections.ArrayList HavingNeighbours()
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i != j && (neighbours[i * Size + j] == false))
                    {
                        list.Add(i);
                        break;
                    }
                }
            }

                return list;
        }

        public System.Collections.ArrayList NotANaighboursOf(int part)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            for (int i = 0; i < Size; i++)
            {
                if (i != part && neighbours[part * Size + i] == false)
                    list.Add(i);
            }

                return list;
        }

        Particle[] CreateParticles(int swarmSize)
        {
            neighbours = new bool[swarmSize * swarmSize];
            if (Topology == 1 || Topology == 2) //Кольцо или динамическая (Кольцо->Клика)
            {
                
                for (int i = 1; i < swarmSize - 1; i++)
                {
                    neighbours[i * swarmSize + (i + 1)] = true;
                    neighbours[i * swarmSize + (i - 1)] = true;
                }
                neighbours[1] = true;
                neighbours[swarmSize - 1] = true;
                neighbours[(swarmSize - 1) * swarmSize] = true;
                neighbours[swarmSize * swarmSize - 2] = true;
            }
            else if (Topology == 0)  //Клика
            {
                for (int i = 0; i < swarmSize; i++)
                {
                    for (int j = 0; j < swarmSize; j++)
                    {
                        if( j != i)
                            neighbours[i * swarmSize + j] = true;
                    }
                }
            }

			Particle[] swarm = new Particle[swarmSize];
			for (int i = 0; i < swarmSize; i++)
			{
				swarm[i] = new Particle (this,i,swarmSize);
			}

			return swarm;
		}

		/// <summary>
		/// Решаемая задача (целевая функция)
		/// </summary>
		Task _task;

		/// <summary>
		/// Все частицы в рое
		/// </summary>
		Particle[] _particles;

		public Particle[] Particles
		{
			get { return _particles; }
		}

		double _bestFinalFunc = double.MaxValue;
        double _prevFinalFunc = 0.0;

		/// <summary>
		/// Лучшее значение целевой функции на данный момент
		/// </summary>
		public double BestFinalFunc
		{
			get { return _bestFinalFunc; }
		}


        /// <summary>
        /// Вычисляет лучшую позицию среди всех соседей данной частицы в текущей топологии все время поиска
        /// </summary>
        /// <param name="self">Текущая частица</param>
        /// <returns>Лучшая позиция среди соседей</returns>
        public int BestFinalFunc_PSO(int self)
        {
//            System.Collections.ArrayList list = new System.Collections.ArrayList();
            int bestParticle = 0;
            double bestFunc = double.MaxValue;
                //Определение лучшего значения среди соседей
                for (int i = 0; i < Size; i++)
                {
                    if (IsNeighbours(self, i))
                    {
                        double partFunc = _particles[i].LocalBestFinalFunc;
                        if (partFunc < bestFunc)
                        {
                            bestFunc = partFunc;
                            bestParticle = i;
                        }
                    }
                }
            return bestParticle;
        }

        public System.Collections.ArrayList BestFinalFunc_FIPS(int self)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            int ign = 0;

            for (int i = 0; i < Size; i++)
            {
                if (IsNeighbours(self, i))
                {
                    list.Add(i);
                    ign = i;
                    break;
                }
            }

            //Составление списка соседей, упоряденных по возрастанию значений функции в текущих позициях
            for (int i = 0; i < Size; i++)
            {
                if (IsNeighbours(self, i) && i != ign)
                {
                    double partFunc = _particles[i].CurrentFunc;
                    int j = 0;
                    for (j = 0; j < list.Count; j++)
                    {
                        int ind = (int)list[j];
                        if (Particles[ind].LocalBestFinalFunc > partFunc)
                            break;
                    }
                    list.Insert(j, i);
                }
            }
            return list;
        }

		double[] _bestPosition = null;

		/// <summary>
		/// Наилучшее решение, найденное в данный момент
		/// </summary>
		public double[] BestPosition
		{
			get { return _bestPosition; }
		}

		double _currentVelocityRatio;

		/// <summary>
		/// Коэффициент текущей скорости
		/// </summary>
		public double CurrentVelocityRatio
		{
			get { return _currentVelocityRatio; }
		}

        public void SetCurrentVelocityRatio(double currentVelocityRatio)
        {
            _currentVelocityRatio = currentVelocityRatio;
        }

		double _localVelocityRatio;

		/// <summary>
		/// Коэффициент для скорости в сторону лучшей точки, найденной самой частицей
		/// </summary>
		public double LocalVelocityRatio
		{
			get { return _localVelocityRatio; }
		}

        public void SetLocalVelocityRatio(double localVelocityRatio)
        {
            _localVelocityRatio = localVelocityRatio;
        }

		double _globalVelocityRatio;

		/// <summary>
		/// Коэффициент для скорости в сторону наилучшей точки, найденной всеми частицами
		/// </summary>
		public double GlobalVelocityRatio
		{
			get { return _globalVelocityRatio; }
		}

        public void SetGlobalVelocityRatio(double globalVelocityRatio)
        {
           _globalVelocityRatio = globalVelocityRatio; 
        }



		int _iteration;

		public int Iteration
		{
			get { return _iteration; }
		}

        public void ResetIterations()
        {
            _iteration=0;
        }
        double _Dist = Double.MaxValue;

        internal double Swarm_Best_Dist(double[] position, double part_dist)
        {
            if (part_dist < _Dist)
            {
                _Dist = part_dist;
                _bestPosition = (double[])position.Clone();
            }
            return _Dist;
        }

        int counter = 0;

        public int Counter
        {
            get { return counter; }
        }


		internal double FinalFunction (double[] position, double part_dist)
        {
            counter++;
			double finalfunc = _task.FinalFunction (position);
			if (finalfunc < _bestFinalFunc)
			{
                _prevFinalFunc = _bestFinalFunc;
				_bestFinalFunc = finalfunc;
				_bestPosition = (double[])position.Clone();
                _Dist = part_dist;
			}

			return finalfunc;
		}

        public double Dist
        {
            get { return _Dist; }
        }

        /// <summary>
        /// Предыдущее значение функции цели
        /// </summary>
        public double PrevFinalFunc
        {
            get { return _prevFinalFunc; }
        }

        public double Dif_Func
        {
            get{ return (Math.Abs(_bestFinalFunc-_prevFinalFunc));}
        }
     

	}
}
