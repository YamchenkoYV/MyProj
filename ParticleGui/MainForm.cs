using System;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;

using ZedGraph;

using ParticleGui.Tasks;
using ParticleSwarm;



namespace ParticleGui
{
	public partial class MainForm : Form
	{
		public MainForm ()
		{
			InitializeComponent ();

			CreateTasks ();
			InitGuiElelemts ();
		}

		void InitGuiElelemts ()
		{
			foreach (ITaskGui task in _tasks)
			{
				_tasksComboBox.Items.Add (task.Name);
			}

			if (_tasksComboBox.Items.Count != 0)
			{
				_tasksComboBox.SelectedIndex = 0;
			}

			SetGraphOptions ();
		}

		void CreateTasks ()
		{

			_tasks.Add (new TaskGuiX2 ());
			_tasks.Add (new TaskGuiShwefel ());
			_tasks.Add (new TaskGuiRastrigin ());
            _tasks.Add (new TaskGuiRosenbrock());
            _tasks.Add (new MyTaskGui());
		}

		List<ITaskGui> _tasks = new List<ITaskGui> ();


		private void _createSwarm_Click (object sender, EventArgs e)
		{
            Initialize();
		}

        private void Initialize()
        {
            _errorProvider.Clear();

            double currentVelocityRatio;
            try
            {
                currentVelocityRatio = Convert.ToDouble(_currentVelocityRatio.Text,
                    CultureInfo.InvariantCulture);

            }
            catch (FormatException)
            {
                _errorProvider.SetIconAlignment(_currentVelocityRatio,
                    ErrorIconAlignment.MiddleLeft);

                _errorProvider.SetError(_currentVelocityRatio, "Неправильный формат числа");
                return;
            }


            double localBestRatio;
            try
            {
                localBestRatio = Convert.ToDouble(_localBestRatio.Text,
                    CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                _errorProvider.SetIconAlignment(_localBestRatio,
                    ErrorIconAlignment.MiddleLeft);

                _errorProvider.SetError(_localBestRatio, "Неправильный формат числа");
                return;
            }


            double globalBestRatio;
            try
            {
                globalBestRatio = Convert.ToDouble(_globalBestRatio.Text,
                    CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                _errorProvider.SetIconAlignment(_globalBestRatio,
                    ErrorIconAlignment.MiddleLeft);

                _errorProvider.SetError(_globalBestRatio, "Неправильный формат числа");
                return;
            }

           /* if ((localBestRatio + globalBestRatio) <= 4)
            {
                _errorProvider.SetIconAlignment(_globalBestRatio,
                    ErrorIconAlignment.MiddleLeft);

                _errorProvider.SetError(_globalBestRatio, "Сумма значений 'Коэфф. собственного лучшего значения' и 'Коэфф. глобального лучшего значения' должна быть больше 4");
                return;
            }*/

            int dimension;

            if (_tasksComboBox.SelectedIndex == 4)
                dimension = 5;
            else
                dimension = (int)_dimension.Value;

            int swarmSize = (int)_swarmSize.Value;

            _currentTask = _tasks[_tasksComboBox.SelectedIndex];
            Task task = _currentTask.CreateTask(dimension);

            CreateSwarm(
                task,
                swarmSize,
                currentVelocityRatio,
                localBestRatio,
                globalBestRatio);
        }

		ITaskGui _currentTask = null;
		Swarm _swarm = null;


		void CreateSwarm (
			Task task,
			int swarmSize,
			double currentVelocityRatio,
			double localBestRatio,
			double globalBestRatio)
		{
			_swarm = new Swarm (task,
				swarmSize,
				currentVelocityRatio,
				localBestRatio,
				globalBestRatio
				);

			UpdateResults ();
		}

        /// <summary>
        /// Значение минимальной погрешности
        /// </summary>
        double E = 0.000001;
        int  dI = 0;

        Random rand = new Random();

		int RunIterations (int iterationCount, bool wtf=true)
		{
            int i = 0;
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            int dk = (int)(0.8*MaxCountOfRuns/(_swarm.Size-2.0)); //Шаг
            int dsob = (int)(0.8 * MaxCountOfRuns / 5.0);//Шаг для собственного значения

            int k = dk;
            int sob = dsob;

			if (_swarm == null)
			{
				return 0;
			}

			Debug.Assert (_currentTask != null);


            for (i = 0; i < iterationCount; i++)
            {

                if (i == sob)
                {
                    sob += dsob;
                    double curVelRatio = _swarm.CurrentVelocityRatio;
                    _swarm.SetCurrentVelocityRatio(curVelRatio - 0.1);
                }

                if (i == k)
                {
                    k += dk;
                    int first, second;
                    do
                    {
                        first = rand.Next(0, _swarm.Size - 1);
                        second = rand.Next(0, _swarm.Size - 1);
                    } while ((first == second) && _swarm.IsNeighbours(first,second));
                    _swarm.SetNeighbours(first,second);        
                }

                if(writeToFile.Checked)
                  list.Add(_swarm.BestFinalFunc);

                _swarm.NextIteration();
                if (_swarm.Dif_Func <= E && dI == 20)
                {                    
                    break;
                }
                else if (_swarm.Dif_Func <= E  && iterationCount>1000)
                {
                    dI++;
                }
                else
                {
                    dI = 0;
                }

            }

            if (writeToFile.Checked && wtf)
            {
                
                String path = "C:\\Users\\Юрий\\Desktop\\.net\\log\\FIPS";
                int files = 0;
                System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                // ищем в корневом каталоге
                files += directoryInfo.GetFiles("*.*").Length;
            }
                Console.WriteLine(files);
                String filename = "\\File_" + files.ToString() + ".txt";
                path += filename;
                
                int counter = 0;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@path))
                {
                    var ci = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentCulture = ci;
                    foreach (double numb in list)
                    {
                       
                        // If the line doesn't contain the word 'Second', write the line to the file.
                        String str = counter.ToString() + " " + numb; 
                        file.WriteLine(str);
                        counter++;
                    }
                }
            }

			UpdateResults ();
            return i;
		}


		public string ResultToString (Swarm swarm)
		{
			StringBuilder builder = new StringBuilder ();

			if (swarm.BestPosition != null)
			{

				for (int i = 0; i < swarm.Dimension; i++)
				{
					builder.AppendFormat ("X[{0}] = {1}\r\n", i, swarm.BestPosition[i]);

				}

                builder.AppendFormat("Iteration = {0}\r\n", swarm.Iteration);
                builder.AppendFormat("dI = {0}\r\n\n", dI);
                builder.AppendFormat("_Dist = {0}\r\n\n", swarm.Dist);
			}
			return builder.ToString ();
		}


		void UpdateResults ()
		{
			Debug.Assert (_swarm != null);
			Debug.Assert (_currentTask != null);

			_bestPosition.Text = ResultToString (_swarm);
			_finalFuncTextBox.Text = _swarm.BestFinalFunc.ToString ();
			UpdateSwarmGraph ();
		}

		void SetGraphOptions ()
		{
			GraphPane pane = _swarmGraph.GraphPane;

			pane.IsFontsScaled = false;
			pane.XAxis.Title.IsVisible = false;
			pane.YAxis.Title.IsVisible = false;
			pane.Title.IsVisible = false;
			pane.Margin.All = 8;

			_swarmGraph.AxisChange ();
			_swarmGraph.Invalidate ();
		}


		void UpdateSwarmGraph ()
		{
			Debug.Assert (_swarm != null);
			Debug.Assert (_swarm.Dimension >= 2);

			PointPairList particlesList = new PointPairList ();
			foreach (Particle particle in _swarm.Particles)
			{
				particlesList.Add (particle.Position[0], particle.Position[1]);
			}

			GraphPane pane = _swarmGraph.GraphPane;
			pane.CurveList.Clear ();

			if (_swarm.Iteration == 0)
			{
				pane.XAxis.Scale.Min = _currentTask.MinValues[0];
				pane.XAxis.Scale.Max = _currentTask.MaxValues[0];

				pane.YAxis.Scale.Min = _currentTask.MinValues[1];
				pane.YAxis.Scale.Max = _currentTask.MaxValues[1];
			}

			LineItem particlesCurve = pane.AddCurve ("Все решения", particlesList,
				Color.Black, SymbolType.Default);

			particlesCurve.Line.IsVisible = false;
			particlesCurve.Symbol.Fill.Color = Color.Black;
			particlesCurve.Symbol.Fill.Type = FillType.Solid;
			particlesCurve.Symbol.Size = 2;

			_swarmGraph.AxisChange ();
			_swarmGraph.Invalidate ();
		}


		private void _1Iteration_Click (object sender, EventArgs e)
		{
			RunIterations (1);
		}

		private void _10Iterations_Click (object sender, EventArgs e)
		{
			RunIterations (10);
		}

		private void _100Iterations_Click (object sender, EventArgs e)
		{
			RunIterations (100);
		}

		private void _1000Iterations_Click (object sender, EventArgs e)
		{
			RunIterations (1000);
		}

        int MaxCountOfRuns = 100000;

        
        int N = 10; //число испытаний
        int IterCounter = 0; //Число успешных попыток
        int CountOfSolv = 0; //Суммарное число вычислений целевой функции за все попытки
        double BestFuncValue = 0.0; //Лучшее значение ц.ф. за все попытки
        int Ix = 0; //Суммарная скорость сходимости за все попытки
       int GlobValueCounter = 0; //количество попыток достигших глобального экстремума

        private void button1_Click(object sender, EventArgs e)
        {
             IterCounter = 0; 
             CountOfSolv = 0; 
             BestFuncValue = 0.0; 
             Ix = 0;
             GlobValueCounter = 0;

            int Iter = 0; //Попытки
            dI = 0; //Область сходимости алгоритма



            do
            {
                //Запись в файл только последней итерации
                if(Iter == N-1)
                    RunIterations(MaxCountOfRuns,true);
                else
                    RunIterations(MaxCountOfRuns, false);

                if (dI == 20)
                {

                if (_swarm.BestFinalFunc > BestFuncValue)
                    BestFuncValue = _swarm.BestFinalFunc;

                if (Math.Abs(_swarm.BestFinalFunc - 0.390013615128399) < 0.05) //Найден глобальный экстремум
                    GlobValueCounter++;

               
                    IterCounter++;
                    Ix += _swarm.Iteration - 10;
                    CountOfSolv += _swarm.Counter;
                }
                dI = 0;
                

                
                Console.WriteLine(Iter);
                Initialize();
                Iter++;
                
            } while (Iter < N);

            int dIx = Ix / IterCounter;
            int dCountOfSolv = CountOfSolv / IterCounter;
            double theo_frec = (double) IterCounter / (double)N;
            double glob_theo_frec = (double)GlobValueCounter / (double)N;

            _bestPosition.Text = PrintResult(dIx, dCountOfSolv, theo_frec, glob_theo_frec);
        }

        public string PrintResult(int Id, int COS, double theo_frec, double glob_theo_frec)
        {
            StringBuilder builder = new StringBuilder();
                builder.AppendFormat("Средняя скорость сходимости = {0}\r\n", Id);
                builder.AppendFormat("Среднее число обращений к ц.ф. = {0}\r\n\n", COS);
                builder.AppendFormat("Лучшее значение ц.ф. = {0}\r\n\n", BestFuncValue);
                builder.AppendFormat("Вероятность нахождения нахождения экстремума = {0}\r\n\n", theo_frec);
                builder.AppendFormat("Вероятность нахождения нахождения глобального экстремума = {0}\r\n\n", glob_theo_frec);
            return builder.ToString();
        }





        private void _currentVelocityRatio_TextChanged(object sender, EventArgs e)
        {
            if (_swarm != null)
            {
                double currentVelocityRatio;
                try
                {
                    currentVelocityRatio = Convert.ToDouble(_currentVelocityRatio.Text,
                        CultureInfo.InvariantCulture);

                }
                catch (FormatException)
                {
                    _errorProvider.SetIconAlignment(_currentVelocityRatio,
                        ErrorIconAlignment.MiddleLeft);

                    _errorProvider.SetError(_currentVelocityRatio, "Неправильный формат числа");
                    return;
                }
                _swarm.SetCurrentVelocityRatio(currentVelocityRatio);
            }
         }

        private void _localBestRatio_TextChanged(object sender, EventArgs e)
        {
            if (_swarm != null)
            {
                double localBestRatio;
                try
                {
                    localBestRatio = Convert.ToDouble(_localBestRatio.Text,
                        CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    _errorProvider.SetIconAlignment(_localBestRatio,
                        ErrorIconAlignment.MiddleLeft);

                    _errorProvider.SetError(_localBestRatio, "Неправильный формат числа");
                    return;
                }
                /*if ((localBestRatio + _swarm.GlobalVelocityRatio) <= 4)
                {
                    _errorProvider.SetIconAlignment(_globalBestRatio,
                        ErrorIconAlignment.MiddleLeft);

                    _errorProvider.SetError(_globalBestRatio, "Сумма значений 'Коэфф. собственного лучшего значения' и 'Коэфф. глобального лучшего значения' должна быть больше 4");
                    return;
                }*/
                _swarm.SetLocalVelocityRatio(localBestRatio);
            }
        }

        private void _globalBestRatio_TextChanged(object sender, EventArgs e)
        {
            if (_swarm != null)
            {
                double globalBestRatio;
                try
                {
                    globalBestRatio = Convert.ToDouble(_globalBestRatio.Text,
                        CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    _errorProvider.SetIconAlignment(_globalBestRatio,
                        ErrorIconAlignment.MiddleLeft);

                    _errorProvider.SetError(_globalBestRatio, "Неправильный формат числа");
                    return;
                }

               /* if ((_swarm.LocalVelocityRatio + globalBestRatio) <= 4)
                {
                    _errorProvider.SetIconAlignment(_globalBestRatio,
                        ErrorIconAlignment.MiddleLeft);

                    _errorProvider.SetError(_globalBestRatio, "Сумма значений 'Коэфф. собственного лучшего значения' и 'Коэфф. глобального лучшего значения' должна быть больше 4");
                    return;
                }*/
                _swarm.SetGlobalVelocityRatio(globalBestRatio);
            }
        }



	}
}
