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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.GroupBox groupBox3;
            this.writeToFile = new System.Windows.Forms.CheckBox();
            this._swarmSize = new System.Windows.Forms.NumericUpDown();
            this._dimension = new System.Windows.Forms.NumericUpDown();
            this._globalBestRatio = new System.Windows.Forms.TextBox();
            this._localBestRatio = new System.Windows.Forms.TextBox();
            this._currentVelocityRatio = new System.Windows.Forms.TextBox();
            this._tasksComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            label7 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            algorithmBox.SuspendLayout();
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
            algorithmBox.Controls.Add(this.writeToFile);
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
            algorithmBox.Size = new System.Drawing.Size(335, 311);
            algorithmBox.TabIndex = 0;
            algorithmBox.TabStop = false;
            algorithmBox.Text = "Параметры алгоритма";
            // 
            // writeToFile
            // 
            this.writeToFile.AutoSize = true;
            this.writeToFile.Location = new System.Drawing.Point(6, 256);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.Size = new System.Drawing.Size(101, 17);
            this.writeToFile.TabIndex = 6;
            this.writeToFile.Text = "Запись в файл";
            this.writeToFile.UseVisualStyleBackColor = true;
            // 
            // _swarmSize
            // 
            this._swarmSize.Location = new System.Drawing.Point(262, 224);
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
            300,
            0,
            0,
            0});
            // 
            // _dimension
            // 
            this._dimension.Location = new System.Drawing.Point(262, 69);
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
            label6.Location = new System.Drawing.Point(6, 224);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 13);
            label6.TabIndex = 2;
            label6.Text = "Количество частиц";
            // 
            // _globalBestRatio
            // 
            this._globalBestRatio.Location = new System.Drawing.Point(262, 183);
            this._globalBestRatio.Name = "_globalBestRatio";
            this._globalBestRatio.Size = new System.Drawing.Size(67, 20);
            this._globalBestRatio.TabIndex = 4;
            this._globalBestRatio.Text = "1.4";
            this._globalBestRatio.TextChanged += new System.EventHandler(this._globalBestRatio_TextChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 71);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(113, 13);
            label5.TabIndex = 2;
            label5.Text = "Размерность задачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 186);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(206, 13);
            label4.TabIndex = 2;
            label4.Text = "Коэфф. глобального лучшего значения";
            // 
            // _localBestRatio
            // 
            this._localBestRatio.Location = new System.Drawing.Point(262, 146);
            this._localBestRatio.Name = "_localBestRatio";
            this._localBestRatio.Size = new System.Drawing.Size(67, 20);
            this._localBestRatio.TabIndex = 3;
            this._localBestRatio.Text = "1.4";
            this._localBestRatio.TextChanged += new System.EventHandler(this._localBestRatio_TextChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(212, 13);
            label3.TabIndex = 2;
            label3.Text = "Коэфф. собственного лучшего значения";
            // 
            // _currentVelocityRatio
            // 
            this._currentVelocityRatio.Location = new System.Drawing.Point(262, 111);
            this._currentVelocityRatio.Name = "_currentVelocityRatio";
            this._currentVelocityRatio.Size = new System.Drawing.Size(67, 20);
            this._currentVelocityRatio.TabIndex = 2;
            this._currentVelocityRatio.Text = "0.9";
            this._currentVelocityRatio.TextChanged += new System.EventHandler(this._currentVelocityRatio_TextChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 111);
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
            groupBox1.Controls.Add(this.button1);
            groupBox1.Controls.Add(this._1000Iterations);
            groupBox1.Controls.Add(this._100Iterations);
            groupBox1.Controls.Add(this._10Iterations);
            groupBox1.Controls.Add(this._1Iteration);
            groupBox1.Controls.Add(this._createSwarm);
            groupBox1.Location = new System.Drawing.Point(12, 366);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(335, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this._createSwarm.Text = "Создать частицы";
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
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new System.Drawing.Point(353, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(335, 280);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Решение";
            // 
            // _finalFuncTextBox
            // 
            this._finalFuncTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._finalFuncTextBox.Location = new System.Drawing.Point(200, 254);
            this._finalFuncTextBox.Name = "_finalFuncTextBox";
            this._finalFuncTextBox.ReadOnly = true;
            this._finalFuncTextBox.Size = new System.Drawing.Size(129, 20);
            this._finalFuncTextBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 257);
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
            this._bestPosition.Location = new System.Drawing.Point(6, 32);
            this._bestPosition.Multiline = true;
            this._bestPosition.Name = "_bestPosition";
            this._bestPosition.ReadOnly = true;
            this._bestPosition.Size = new System.Drawing.Size(320, 216);
            this._bestPosition.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 16);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 13);
            label7.TabIndex = 0;
            label7.Text = "Лучшее решение:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox3.Controls.Add(this._swarmGraph);
            groupBox3.Location = new System.Drawing.Point(353, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(327, 327);
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
            this._swarmGraph.Size = new System.Drawing.Size(321, 308);
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
            this.ClientSize = new System.Drawing.Size(692, 658);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Controls.Add(algorithmBox);
            this.Name = "MainForm";
            this.Text = "Метод роя частиц";
            algorithmBox.ResumeLayout(false);
            algorithmBox.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox writeToFile;
	}
}

