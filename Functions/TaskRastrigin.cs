using System;

using ParticleSwarm;

namespace Functions
{
	public class TaskRastrigin: Task
	{
		public TaskRastrigin (double[] minvalues, double[] maxvalues)
			:
			base (minvalues, maxvalues)
		{

		}

        public override double FinalFunction(double[] position)
		{
			double result = 0.0;

			foreach (double x in position)
			{
				result += x * x - 10.0 * Math.Cos (2.0 * Math.PI * x);
			}

			result += 10.0 * MinValues.Length + GetPenalty (position, 10000.0);

			return result;
		}
	}
}
