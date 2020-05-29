namespace MathToolsMenu
{
    partial class TriangleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.anyTriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.equiTriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.anyPanel = new System.Windows.Forms.Panel();
            this.trianBeta = new System.Windows.Forms.TextBox();
            this.trianC = new System.Windows.Forms.TextBox();
            this.trianH = new System.Windows.Forms.TextBox();
            this.trianA = new System.Windows.Forms.TextBox();
            this.trianGamma = new System.Windows.Forms.TextBox();
            this.trianB = new System.Windows.Forms.TextBox();
            this.trianAlpha = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioTrianField3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioTrianField2 = new System.Windows.Forms.RadioButton();
            this.radioTrianCircuit = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.anyTrianResultTextBox = new System.Windows.Forms.TextBox();
            this.radioTrianField1 = new System.Windows.Forms.RadioButton();
            this.anyTrianResultButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equiPanel = new System.Windows.Forms.Panel();
            this.equiTrianH = new System.Windows.Forms.TextBox();
            this.equiTrianA = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioEquiTrianField2 = new System.Windows.Forms.RadioButton();
            this.radioEquiTrianCircuit = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.equiTrianResultTextBox = new System.Windows.Forms.TextBox();
            this.radioEquiTrianField1 = new System.Windows.Forms.RadioButton();
            this.equiTrianResultButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioEquiTrianHeight = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.anyPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.equiPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.anyTriangleRadioButton);
            this.panel1.Controls.Add(this.equiTriangleRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 62);
            this.panel1.TabIndex = 6;
            // 
            // anyTriangleRadioButton
            // 
            this.anyTriangleRadioButton.AutoSize = true;
            this.anyTriangleRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anyTriangleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anyTriangleRadioButton.Location = new System.Drawing.Point(227, 21);
            this.anyTriangleRadioButton.Name = "anyTriangleRadioButton";
            this.anyTriangleRadioButton.Size = new System.Drawing.Size(91, 24);
            this.anyTriangleRadioButton.TabIndex = 0;
            this.anyTriangleRadioButton.TabStop = true;
            this.anyTriangleRadioButton.Text = "dowolny";
            this.anyTriangleRadioButton.UseVisualStyleBackColor = true;
            this.anyTriangleRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // equiTriangleRadioButton
            // 
            this.equiTriangleRadioButton.AutoSize = true;
            this.equiTriangleRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equiTriangleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.equiTriangleRadioButton.Location = new System.Drawing.Point(343, 21);
            this.equiTriangleRadioButton.Name = "equiTriangleRadioButton";
            this.equiTriangleRadioButton.Size = new System.Drawing.Size(128, 24);
            this.equiTriangleRadioButton.TabIndex = 3;
            this.equiTriangleRadioButton.TabStop = true;
            this.equiTriangleRadioButton.Text = "równoboczny";
            this.equiTriangleRadioButton.UseVisualStyleBackColor = true;
            this.equiTriangleRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // anyPanel
            // 
            this.anyPanel.Controls.Add(this.trianBeta);
            this.anyPanel.Controls.Add(this.trianC);
            this.anyPanel.Controls.Add(this.trianH);
            this.anyPanel.Controls.Add(this.trianA);
            this.anyPanel.Controls.Add(this.trianGamma);
            this.anyPanel.Controls.Add(this.trianB);
            this.anyPanel.Controls.Add(this.trianAlpha);
            this.anyPanel.Controls.Add(this.panel7);
            this.anyPanel.Controls.Add(this.pictureBox1);
            this.anyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anyPanel.Location = new System.Drawing.Point(0, 0);
            this.anyPanel.Name = "anyPanel";
            this.anyPanel.Size = new System.Drawing.Size(676, 498);
            this.anyPanel.TabIndex = 7;
            // 
            // trianBeta
            // 
            this.trianBeta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianBeta.Location = new System.Drawing.Point(65, 322);
            this.trianBeta.Multiline = true;
            this.trianBeta.Name = "trianBeta";
            this.trianBeta.Size = new System.Drawing.Size(46, 33);
            this.trianBeta.TabIndex = 24;
            this.trianBeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianBeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // trianC
            // 
            this.trianC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianC.Location = new System.Drawing.Point(82, 212);
            this.trianC.Multiline = true;
            this.trianC.Name = "trianC";
            this.trianC.Size = new System.Drawing.Size(46, 33);
            this.trianC.TabIndex = 23;
            this.trianC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // trianH
            // 
            this.trianH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianH.Location = new System.Drawing.Point(192, 251);
            this.trianH.Multiline = true;
            this.trianH.Name = "trianH";
            this.trianH.Size = new System.Drawing.Size(46, 33);
            this.trianH.TabIndex = 22;
            this.trianH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // trianA
            // 
            this.trianA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianA.Location = new System.Drawing.Point(213, 321);
            this.trianA.Multiline = true;
            this.trianA.Name = "trianA";
            this.trianA.Size = new System.Drawing.Size(46, 33);
            this.trianA.TabIndex = 21;
            this.trianA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // trianGamma
            // 
            this.trianGamma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianGamma.Location = new System.Drawing.Point(333, 275);
            this.trianGamma.Multiline = true;
            this.trianGamma.Name = "trianGamma";
            this.trianGamma.Size = new System.Drawing.Size(46, 33);
            this.trianGamma.TabIndex = 20;
            this.trianGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianGamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // trianB
            // 
            this.trianB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianB.Location = new System.Drawing.Point(315, 215);
            this.trianB.Multiline = true;
            this.trianB.Name = "trianB";
            this.trianB.Size = new System.Drawing.Size(46, 33);
            this.trianB.TabIndex = 19;
            this.trianB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // trianAlpha
            // 
            this.trianAlpha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trianAlpha.Location = new System.Drawing.Point(262, 146);
            this.trianAlpha.Multiline = true;
            this.trianAlpha.Name = "trianAlpha";
            this.trianAlpha.Size = new System.Drawing.Size(46, 33);
            this.trianAlpha.TabIndex = 18;
            this.trianAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trianAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.radioTrianField3);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.radioTrianField2);
            this.panel7.Controls.Add(this.radioTrianCircuit);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.anyTrianResultTextBox);
            this.panel7.Controls.Add(this.radioTrianField1);
            this.panel7.Controls.Add(this.anyTrianResultButton);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Location = new System.Drawing.Point(385, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 371);
            this.panel7.TabIndex = 9;
            // 
            // radioTrianField3
            // 
            this.radioTrianField3.AutoSize = true;
            this.radioTrianField3.Location = new System.Drawing.Point(18, 130);
            this.radioTrianField3.Name = "radioTrianField3";
            this.radioTrianField3.Size = new System.Drawing.Size(14, 13);
            this.radioTrianField3.TabIndex = 16;
            this.radioTrianField3.TabStop = true;
            this.radioTrianField3.UseVisualStyleBackColor = true;
            this.radioTrianField3.CheckedChanged += new System.EventHandler(this.radioTrian_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(31, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "P=1/2*a*b*sinγ";
            // 
            // radioTrianField2
            // 
            this.radioTrianField2.AutoSize = true;
            this.radioTrianField2.Location = new System.Drawing.Point(18, 83);
            this.radioTrianField2.Name = "radioTrianField2";
            this.radioTrianField2.Size = new System.Drawing.Size(14, 13);
            this.radioTrianField2.TabIndex = 13;
            this.radioTrianField2.TabStop = true;
            this.radioTrianField2.UseVisualStyleBackColor = true;
            this.radioTrianField2.CheckedChanged += new System.EventHandler(this.radioTrian_CheckedChanged);
            // 
            // radioTrianCircuit
            // 
            this.radioTrianCircuit.AutoSize = true;
            this.radioTrianCircuit.Location = new System.Drawing.Point(19, 168);
            this.radioTrianCircuit.Name = "radioTrianCircuit";
            this.radioTrianCircuit.Size = new System.Drawing.Size(14, 13);
            this.radioTrianCircuit.TabIndex = 12;
            this.radioTrianCircuit.TabStop = true;
            this.radioTrianCircuit.UseVisualStyleBackColor = true;
            this.radioTrianCircuit.CheckedChanged += new System.EventHandler(this.radioTrian_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label13.Location = new System.Drawing.Point(31, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Obw=a+b+c";
            // 
            // anyTrianResultTextBox
            // 
            this.anyTrianResultTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anyTrianResultTextBox.Location = new System.Drawing.Point(18, 269);
            this.anyTrianResultTextBox.Multiline = true;
            this.anyTrianResultTextBox.Name = "anyTrianResultTextBox";
            this.anyTrianResultTextBox.ReadOnly = true;
            this.anyTrianResultTextBox.Size = new System.Drawing.Size(184, 45);
            this.anyTrianResultTextBox.TabIndex = 5;
            this.anyTrianResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioTrianField1
            // 
            this.radioTrianField1.Location = new System.Drawing.Point(19, 50);
            this.radioTrianField1.Name = "radioTrianField1";
            this.radioTrianField1.Size = new System.Drawing.Size(13, 13);
            this.radioTrianField1.TabIndex = 0;
            this.radioTrianField1.TabStop = true;
            this.radioTrianField1.UseVisualStyleBackColor = true;
            this.radioTrianField1.CheckedChanged += new System.EventHandler(this.radioTrian_CheckedChanged);
            // 
            // anyTrianResultButton
            // 
            this.anyTrianResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anyTrianResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.anyTrianResultButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.anyTrianResultButton.Location = new System.Drawing.Point(18, 228);
            this.anyTrianResultButton.Name = "anyTrianResultButton";
            this.anyTrianResultButton.Size = new System.Drawing.Size(184, 35);
            this.anyTrianResultButton.TabIndex = 4;
            this.anyTrianResultButton.Text = "Oblicz";
            this.anyTrianResultButton.UseVisualStyleBackColor = true;
            this.anyTrianResultButton.Click += new System.EventHandler(this.anyTrianResultButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label15.Location = new System.Drawing.Point(33, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 24);
            this.label15.TabIndex = 6;
            this.label15.Text = "P=a*h/2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // equiPanel
            // 
            this.equiPanel.Controls.Add(this.equiTrianH);
            this.equiPanel.Controls.Add(this.equiTrianA);
            this.equiPanel.Controls.Add(this.panel3);
            this.equiPanel.Controls.Add(this.pictureBox4);
            this.equiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equiPanel.Location = new System.Drawing.Point(0, 0);
            this.equiPanel.Name = "equiPanel";
            this.equiPanel.Size = new System.Drawing.Size(676, 498);
            this.equiPanel.TabIndex = 8;
            // 
            // equiTrianH
            // 
            this.equiTrianH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equiTrianH.Location = new System.Drawing.Point(206, 247);
            this.equiTrianH.Multiline = true;
            this.equiTrianH.Name = "equiTrianH";
            this.equiTrianH.Size = new System.Drawing.Size(46, 33);
            this.equiTrianH.TabIndex = 22;
            this.equiTrianH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equiTrianH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // equiTrianA
            // 
            this.equiTrianA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equiTrianA.Location = new System.Drawing.Point(217, 351);
            this.equiTrianA.Multiline = true;
            this.equiTrianA.Name = "equiTrianA";
            this.equiTrianA.Size = new System.Drawing.Size(46, 33);
            this.equiTrianA.TabIndex = 21;
            this.equiTrianA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equiTrianA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.radioEquiTrianHeight);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.radioEquiTrianField2);
            this.panel3.Controls.Add(this.radioEquiTrianCircuit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.equiTrianResultTextBox);
            this.panel3.Controls.Add(this.radioEquiTrianField1);
            this.panel3.Controls.Add(this.equiTrianResultButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(385, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 371);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "P=1/4*a²*√3";
            // 
            // radioEquiTrianField2
            // 
            this.radioEquiTrianField2.AutoSize = true;
            this.radioEquiTrianField2.Location = new System.Drawing.Point(18, 83);
            this.radioEquiTrianField2.Name = "radioEquiTrianField2";
            this.radioEquiTrianField2.Size = new System.Drawing.Size(14, 13);
            this.radioEquiTrianField2.TabIndex = 13;
            this.radioEquiTrianField2.TabStop = true;
            this.radioEquiTrianField2.UseVisualStyleBackColor = true;
            this.radioEquiTrianField2.CheckedChanged += new System.EventHandler(this.radioEquiTrian_CheckedChanged);
            // 
            // radioEquiTrianCircuit
            // 
            this.radioEquiTrianCircuit.AutoSize = true;
            this.radioEquiTrianCircuit.Location = new System.Drawing.Point(21, 150);
            this.radioEquiTrianCircuit.Name = "radioEquiTrianCircuit";
            this.radioEquiTrianCircuit.Size = new System.Drawing.Size(14, 13);
            this.radioEquiTrianCircuit.TabIndex = 12;
            this.radioEquiTrianCircuit.TabStop = true;
            this.radioEquiTrianCircuit.UseVisualStyleBackColor = true;
            this.radioEquiTrianCircuit.CheckedChanged += new System.EventHandler(this.radioEquiTrian_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(33, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Obw=3*a";
            // 
            // equiTrianResultTextBox
            // 
            this.equiTrianResultTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equiTrianResultTextBox.Location = new System.Drawing.Point(18, 247);
            this.equiTrianResultTextBox.Multiline = true;
            this.equiTrianResultTextBox.Name = "equiTrianResultTextBox";
            this.equiTrianResultTextBox.ReadOnly = true;
            this.equiTrianResultTextBox.Size = new System.Drawing.Size(184, 45);
            this.equiTrianResultTextBox.TabIndex = 5;
            this.equiTrianResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioEquiTrianField1
            // 
            this.radioEquiTrianField1.Location = new System.Drawing.Point(19, 50);
            this.radioEquiTrianField1.Name = "radioEquiTrianField1";
            this.radioEquiTrianField1.Size = new System.Drawing.Size(13, 13);
            this.radioEquiTrianField1.TabIndex = 0;
            this.radioEquiTrianField1.TabStop = true;
            this.radioEquiTrianField1.UseVisualStyleBackColor = true;
            this.radioEquiTrianField1.CheckedChanged += new System.EventHandler(this.radioEquiTrian_CheckedChanged);
            // 
            // equiTrianResultButton
            // 
            this.equiTrianResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equiTrianResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.equiTrianResultButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.equiTrianResultButton.Location = new System.Drawing.Point(18, 206);
            this.equiTrianResultButton.Name = "equiTrianResultButton";
            this.equiTrianResultButton.Size = new System.Drawing.Size(184, 35);
            this.equiTrianResultButton.TabIndex = 4;
            this.equiTrianResultButton.Text = "Oblicz";
            this.equiTrianResultButton.UseVisualStyleBackColor = true;
            this.equiTrianResultButton.Click += new System.EventHandler(this.equiTrianResultButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(33, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "P=a*h/2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(350, 350);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label5.Location = new System.Drawing.Point(31, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "h=1/2*a*√3";
            // 
            // radioEquiTrianHeight
            // 
            this.radioEquiTrianHeight.AutoSize = true;
            this.radioEquiTrianHeight.Location = new System.Drawing.Point(18, 116);
            this.radioEquiTrianHeight.Name = "radioEquiTrianHeight";
            this.radioEquiTrianHeight.Size = new System.Drawing.Size(14, 13);
            this.radioEquiTrianHeight.TabIndex = 15;
            this.radioEquiTrianHeight.TabStop = true;
            this.radioEquiTrianHeight.UseVisualStyleBackColor = true;
            this.radioEquiTrianHeight.CheckedChanged += new System.EventHandler(this.radioEquiTrian_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.equiPanel);
            this.panel2.Controls.Add(this.anyPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 498);
            this.panel2.TabIndex = 7;
            // 
            // TriangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TriangleControl";
            this.Size = new System.Drawing.Size(676, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.anyPanel.ResumeLayout(false);
            this.anyPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.equiPanel.ResumeLayout(false);
            this.equiPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton anyTriangleRadioButton;
        private System.Windows.Forms.RadioButton equiTriangleRadioButton;
        private System.Windows.Forms.Panel anyPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioTrianField2;
        private System.Windows.Forms.RadioButton radioTrianCircuit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox anyTrianResultTextBox;
        private System.Windows.Forms.RadioButton radioTrianField1;
        private System.Windows.Forms.Button anyTrianResultButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioTrianField3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox trianBeta;
        private System.Windows.Forms.TextBox trianC;
        private System.Windows.Forms.TextBox trianH;
        private System.Windows.Forms.TextBox trianA;
        private System.Windows.Forms.TextBox trianGamma;
        private System.Windows.Forms.TextBox trianB;
        private System.Windows.Forms.TextBox trianAlpha;
        private System.Windows.Forms.Panel equiPanel;
        private System.Windows.Forms.TextBox equiTrianH;
        private System.Windows.Forms.TextBox equiTrianA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioEquiTrianHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioEquiTrianField2;
        private System.Windows.Forms.RadioButton radioEquiTrianCircuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox equiTrianResultTextBox;
        private System.Windows.Forms.RadioButton radioEquiTrianField1;
        private System.Windows.Forms.Button equiTrianResultButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
    }
}
