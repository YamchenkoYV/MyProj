using System;

using ParticleSwarm;

namespace Functions
{
	public class TaskSchwefel: Task
	{
		public TaskSchwefel (double[] minvalues, double[] maxvalues)
			:
			base (minvalues, maxvalues)
		{

		}

        public override double FinalFunction(double[] position)
		{
			double result = 0.0;

			foreach (double x in position)
			{
				result += -x * Math.Sin (Math.Sqrt (Math.Abs (x) ) );
			}

			result += GetPenalty (position, 10000.0);

			return result;
		}
	}
}
