using System;

using ParticleSwarm;

namespace Functions
{
	public class TaskX2: Task
	{
		public TaskX2 (double[] minvalues, double[] maxvalues):
			base (minvalues, maxvalues)
		{

		}

		public override double FinalFunction (double[] position)
		{
			double result = 0.0;

			foreach (double x in position)
			{
				result += x * x;
			}

			result += GetPenalty (position, 10000.0);
           
			return result;
		}
	}
}
