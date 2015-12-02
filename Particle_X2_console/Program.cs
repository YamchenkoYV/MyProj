using System;
using System.Collections.Generic;
using System.Text;

using ParticleSwarm;
using Functions;

namespace Particle_X2_console
{
	class Program
	{
		static void Main (string[] args)
		{
			int itercount = 1000;
			int dimension = 6;
			int swarmsize = 300;

			double currentVelocityRatio = 0.3;
			double localVelocityRatio = 2;
			double globalVelocityRatio = 5;

			double[] minvalues = new double[dimension];
			double[] maxvalues = new double[dimension];

			for (int i = 0; i < dimension; i++)
			{
				minvalues[i] = -100.0;
				maxvalues[i] = 100.0;
			}

			Task task = new TaskX2 (minvalues, maxvalues);

			Swarm swarm = new Swarm (task,
				swarmsize,
				currentVelocityRatio,
				localVelocityRatio,
				globalVelocityRatio
				);


			for (int iteration = 0; iteration < itercount; iteration++)
			{
				Console.WriteLine (Utilites.ResultToString (swarm) );
				swarm.NextIteration ();
			}

			Console.Read ();
		}
	}
}
