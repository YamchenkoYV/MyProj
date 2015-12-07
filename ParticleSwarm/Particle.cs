using System;
using System.Diagnostics;
using System.Text;

namespace ParticleSwarm
{
	/// <summary>
	/// Класс, описывающий одну частицу
	/// </summary>
	public class Particle
	{
		public Particle (Swarm swarm)
		{
			//_random = new Random ();
			_swarm = swarm;
            _currentPosition = GetInitPosition (swarm);
            double summ = 0.0;
            for (int i = 0; i < _swarm.Dimension; i++)
                summ += _currentPosition[i];

            Dist = Math.Abs(summ - 1.0);

			
			_localBestPosition = (double[])_currentPosition.Clone ();

//            if (Dist < Eps)
                _localBestFinalFunc = swarm.FinalFunction(_currentPosition, Dist);
  //          else
//             {
//                 _localBestFinalFunc = Double.MaxValue;
//                 swarm.Swarm_Best_Dist(_currentPosition, Dist);
//             }
			_velocity = GetInitVelocity (swarm);
		}


		double[] GetInitPosition (Swarm swarm)
		{
			double[] position = new double[swarm.Dimension];

			for (int i = 0; i < swarm.Dimension; i++)
			{
				position[i] = _random.NextDouble () * 
					(swarm.MaxValues[i] - swarm.MinValues[i]) + swarm.MinValues[i];
			}

			Debug.Assert (position.Length == swarm.MinValues.Length);
			Debug.Assert (position.Length == swarm.MaxValues.Length);

			return position;
		}


		/// <summary>
		/// Получить начальное значение скорости
		/// </summary>
		/// <param name="task"></param>
		/// <returns></returns>
		double[] GetInitVelocity (Swarm swarm)
		{
			double[] velocity = new double[swarm.Dimension];

			for (int i = 0; i < swarm.Dimension; i++)
			{
				double minval = -(swarm.MaxValues[i] - swarm.MinValues[i]);
				double maxval = (swarm.MaxValues[i] - swarm.MinValues[i]);
                
				velocity[i] = _random.NextDouble () * (maxval - minval) + minval;
			}

			Debug.Assert (velocity.Length == swarm.MinValues.Length);
			Debug.Assert (velocity.Length == swarm.MaxValues.Length);

			return velocity;
		}

		static Random _random = new Random();
		Swarm _swarm;

		double[] _currentPosition;

		/// <summary>
		/// Текущая координата частицы
		/// </summary>
		public double[] Position
		{
			get { return _currentPosition; }
		}

		double[] _localBestPosition;
		double _localBestFinalFunc;


		double[] _velocity;

		/// <summary>
		/// Текущая скорость частицы
		/// </summary>
		public double[] Velocity
		{
			get { return _velocity; }
		}


		/// <summary>
		/// Скорректировать скорость и передвинуть частицу
		/// </summary>
		internal void NextIteration ()
		{
			CorrectVelocity ();
			MoveSelf ();
			CheckFinalFunc ();
		}


		/// <summary>
		/// Проверить, нашли ли мы более хорошую целевую функцию
		/// </summary>

        double Eps = 0.01;
        double Dist = Double.MaxValue;

		private void CheckFinalFunc ()
		{
			
            double summ = 0.0;
            for (int i = 0; i < _swarm.Dimension; i++ )
                summ += _currentPosition[i];

            double dist = Math.Abs(summ - 1.0);

//            if (dist < Eps)
 //           {
                
                double finalfunc = _swarm.FinalFunction(_currentPosition, dist);
                if (finalfunc < _localBestFinalFunc)
                {
                    Dist = dist;
                    _localBestFinalFunc = finalfunc;
                    _localBestPosition = (double[])(_currentPosition.Clone());
                }
/*            }
            else if (dist < Dist)
            {
                Dist =_swarm.Swarm_Best_Dist(_currentPosition, dist);;
                
                _localBestPosition = (double[])(_currentPosition.Clone());
            }*/
		}

		private void MoveSelf ()
		{
			for (int i = 0; i < _swarm.Dimension; i++)
			{
				_currentPosition[i] += _velocity[i];
			}
		}


		/// <summary>
		/// Скорректировать скорость и переместить частицу
		/// </summary>
		private void CorrectVelocity ()
		{
			double veloRatio = _swarm.LocalVelocityRatio + _swarm.GlobalVelocityRatio;

			double commonRatio = (2.0 * _swarm.CurrentVelocityRatio /
				(Math.Abs (2.0 - veloRatio - 
					Math.Sqrt (veloRatio * veloRatio - 4.0 * veloRatio) ) ) );

			for (int i = 0; i < _swarm.Dimension; i++)
			{
				double newVelocity_part1 = commonRatio * _velocity[i];

				double newVelocity_part2 = commonRatio * 
					_swarm.LocalVelocityRatio *
					_random.NextDouble () *
					(_localBestPosition[i] - _currentPosition[i]);

				double newVelocity_part3 = commonRatio * 
					_swarm.GlobalVelocityRatio *
					_random.NextDouble () *
					(_swarm.BestPosition[i] - _currentPosition[i]);

				_velocity[i] = newVelocity_part1 + newVelocity_part2 + newVelocity_part3;

			}	// for (int i = 0; i < _swarm.Dimension; i++)
        }	// private void CorrectVelocity ()


        private void CorrectVelocity_mod1()
        {
            double localVelocityRatio = _random.NextDouble() * _swarm.LocalVelocityRatio;
            double globalVelocityRatio = _random.NextDouble() * _swarm.GlobalVelocityRatio;

            for (int i = 0; i < _swarm.Dimension; i++)
            {
                double newVelocity_part1 = _swarm.CurrentVelocityRatio *_velocity[i];

                double newVelocity_part2 = 
                    localVelocityRatio *                  
                    (_localBestPosition[i] - _currentPosition[i]);

                double newVelocity_part3 =
                    globalVelocityRatio *                  
                    (_swarm.BestPosition[i] - _currentPosition[i]);

                _velocity[i] = newVelocity_part1 + newVelocity_part2 + newVelocity_part3;

            }

        }
	}
}
