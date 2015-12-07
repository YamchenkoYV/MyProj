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
			double globalVelocityRatio)
		{
			//Debug.Assert ((localVelocityRatio + globalVelocityRatio) > 4);

			_task = task;
			_currentVelocityRatio = currentVelocityRatio;
			_localVelocityRatio = localVelocityRatio;
			_globalVelocityRatio = globalVelocityRatio;
			_iteration = 0;

			_particles = CreateParticles (swarmsize);
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


		Particle[] CreateParticles (int swarmSize)
		{
			Particle[] swarm = new Particle[swarmSize];
			for (int i = 0; i < swarmSize; i++)
			{
				swarm[i] = new Particle (this);
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
