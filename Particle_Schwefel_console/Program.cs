using System;
using System.Collections.Generic;
using System.Text;

using ParticleSwarm;
using Functions;

namespace Particle_Schwefel_console
{
	class Program
	{
		static void Main (string[] args)
		{
			int itercount = 1000;
			int dimension = 4;
			int swarmsize = 10000;

			double currentVelocityRatio = 0.3;
			double localVelocityRatio = 2;
			double globalVelocityRatio = 5;

			double[] minvalues = new double[dimension];
			double[] maxvalues = new double[dimension];

			for (int i = 0; i < dimension; i++)
			{
				minvalues[i] = -500.0;
				maxvalues[i] = 500.0;
			}

			Task task = new TaskSchwefel (minvalues, maxvalues);

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
