using System;
using System.Collections.Generic;
using System.Text;

using Functions;
using ParticleSwarm;
using System.Diagnostics;

namespace ParticleGui.Tasks
{
    class TaskGuiRosenbrock : ITaskGui
    {
        double[] _minvalues;
        double[] _maxvalues;
        double extr = 0.0;

        #region ITaskGui Members

        public Task CreateTask(int dimension)
        {
            _minvalues = new double[dimension];
            _maxvalues = new double[dimension];

            for (int i = 0; i < dimension; i++)
            {
                _minvalues[i] = -5.0;
                _maxvalues[i] = 5.0;
            }

            Task task = new TaskRosenbrock(_minvalues, _maxvalues);

            return task;
        }

        public double Extr
        {
            get { return extr; }
        }

        public string Name
        {
            get { return "Функция Розенброка"; }
        }


        public double[] MinValues
        {
            get
            {
                Debug.Assert(_minvalues != null);
                return _minvalues;
            }
        }


        public double[] MaxValues
        {
            get
            {
                Debug.Assert(_maxvalues != null);
                return _maxvalues;
            }
        }

        #endregion
    }
}
