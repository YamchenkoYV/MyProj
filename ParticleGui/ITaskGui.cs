using System;

using ParticleSwarm;


namespace ParticleGui
{
	/// <summary>
	/// Интерфейс для описания целевых функций в программе ParticleGui
	/// </summary>
	interface ITaskGui
	{
		Task CreateTask (int dimension);


		/// <summary>
		/// Название задачи (показывается в выпадающем списке)
		/// </summary>
		string Name
		{
			get;
		}

		double[] MinValues
		{
			get;
		}


		double[] MaxValues
		{
			get;
		}
	}
}
