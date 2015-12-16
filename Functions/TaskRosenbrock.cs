using System;

using ParticleSwarm;

namespace Functions
{
    public class TaskRosenbrock : Task
    {
        public TaskRosenbrock(double[] minvalues, double[] maxvalues)
			:
			base (minvalues, maxvalues)
		{

		}



        public override double FinalFunction(double[] position)
		{
			double result = 0.0;

			for (int i=0; i < (position.Length-1); i++)
			{
                result += 100.0 * Math.Pow((position[i + 1] - Math.Pow(position[i], 2.0)), 2.0) + Math.Pow((position[i] - 1.0), 2.0);
			}
            
            result += GetPenalty(position, 10000.0);
          
			return result;
		}
    }
}
