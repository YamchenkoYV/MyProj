using System;
using System.Collections.Generic;
using System.Text;

using Functions;
using ParticleSwarm;
using System.Diagnostics;

namespace ParticleGui.Tasks
{
    class MyTaskGui : ITaskGui
    {
        double[] _minvalues;
        double[] _maxvalues;
        double extr = 0.0;

        #region ITaskGui Members

        public Task CreateTask(int dimension)
        {
            _minvalues = new double[dimension];
            _maxvalues = new double[dimension];

          /*  for (int i = 0; i < dimension; i++)
            {
                _minvalues[i] = -100.0;
                _maxvalues[i] = 100.0;
            }*/
          
            _minvalues[0] = 0.520661157;
            _maxvalues[0] = 0.636364;

            _minvalues[1] = 0.02892562;
            _maxvalues[1] = 1.0;

            _minvalues[2] = 0.024793388;
            _maxvalues[2] = 1.0;

            _minvalues[3] = 0.074380165;
            _maxvalues[3] = 1.0;

            _minvalues[4] = 0.095041322;
            _maxvalues[4] = 1.0;

            Task task = new MyTask(_minvalues, _maxvalues);

            return task;
        }

        public double Extr
        {
            get { return extr; }
        }


        public string Name
        {
            get { return "MyFunc"; }
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