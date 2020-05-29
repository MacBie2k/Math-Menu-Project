namespace MathToolsMenu
{
    partial class MathFuntionControl1
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.aSqrLabel = new System.Windows.Forms.Label();
            this.bSqrLabel = new System.Windows.Forms.Label();
            this.cSqrLabel = new System.Windows.Forms.Label();
            this.groub = new System.Windows.Forms.GroupBox();
            this.expoFunctionPanel = new System.Windows.Forms.Panel();
            this.expoValueForButton = new System.Windows.Forms.Button();
            this.expoValueForTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.expoResultTextBox = new System.Windows.Forms.TextBox();
            this.expoTypeTextBox = new System.Windows.Forms.TextBox();
            this.expoResultButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.expoATextBox = new System.Windows.Forms.TextBox();
            this.logFunctionPanel = new System.Windows.Forms.Panel();
            this.logValueForButton = new System.Windows.Forms.Button();
            this.logValueForTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.logResultTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.logTypeTextBox = new System.Windows.Forms.TextBox();
            this.logResultButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.logATextBox = new System.Windows.Forms.TextBox();
            this.linealFunctionPanel = new System.Windows.Forms.Panel();
            this.linealCheckButton = new System.Windows.Forms.Button();
            this.linealValueForTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.xLinealTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typeLinealTextBox = new System.Windows.Forms.TextBox();
            this.linealResultButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.linealBTextBox = new System.Windows.Forms.TextBox();
            this.linealATextBox = new System.Windows.Forms.TextBox();
            this.squareFunctionPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.sqrDeltaTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.deltaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.canonicaTextBox = new System.Windows.Forms.TextBox();
            this.specialFormTextBox = new System.Windows.Forms.TextBox();
            this.basicFormTextBox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groub.SuspendLayout();
            this.expoFunctionPanel.SuspendLayout();
            this.logFunctionPanel.SuspendLayout();
            this.linealFunctionPanel.SuspendLayout();
            this.squareFunctionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(9, 100);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.MarkerStep = 2;
            series1.Name = "axies";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series2.IsVisibleInLegend = false;
            series2.LabelBorderWidth = 0;
            series2.Legend = "Legend1";
            series2.MarkerSize = 1;
            series2.Name = "Series2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(400, 400);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // aBox
            // 
            this.aBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aBox.Location = new System.Drawing.Point(65, 25);
            this.aBox.Multiline = true;
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(28, 28);
            this.aBox.TabIndex = 2;
            this.aBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abcSquareBox_KeyPress);
            // 
            // cBox
            // 
            this.cBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBox.Location = new System.Drawing.Point(187, 25);
            this.cBox.Multiline = true;
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(28, 28);
            this.cBox.TabIndex = 4;
            this.cBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abcSquareBox_KeyPress);
            // 
            // aSqrLabel
            // 
            this.aSqrLabel.AutoSize = true;
            this.aSqrLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSqrLabel.Location = new System.Drawing.Point(72, 8);
            this.aSqrLabel.Margin = new System.Windows.Forms.Padding(0);
            this.aSqrLabel.Name = "aSqrLabel";
            this.aSqrLabel.Size = new System.Drawing.Size(17, 17);
            this.aSqrLabel.TabIndex = 5;
            this.aSqrLabel.Text = "a";
            // 
            // bSqrLabel
            // 
            this.bSqrLabel.AutoSize = true;
            this.bSqrLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSqrLabel.Location = new System.Drawing.Point(136, 8);
            this.bSqrLabel.Name = "bSqrLabel";
            this.bSqrLabel.Size = new System.Drawing.Size(17, 17);
            this.bSqrLabel.TabIndex = 6;
            this.bSqrLabel.Text = "b";
            // 
            // cSqrLabel
            // 
            this.cSqrLabel.AutoSize = true;
            this.cSqrLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSqrLabel.Location = new System.Drawing.Point(195, 8);
            this.cSqrLabel.Name = "cSqrLabel";
            this.cSqrLabel.Size = new System.Drawing.Size(16, 17);
            this.cSqrLabel.TabIndex = 7;
            this.cSqrLabel.Text = "c";
            // 
            // groub
            // 
            this.groub.BackColor = System.Drawing.Color.Transparent;
            this.groub.Controls.Add(this.linealFunctionPanel);
            this.groub.Controls.Add(this.squareFunctionPanel);
            this.groub.Controls.Add(this.panel1);
            this.groub.Controls.Add(this.expoFunctionPanel);
            this.groub.Controls.Add(this.logFunctionPanel);
            this.groub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groub.Location = new System.Drawing.Point(399, 64);
            this.groub.Name = "groub";
            this.groub.Size = new System.Drawing.Size(245, 414);
            this.groub.TabIndex = 10;
            this.groub.TabStop = false;
            // 
            // expoFunctionPanel
            // 
            this.expoFunctionPanel.Controls.Add(this.expoValueForButton);
            this.expoFunctionPanel.Controls.Add(this.expoValueForTextBox);
            this.expoFunctionPanel.Controls.Add(this.label13);
            this.expoFunctionPanel.Controls.Add(this.expoResultTextBox);
            this.expoFunctionPanel.Controls.Add(this.expoTypeTextBox);
            this.expoFunctionPanel.Controls.Add(this.expoResultButton);
            this.expoFunctionPanel.Controls.Add(this.label15);
            this.expoFunctionPanel.Controls.Add(this.label18);
            this.expoFunctionPanel.Controls.Add(this.expoATextBox);
            this.expoFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expoFunctionPanel.Location = new System.Drawing.Point(3, 16);
            this.expoFunctionPanel.Name = "expoFunctionPanel";
            this.expoFunctionPanel.Size = new System.Drawing.Size(239, 395);
            this.expoFunctionPanel.TabIndex = 34;
            // 
            // expoValueForButton
            // 
            this.expoValueForButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expoValueForButton.Location = new System.Drawing.Point(72, 208);
            this.expoValueForButton.Name = "expoValueForButton";
            this.expoValueForButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expoValueForButton.Size = new System.Drawing.Size(94, 31);
            this.expoValueForButton.TabIndex = 33;
            this.expoValueForButton.Text = "sprawdź";
            this.expoValueForButton.UseVisualStyleBackColor = true;
            this.expoValueForButton.Click += new System.EventHandler(this.expoValueForButton_Click);
            // 
            // expoValueForTextBox
            // 
            this.expoValueForTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expoValueForTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expoValueForTextBox.Location = new System.Drawing.Point(99, 174);
            this.expoValueForTextBox.Multiline = true;
            this.expoValueForTextBox.Name = "expoValueForTextBox";
            this.expoValueForTextBox.Size = new System.Drawing.Size(40, 28);
            this.expoValueForTextBox.TabIndex = 32;
            this.expoValueForTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label13.Location = new System.Drawing.Point(83, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "y dla x=";
            // 
            // expoResultTextBox
            // 
            this.expoResultTextBox.Enabled = false;
            this.expoResultTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expoResultTextBox.Location = new System.Drawing.Point(22, 245);
            this.expoResultTextBox.Name = "expoResultTextBox";
            this.expoResultTextBox.ReadOnly = true;
            this.expoResultTextBox.Size = new System.Drawing.Size(192, 27);
            this.expoResultTextBox.TabIndex = 28;
            // 
            // expoTypeTextBox
            // 
            this.expoTypeTextBox.Enabled = false;
            this.expoTypeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expoTypeTextBox.Location = new System.Drawing.Point(22, 115);
            this.expoTypeTextBox.Name = "expoTypeTextBox";
            this.expoTypeTextBox.ReadOnly = true;
            this.expoTypeTextBox.Size = new System.Drawing.Size(192, 27);
            this.expoTypeTextBox.TabIndex = 27;
            // 
            // expoResultButton
            // 
            this.expoResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expoResultButton.Location = new System.Drawing.Point(22, 70);
            this.expoResultButton.Name = "expoResultButton";
            this.expoResultButton.Size = new System.Drawing.Size(192, 32);
            this.expoResultButton.TabIndex = 26;
            this.expoResultButton.Text = "wykonaj";
            this.expoResultButton.UseVisualStyleBackColor = true;
            this.expoResultButton.Click += new System.EventHandler(this.expoResultButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(69, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 22);
            this.label15.TabIndex = 12;
            this.label15.Text = "f(x)=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label18.Location = new System.Drawing.Point(155, 12);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 22);
            this.label18.TabIndex = 13;
            this.label18.Text = "x";
            // 
            // expoATextBox
            // 
            this.expoATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expoATextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expoATextBox.Location = new System.Drawing.Point(123, 30);
            this.expoATextBox.Multiline = true;
            this.expoATextBox.Name = "expoATextBox";
            this.expoATextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expoATextBox.Size = new System.Drawing.Size(28, 28);
            this.expoATextBox.TabIndex = 2;
            this.expoATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expoATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expoATextBox_KeyPress);
            // 
            // logFunctionPanel
            // 
            this.logFunctionPanel.Controls.Add(this.logValueForButton);
            this.logFunctionPanel.Controls.Add(this.logValueForTextBox);
            this.logFunctionPanel.Controls.Add(this.label14);
            this.logFunctionPanel.Controls.Add(this.logResultTextBox);
            this.logFunctionPanel.Controls.Add(this.label20);
            this.logFunctionPanel.Controls.Add(this.logTypeTextBox);
            this.logFunctionPanel.Controls.Add(this.logResultButton);
            this.logFunctionPanel.Controls.Add(this.label17);
            this.logFunctionPanel.Controls.Add(this.logATextBox);
            this.logFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logFunctionPanel.Location = new System.Drawing.Point(3, 16);
            this.logFunctionPanel.Name = "logFunctionPanel";
            this.logFunctionPanel.Size = new System.Drawing.Size(239, 395);
            this.logFunctionPanel.TabIndex = 35;
            // 
            // logValueForButton
            // 
            this.logValueForButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logValueForButton.Location = new System.Drawing.Point(72, 208);
            this.logValueForButton.Name = "logValueForButton";
            this.logValueForButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logValueForButton.Size = new System.Drawing.Size(94, 31);
            this.logValueForButton.TabIndex = 33;
            this.logValueForButton.Text = "sprawdź";
            this.logValueForButton.UseVisualStyleBackColor = true;
            this.logValueForButton.Click += new System.EventHandler(this.logValueForButton_Click);
            // 
            // logValueForTextBox
            // 
            this.logValueForTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logValueForTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logValueForTextBox.Location = new System.Drawing.Point(99, 174);
            this.logValueForTextBox.Multiline = true;
            this.logValueForTextBox.Name = "logValueForTextBox";
            this.logValueForTextBox.Size = new System.Drawing.Size(40, 28);
            this.logValueForTextBox.TabIndex = 32;
            this.logValueForTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label14.Location = new System.Drawing.Point(83, 150);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "y dla x=";
            // 
            // logResultTextBox
            // 
            this.logResultTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logResultTextBox.Location = new System.Drawing.Point(22, 245);
            this.logResultTextBox.Name = "logResultTextBox";
            this.logResultTextBox.ReadOnly = true;
            this.logResultTextBox.Size = new System.Drawing.Size(192, 27);
            this.logResultTextBox.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label20.Location = new System.Drawing.Point(165, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 22);
            this.label20.TabIndex = 13;
            this.label20.Text = "x";
            // 
            // logTypeTextBox
            // 
            this.logTypeTextBox.Enabled = false;
            this.logTypeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logTypeTextBox.Location = new System.Drawing.Point(22, 115);
            this.logTypeTextBox.Name = "logTypeTextBox";
            this.logTypeTextBox.ReadOnly = true;
            this.logTypeTextBox.Size = new System.Drawing.Size(192, 27);
            this.logTypeTextBox.TabIndex = 27;
            // 
            // logResultButton
            // 
            this.logResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logResultButton.Location = new System.Drawing.Point(22, 70);
            this.logResultButton.Name = "logResultButton";
            this.logResultButton.Size = new System.Drawing.Size(192, 32);
            this.logResultButton.TabIndex = 26;
            this.logResultButton.Text = "wykonaj";
            this.logResultButton.UseVisualStyleBackColor = true;
            this.logResultButton.Click += new System.EventHandler(this.logResultButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(50, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 12;
            this.label17.Text = "f(x)=log";
            // 
            // logATextBox
            // 
            this.logATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logATextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logATextBox.Location = new System.Drawing.Point(131, 33);
            this.logATextBox.Multiline = true;
            this.logATextBox.Name = "logATextBox";
            this.logATextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logATextBox.Size = new System.Drawing.Size(28, 28);
            this.logATextBox.TabIndex = 2;
            this.logATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logATextBox_KeyPress);
            // 
            // linealFunctionPanel
            // 
            this.linealFunctionPanel.Controls.Add(this.linealCheckButton);
            this.linealFunctionPanel.Controls.Add(this.linealValueForTextBox);
            this.linealFunctionPanel.Controls.Add(this.label16);
            this.linealFunctionPanel.Controls.Add(this.label21);
            this.linealFunctionPanel.Controls.Add(this.xLinealTextBox);
            this.linealFunctionPanel.Controls.Add(this.textBox1);
            this.linealFunctionPanel.Controls.Add(this.typeLinealTextBox);
            this.linealFunctionPanel.Controls.Add(this.linealResultButton);
            this.linealFunctionPanel.Controls.Add(this.label22);
            this.linealFunctionPanel.Controls.Add(this.label24);
            this.linealFunctionPanel.Controls.Add(this.label25);
            this.linealFunctionPanel.Controls.Add(this.label26);
            this.linealFunctionPanel.Controls.Add(this.linealBTextBox);
            this.linealFunctionPanel.Controls.Add(this.linealATextBox);
            this.linealFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linealFunctionPanel.Location = new System.Drawing.Point(3, 16);
            this.linealFunctionPanel.Name = "linealFunctionPanel";
            this.linealFunctionPanel.Size = new System.Drawing.Size(239, 395);
            this.linealFunctionPanel.TabIndex = 15;
            // 
            // linealCheckButton
            // 
            this.linealCheckButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linealCheckButton.Location = new System.Drawing.Point(73, 281);
            this.linealCheckButton.Name = "linealCheckButton";
            this.linealCheckButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linealCheckButton.Size = new System.Drawing.Size(94, 31);
            this.linealCheckButton.TabIndex = 33;
            this.linealCheckButton.Text = "sprawdź";
            this.linealCheckButton.UseVisualStyleBackColor = true;
            this.linealCheckButton.Click += new System.EventHandler(this.linealCheckButton_Click);
            // 
            // linealValueForTextBox
            // 
            this.linealValueForTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linealValueForTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linealValueForTextBox.Location = new System.Drawing.Point(101, 247);
            this.linealValueForTextBox.Multiline = true;
            this.linealValueForTextBox.Name = "linealValueForTextBox";
            this.linealValueForTextBox.Size = new System.Drawing.Size(40, 28);
            this.linealValueForTextBox.TabIndex = 32;
            this.linealValueForTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label16.Location = new System.Drawing.Point(81, 217);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 21);
            this.label16.TabIndex = 31;
            this.label16.Text = "y dla x=";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(68, 116);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "miejsce zerowe:";
            // 
            // xLinealTextBox
            // 
            this.xLinealTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xLinealTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xLinealTextBox.Location = new System.Drawing.Point(101, 136);
            this.xLinealTextBox.Multiline = true;
            this.xLinealTextBox.Name = "xLinealTextBox";
            this.xLinealTextBox.ReadOnly = true;
            this.xLinealTextBox.Size = new System.Drawing.Size(40, 28);
            this.xLinealTextBox.TabIndex = 29;
            this.xLinealTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(24, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(192, 27);
            this.textBox1.TabIndex = 28;
            // 
            // typeLinealTextBox
            // 
            this.typeLinealTextBox.Enabled = false;
            this.typeLinealTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeLinealTextBox.Location = new System.Drawing.Point(24, 178);
            this.typeLinealTextBox.Name = "typeLinealTextBox";
            this.typeLinealTextBox.ReadOnly = true;
            this.typeLinealTextBox.Size = new System.Drawing.Size(192, 27);
            this.typeLinealTextBox.TabIndex = 27;
            // 
            // linealResultButton
            // 
            this.linealResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linealResultButton.Location = new System.Drawing.Point(22, 70);
            this.linealResultButton.Name = "linealResultButton";
            this.linealResultButton.Size = new System.Drawing.Size(192, 32);
            this.linealResultButton.TabIndex = 26;
            this.linealResultButton.Text = "wykonaj";
            this.linealResultButton.UseVisualStyleBackColor = true;
            this.linealResultButton.Click += new System.EventHandler(this.linealResultButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(40, 26);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 22);
            this.label22.TabIndex = 12;
            this.label22.Text = "f(x)=";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(156, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 17);
            this.label24.TabIndex = 6;
            this.label24.Text = "b";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label25.Location = new System.Drawing.Point(119, 26);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 22);
            this.label25.TabIndex = 13;
            this.label25.Text = "x+";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(98, 7);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 17);
            this.label26.TabIndex = 5;
            this.label26.Text = "a";
            // 
            // linealBTextBox
            // 
            this.linealBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linealBTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linealBTextBox.Location = new System.Drawing.Point(149, 24);
            this.linealBTextBox.Multiline = true;
            this.linealBTextBox.Name = "linealBTextBox";
            this.linealBTextBox.Size = new System.Drawing.Size(28, 28);
            this.linealBTextBox.TabIndex = 3;
            this.linealBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.linealBTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linealABTextBox_KeyPress);
            // 
            // linealATextBox
            // 
            this.linealATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linealATextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linealATextBox.Location = new System.Drawing.Point(91, 24);
            this.linealATextBox.Multiline = true;
            this.linealATextBox.Name = "linealATextBox";
            this.linealATextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linealATextBox.Size = new System.Drawing.Size(28, 28);
            this.linealATextBox.TabIndex = 2;
            this.linealATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.linealATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linealABTextBox_KeyPress);
            // 
            // squareFunctionPanel
            // 
            this.squareFunctionPanel.Controls.Add(this.label11);
            this.squareFunctionPanel.Controls.Add(this.sqrDeltaTextBox);
            this.squareFunctionPanel.Controls.Add(this.label12);
            this.squareFunctionPanel.Controls.Add(this.deltaTextBox);
            this.squareFunctionPanel.Controls.Add(this.label10);
            this.squareFunctionPanel.Controls.Add(this.label9);
            this.squareFunctionPanel.Controls.Add(this.label8);
            this.squareFunctionPanel.Controls.Add(this.label7);
            this.squareFunctionPanel.Controls.Add(this.qTextBox);
            this.squareFunctionPanel.Controls.Add(this.label6);
            this.squareFunctionPanel.Controls.Add(this.pTextBox);
            this.squareFunctionPanel.Controls.Add(this.label5);
            this.squareFunctionPanel.Controls.Add(this.x2TextBox);
            this.squareFunctionPanel.Controls.Add(this.label4);
            this.squareFunctionPanel.Controls.Add(this.x1TextBox);
            this.squareFunctionPanel.Controls.Add(this.canonicaTextBox);
            this.squareFunctionPanel.Controls.Add(this.specialFormTextBox);
            this.squareFunctionPanel.Controls.Add(this.basicFormTextBox);
            this.squareFunctionPanel.Controls.Add(this.resultButton);
            this.squareFunctionPanel.Controls.Add(this.label1);
            this.squareFunctionPanel.Controls.Add(this.label3);
            this.squareFunctionPanel.Controls.Add(this.bSqrLabel);
            this.squareFunctionPanel.Controls.Add(this.label2);
            this.squareFunctionPanel.Controls.Add(this.aSqrLabel);
            this.squareFunctionPanel.Controls.Add(this.cSqrLabel);
            this.squareFunctionPanel.Controls.Add(this.cBox);
            this.squareFunctionPanel.Controls.Add(this.bBox);
            this.squareFunctionPanel.Controls.Add(this.aBox);
            this.squareFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareFunctionPanel.Location = new System.Drawing.Point(3, 16);
            this.squareFunctionPanel.Name = "squareFunctionPanel";
            this.squareFunctionPanel.Size = new System.Drawing.Size(239, 395);
            this.squareFunctionPanel.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "√Δ";
            // 
            // sqrDeltaTextBox
            // 
            this.sqrDeltaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sqrDeltaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrDeltaTextBox.Location = new System.Drawing.Point(122, 122);
            this.sqrDeltaTextBox.Multiline = true;
            this.sqrDeltaTextBox.Name = "sqrDeltaTextBox";
            this.sqrDeltaTextBox.ReadOnly = true;
            this.sqrDeltaTextBox.Size = new System.Drawing.Size(40, 28);
            this.sqrDeltaTextBox.TabIndex = 46;
            this.sqrDeltaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Δ";
            // 
            // deltaTextBox
            // 
            this.deltaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deltaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deltaTextBox.Location = new System.Drawing.Point(76, 122);
            this.deltaTextBox.Multiline = true;
            this.deltaTextBox.Name = "deltaTextBox";
            this.deltaTextBox.ReadOnly = true;
            this.deltaTextBox.Size = new System.Drawing.Size(40, 28);
            this.deltaTextBox.TabIndex = 44;
            this.deltaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Postać ogólna";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Postać kanoniczna";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Postać iloczynowa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "q";
            // 
            // qTextBox
            // 
            this.qTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.qTextBox.Location = new System.Drawing.Point(176, 170);
            this.qTextBox.Multiline = true;
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.ReadOnly = true;
            this.qTextBox.Size = new System.Drawing.Size(40, 28);
            this.qTextBox.TabIndex = 40;
            this.qTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "p";
            // 
            // pTextBox
            // 
            this.pTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pTextBox.Location = new System.Drawing.Point(130, 170);
            this.pTextBox.Multiline = true;
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.ReadOnly = true;
            this.pTextBox.Size = new System.Drawing.Size(40, 28);
            this.pTextBox.TabIndex = 38;
            this.pTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "x2";
            // 
            // x2TextBox
            // 
            this.x2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x2TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x2TextBox.Location = new System.Drawing.Point(70, 170);
            this.x2TextBox.Multiline = true;
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.ReadOnly = true;
            this.x2TextBox.Size = new System.Drawing.Size(40, 28);
            this.x2TextBox.TabIndex = 36;
            this.x2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "x1";
            // 
            // x1TextBox
            // 
            this.x1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x1TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x1TextBox.Location = new System.Drawing.Point(24, 170);
            this.x1TextBox.Multiline = true;
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.ReadOnly = true;
            this.x1TextBox.Size = new System.Drawing.Size(40, 28);
            this.x1TextBox.TabIndex = 33;
            this.x1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // canonicaTextBox
            // 
            this.canonicaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.canonicaTextBox.Location = new System.Drawing.Point(24, 336);
            this.canonicaTextBox.Name = "canonicaTextBox";
            this.canonicaTextBox.ReadOnly = true;
            this.canonicaTextBox.Size = new System.Drawing.Size(192, 27);
            this.canonicaTextBox.TabIndex = 32;
            // 
            // specialFormTextBox
            // 
            this.specialFormTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specialFormTextBox.Location = new System.Drawing.Point(24, 282);
            this.specialFormTextBox.Name = "specialFormTextBox";
            this.specialFormTextBox.ReadOnly = true;
            this.specialFormTextBox.Size = new System.Drawing.Size(192, 27);
            this.specialFormTextBox.TabIndex = 31;
            // 
            // basicFormTextBox
            // 
            this.basicFormTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.basicFormTextBox.Location = new System.Drawing.Point(24, 229);
            this.basicFormTextBox.Name = "basicFormTextBox";
            this.basicFormTextBox.ReadOnly = true;
            this.basicFormTextBox.Size = new System.Drawing.Size(192, 27);
            this.basicFormTextBox.TabIndex = 30;
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultButton.Location = new System.Drawing.Point(24, 70);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(192, 32);
            this.resultButton.TabIndex = 29;
            this.resultButton.Text = "wykonaj";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "f(x)=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(157, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "x+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(93, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "x²+";
            // 
            // bBox
            // 
            this.bBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bBox.Location = new System.Drawing.Point(129, 25);
            this.bBox.Multiline = true;
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(28, 28);
            this.bBox.TabIndex = 3;
            this.bBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abcSquareBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 395);
            this.panel1.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funkcja liniowa",
            "Funkcja kwadratowa",
            "Funkcja wykładnicza",
            "Funkcja logarytmiczna"});
            this.comboBox1.Location = new System.Drawing.Point(33, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 32);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MathFuntionControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groub);
            this.Controls.Add(this.chart);
            this.Name = "MathFuntionControl1";
            this.Size = new System.Drawing.Size(676, 560);
            this.Load += new System.EventHandler(this.MathFuntionControl1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groub.ResumeLayout(false);
            this.groub.PerformLayout();
            this.expoFunctionPanel.ResumeLayout(false);
            this.expoFunctionPanel.PerformLayout();
            this.logFunctionPanel.ResumeLayout(false);
            this.logFunctionPanel.PerformLayout();
            this.linealFunctionPanel.ResumeLayout(false);
            this.linealFunctionPanel.PerformLayout();
            this.squareFunctionPanel.ResumeLayout(false);
            this.squareFunctionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label aSqrLabel;
        private System.Windows.Forms.Label bSqrLabel;
        private System.Windows.Forms.Label cSqrLabel;
        private System.Windows.Forms.GroupBox groub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Panel squareFunctionPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel linealFunctionPanel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox linealBTextBox;
        private System.Windows.Forms.TextBox linealATextBox;
        private System.Windows.Forms.Button linealCheckButton;
        private System.Windows.Forms.TextBox linealValueForTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox xLinealTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox typeLinealTextBox;
        private System.Windows.Forms.Button linealResultButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sqrDeltaTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deltaTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.TextBox canonicaTextBox;
        private System.Windows.Forms.TextBox specialFormTextBox;
        private System.Windows.Forms.TextBox basicFormTextBox;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel expoFunctionPanel;
        private System.Windows.Forms.Button expoValueForButton;
        private System.Windows.Forms.TextBox expoValueForTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox expoResultTextBox;
        private System.Windows.Forms.Button expoResultButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox expoATextBox;
        private System.Windows.Forms.TextBox expoTypeTextBox;
        private System.Windows.Forms.Panel logFunctionPanel;
        private System.Windows.Forms.Button logValueForButton;
        private System.Windows.Forms.TextBox logValueForTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox logResultTextBox;
        private System.Windows.Forms.TextBox logTypeTextBox;
        private System.Windows.Forms.Button logResultButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox logATextBox;
        private System.Windows.Forms.Label label20;
    }
}
