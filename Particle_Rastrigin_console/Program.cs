using System;

using ParticleSwarm;
using Functions;

namespace Particle_Rastrigin_console
{
	class Program
	{
		static void Main (string[] args)
		{
			int itercount = 1000;
			int dimension = 4;
			int swarmsize = 3000;

			double currentVelocityRatio = 0.3;
			double localVelocityRatio = 2;
			double globalVelocityRatio = 5;

			double[] minvalues = new double[dimension];
			double[] maxvalues = new double[dimension];

			for (int i = 0; i < dimension; i++)
			{
				minvalues[i] = -5.12;
				maxvalues[i] = 5.12;
			}

			Task task = new TaskRastrigin (minvalues, maxvalues);

			Swarm swarm = new Swarm (task,
				swarmsize,
				currentVelocityRatio,
				localVelocityRatio,
				globalVelocityRatio
				);


			for (int iteration = 0; iteration < itercount; iteration++)
			{
				Console.WriteLine (Utilites.ResultToString (swarm));
				swarm.NextIteration ();
			}

			Console.Read ();
		}
	}
}
