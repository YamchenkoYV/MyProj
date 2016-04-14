namespace ParticleGui
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox algorithmBox;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.GroupBox groupBox3;
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NM_For_All = new System.Windows.Forms.RadioButton();
            this.NM_For_Ten_Pc = new System.Windows.Forms.RadioButton();
            this.NM_For_One = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.NM_After = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NelderMeadCB = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.writeToFile = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this._directory = new System.Windows.Forms.TextBox();
            this._topologiesComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this._methodsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this._swarmSize = new System.Windows.Forms.NumericUpDown();
            this._dimension = new System.Windows.Forms.NumericUpDown();
            this._globalBestRatio = new System.Windows.Forms.TextBox();
            this._localBestRatio = new System.Windows.Forms.TextBox();
            this._currentVelocityRatio = new System.Windows.Forms.TextBox();
            this._tasksComboBox = new System.Windows.Forms.ComboBox();
            this.startTest = new System.Windows.Forms.Button();
            this._1000Iterations = new System.Windows.Forms.Button();
            this._100Iterations = new System.Windows.Forms.Button();
            this._10Iterations = new System.Windows.Forms.Button();
            this._1Iteration = new System.Windows.Forms.Button();
            this._createSwarm = new System.Windows.Forms.Button();
            this._finalFuncTextBox = new System.Windows.Forms.TextBox();
            this._bestPosition = new System.Windows.Forms.TextBox();
            this._swarmGraph = new ZedGraph.ZedGraphControl();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            algorithmBox = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            algorithmBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._swarmSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dimension)).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // algorithmBox
            // 
            algorithmBox.Controls.Add(this.groupBox5);
            algorithmBox.Controls.Add(this.groupBox4);
            algorithmBox.Controls.Add(this._topologiesComboBox);
            algorithmBox.Controls.Add(this.label10);
            algorithmBox.Controls.Add(this._methodsComboBox);
            algorithmBox.Controls.Add(this.label7);
            algorithmBox.Controls.Add(this._swarmSize);
            algorithmBox.Controls.Add(this._dimension);
            algorithmBox.Controls.Add(label6);
            algorithmBox.Controls.Add(this._globalBestRatio);
            algorithmBox.Controls.Add(label5);
            algorithmBox.Controls.Add(label4);
            algorithmBox.Controls.Add(this._localBestRatio);
            algorithmBox.Controls.Add(label3);
            algorithmBox.Controls.Add(this._currentVelocityRatio);
            algorithmBox.Controls.Add(label2);
            algorithmBox.Controls.Add(this._tasksComboBox);
            algorithmBox.Controls.Add(label1);
            algorithmBox.Location = new System.Drawing.Point(12, 12);
            algorithmBox.Name = "algorithmBox";
            algorithmBox.Size = new System.Drawing.Size(335, 485);
            algorithmBox.TabIndex = 0;
            algorithmBox.TabStop = false;
            algorithmBox.Text = "Параметры алгоритма";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NM_For_All);
            this.groupBox5.Controls.Add(this.NM_For_Ten_Pc);
            this.groupBox5.Controls.Add(this.NM_For_One);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.NM_After);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.NelderMeadCB);
            this.groupBox5.Location = new System.Drawing.Point(6, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 117);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nelder Mead";
            // 
            // NM_For_All
            // 
            this.NM_For_All.AutoSize = true;
            this.NM_For_All.Enabled = false;
            this.NM_For_All.Location = new System.Drawing.Point(121, 90);
            this.NM_For_All.Name = "NM_For_All";
            this.NM_For_All.Size = new System.Drawing.Size(85, 17);
            this.NM_For_All.TabIndex = 20;
            this.NM_For_All.TabStop = true;
            this.NM_For_All.Text = "всех частиц";
            this.NM_For_All.UseVisualStyleBackColor = true;
            // 
            // NM_For_Ten_Pc
            // 
            this.NM_For_Ten_Pc.AutoSize = true;
            this.NM_For_Ten_Pc.Enabled = false;
            this.NM_For_Ten_Pc.Location = new System.Drawing.Point(121, 67);
            this.NM_For_Ten_Pc.Name = "NM_For_Ten_Pc";
            this.NM_For_Ten_Pc.Size = new System.Drawing.Size(120, 17);
            this.NM_For_Ten_Pc.TabIndex = 19;
            this.NM_For_Ten_Pc.TabStop = true;
            this.NM_For_Ten_Pc.Text = "10% лучших частиц";
            this.NM_For_Ten_Pc.UseVisualStyleBackColor = true;
            // 
            // NM_For_One
            // 
            this.NM_For_One.AutoSize = true;
            this.NM_For_One.Enabled = false;
            this.NM_For_One.Location = new System.Drawing.Point(121, 47);
            this.NM_For_One.Name = "NM_For_One";
            this.NM_For_One.Size = new System.Drawing.Size(139, 17);
            this.NM_For_One.TabIndex = 18;
            this.NM_For_One.TabStop = true;
            this.NM_For_One.Text = "одной лучшей частицы";
            this.NM_For_One.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Для:";
            // 
            // NM_After
            // 
            this.NM_After.Enabled = false;
            this.NM_After.Location = new System.Drawing.Point(211, 11);
            this.NM_After.Name = "NM_After";
            this.NM_After.Size = new System.Drawing.Size(100, 20);
            this.NM_After.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "через";
            // 
            // NelderMeadCB
            // 
            this.NelderMeadCB.AutoSize = true;
            this.NelderMeadCB.Location = new System.Drawing.Point(6, 19);
            this.NelderMeadCB.Name = "NelderMeadCB";
            this.NelderMeadCB.Size = new System.Drawing.Size(87, 17);
            this.NelderMeadCB.TabIndex = 14;
            this.NelderMeadCB.Text = "Nelder Mead";
            this.NelderMeadCB.UseVisualStyleBackColor = true;
            this.NelderMeadCB.CheckedChanged += new System.EventHandler(this.NelderMead_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.writeToFile);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this._directory);
            this.groupBox4.Location = new System.Drawing.Point(6, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 76);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Запись в файл";
            // 
            // writeToFile
            // 
            this.writeToFile.AutoSize = true;
            this.writeToFile.Location = new System.Drawing.Point(6, 24);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.Size = new System.Drawing.Size(101, 17);
            this.writeToFile.TabIndex = 6;
            this.writeToFile.Text = "Запись в файл";
            this.writeToFile.UseVisualStyleBackColor = true;
            this.writeToFile.CheckedChanged += new System.EventHandler(this.writeToFile_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Сохранить в папке";
            // 
            // _directory
            // 
            this._directory.Location = new System.Drawing.Point(217, 46);
            this._directory.Name = "_directory";
            this._directory.ReadOnly = true;
            this._directory.Size = new System.Drawing.Size(100, 20);
            this._directory.TabIndex = 7;
            this._directory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _topologiesComboBox
            // 
            this._topologiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._topologiesComboBox.FormattingEnabled = true;
            this._topologiesComboBox.Location = new System.Drawing.Point(141, 96);
            this._topologiesComboBox.Name = "_topologiesComboBox";
            this._topologiesComboBox.Size = new System.Drawing.Size(188, 21);
            this._topologiesComboBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Топология";
            // 
            // _methodsComboBox
            // 
            this._methodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._methodsComboBox.FormattingEnabled = true;
            this._methodsComboBox.Location = new System.Drawing.Point(141, 60);
            this._methodsComboBox.Name = "_methodsComboBox";
            this._methodsComboBox.Size = new System.Drawing.Size(188, 21);
            this._methodsComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Метод";
            // 
            // _swarmSize
            // 
            this._swarmSize.Location = new System.Drawing.Point(262, 254);
            this._swarmSize.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this._swarmSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._swarmSize.Name = "_swarmSize";
            this._swarmSize.Size = new System.Drawing.Size(67, 20);
            this._swarmSize.TabIndex = 5;
            this._swarmSize.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // _dimension
            // 
            this._dimension.Location = new System.Drawing.Point(262, 135);
            this._dimension.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._dimension.Name = "_dimension";
            this._dimension.Size = new System.Drawing.Size(67, 20);
            this._dimension.TabIndex = 1;
            this._dimension.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 254);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 13);
            label6.TabIndex = 2;
            label6.Text = "Количество частиц";
            // 
            // _globalBestRatio
            // 
            this._globalBestRatio.Location = new System.Drawing.Point(262, 223);
            this._globalBestRatio.Name = "_globalBestRatio";
            this._globalBestRatio.Size = new System.Drawing.Size(67, 20);
            this._globalBestRatio.TabIndex = 4;
            this._globalBestRatio.Text = "1.4";
            this._globalBestRatio.TextChanged += new System.EventHandler(this._globalBestRatio_TextChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 137);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 13);
            label5.TabIndex = 2;
            label5.Text = "Размерность задачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 223);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(206, 13);
            label4.TabIndex = 2;
            label4.Text = "Коэфф. глобального лучшего значения";
            // 
            // _localBestRatio
            // 
            this._localBestRatio.Location = new System.Drawing.Point(262, 190);
            this._localBestRatio.Name = "_localBestRatio";
            this._localBestRatio.Size = new System.Drawing.Size(67, 20);
            this._localBestRatio.TabIndex = 3;
            this._localBestRatio.Text = "1.4";
            this._localBestRatio.TextChanged += new System.EventHandler(this._localBestRatio_TextChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 190);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(212, 13);
            label3.TabIndex = 2;
            label3.Text = "Коэфф. собственного лучшего значения";
            // 
            // _currentVelocityRatio
            // 
            this._currentVelocityRatio.Location = new System.Drawing.Point(262, 164);
            this._currentVelocityRatio.Name = "_currentVelocityRatio";
            this._currentVelocityRatio.Size = new System.Drawing.Size(67, 20);
            this._currentVelocityRatio.TabIndex = 2;
            this._currentVelocityRatio.Text = "0.9";
            this._currentVelocityRatio.TextChanged += new System.EventHandler(this._currentVelocityRatio_TextChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 164);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 13);
            label2.TabIndex = 2;
            label2.Text = "Коэфф. текущей скорости";
            // 
            // _tasksComboBox
            // 
            this._tasksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._tasksComboBox.FormattingEnabled = true;
            this._tasksComboBox.Location = new System.Drawing.Point(141, 25);
            this._tasksComboBox.Name = "_tasksComboBox";
            this._tasksComboBox.Size = new System.Drawing.Size(188, 21);
            this._tasksComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 13);
            label1.TabIndex = 0;
            label1.Text = "Целевая функция";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.startTest);
            groupBox1.Controls.Add(this._1000Iterations);
            groupBox1.Controls.Add(this._100Iterations);
            groupBox1.Controls.Add(this._10Iterations);
            groupBox1.Controls.Add(this._1Iteration);
            groupBox1.Controls.Add(this._createSwarm);
            groupBox1.Location = new System.Drawing.Point(6, 503);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(335, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // startTest
            // 
            this.startTest.Location = new System.Drawing.Point(48, 82);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(240, 23);
            this.startTest.TabIndex = 11;
            this.startTest.Text = "Запуск теста";
            this.startTest.UseVisualStyleBackColor = true;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // _1000Iterations
            // 
            this._1000Iterations.Location = new System.Drawing.Point(48, 198);
            this._1000Iterations.Name = "_1000Iterations";
            this._1000Iterations.Size = new System.Drawing.Size(240, 23);
            this._1000Iterations.TabIndex = 10;
            this._1000Iterations.Text = "Выполнить 1000 итераций";
            this._1000Iterations.UseVisualStyleBackColor = true;
            this._1000Iterations.Click += new System.EventHandler(this._1000Iterations_Click);
            // 
            // _100Iterations
            // 
            this._100Iterations.Location = new System.Drawing.Point(48, 169);
            this._100Iterations.Name = "_100Iterations";
            this._100Iterations.Size = new System.Drawing.Size(240, 23);
            this._100Iterations.TabIndex = 9;
            this._100Iterations.Text = "Выполнить 100 итераций";
            this._100Iterations.UseVisualStyleBackColor = true;
            this._100Iterations.Click += new System.EventHandler(this._100Iterations_Click);
            // 
            // _10Iterations
            // 
            this._10Iterations.Location = new System.Drawing.Point(48, 140);
            this._10Iterations.Name = "_10Iterations";
            this._10Iterations.Size = new System.Drawing.Size(240, 23);
            this._10Iterations.TabIndex = 8;
            this._10Iterations.Text = "Выполнить 10 итераций";
            this._10Iterations.UseVisualStyleBackColor = true;
            this._10Iterations.Click += new System.EventHandler(this._10Iterations_Click);
            // 
            // _1Iteration
            // 
            this._1Iteration.Location = new System.Drawing.Point(48, 111);
            this._1Iteration.Name = "_1Iteration";
            this._1Iteration.Size = new System.Drawing.Size(240, 23);
            this._1Iteration.TabIndex = 7;
            this._1Iteration.Text = "Выполнить одну итерацию";
            this._1Iteration.UseVisualStyleBackColor = true;
            this._1Iteration.Click += new System.EventHandler(this._1Iteration_Click);
            // 
            // _createSwarm
            // 
            this._createSwarm.Location = new System.Drawing.Point(48, 19);
            this._createSwarm.Name = "_createSwarm";
            this._createSwarm.Size = new System.Drawing.Size(240, 23);
            this._createSwarm.TabIndex = 6;
            this._createSwarm.Text = "Создать рой";
            this._createSwarm.UseVisualStyleBackColor = true;
            this._createSwarm.Click += new System.EventHandler(this._createSwarm_Click);
            // 
            // groupBox2
            // 
            groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            groupBox2.Controls.Add(this._finalFuncTextBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(this._bestPosition);
            groupBox2.Location = new System.Drawing.Point(353, 310);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(335, 439);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Решение";
            // 
            // _finalFuncTextBox
            // 
            this._finalFuncTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._finalFuncTextBox.Location = new System.Drawing.Point(200, 413);
            this._finalFuncTextBox.Name = "_finalFuncTextBox";
            this._finalFuncTextBox.ReadOnly = true;
            this._finalFuncTextBox.Size = new System.Drawing.Size(129, 20);
            this._finalFuncTextBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 416);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(146, 13);
            label8.TabIndex = 2;
            label8.Text = "Значение целевой функции";
            // 
            // _bestPosition
            // 
            this._bestPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._bestPosition.Location = new System.Drawing.Point(0, 33);
            this._bestPosition.Multiline = true;
            this._bestPosition.Name = "_bestPosition";
            this._bestPosition.ReadOnly = true;
            this._bestPosition.Size = new System.Drawing.Size(320, 374);
            this._bestPosition.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox3.Controls.Add(this._swarmGraph);
            groupBox3.Location = new System.Drawing.Point(353, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(327, 292);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Область решения";
            // 
            // _swarmGraph
            // 
            this._swarmGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this._swarmGraph.Location = new System.Drawing.Point(3, 16);
            this._swarmGraph.Name = "_swarmGraph";
            this._swarmGraph.ScrollGrace = 0D;
            this._swarmGraph.ScrollMaxX = 0D;
            this._swarmGraph.ScrollMaxY = 0D;
            this._swarmGraph.ScrollMaxY2 = 0D;
            this._swarmGraph.ScrollMinX = 0D;
            this._swarmGraph.ScrollMinY = 0D;
            this._swarmGraph.ScrollMinY2 = 0D;
            this._swarmGraph.Size = new System.Drawing.Size(321, 273);
            this._swarmGraph.TabIndex = 0;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 761);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(algorithmBox);
            this.Name = "MainForm";
            this.Text = "Метод роя частиц";
            algorithmBox.ResumeLayout(false);
            algorithmBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._swarmSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dimension)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox _tasksComboBox;
		private System.Windows.Forms.TextBox _currentVelocityRatio;
		private System.Windows.Forms.TextBox _localBestRatio;
		private System.Windows.Forms.TextBox _globalBestRatio;
		private System.Windows.Forms.NumericUpDown _dimension;
		private System.Windows.Forms.NumericUpDown _swarmSize;
		private System.Windows.Forms.Button _1Iteration;
		private System.Windows.Forms.Button _createSwarm;
		private System.Windows.Forms.Button _1000Iterations;
		private System.Windows.Forms.Button _100Iterations;
		private System.Windows.Forms.Button _10Iterations;
		private System.Windows.Forms.TextBox _bestPosition;
		private System.Windows.Forms.TextBox _finalFuncTextBox;
		private ZedGraph.ZedGraphControl _swarmGraph;
		private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.CheckBox writeToFile;
        private System.Windows.Forms.TextBox _directory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _methodsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _topologiesComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton NM_For_All;
        private System.Windows.Forms.RadioButton NM_For_Ten_Pc;
        private System.Windows.Forms.RadioButton NM_For_One;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NM_After;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox NelderMeadCB;
        private System.Windows.Forms.GroupBox groupBox4;
	}
}

