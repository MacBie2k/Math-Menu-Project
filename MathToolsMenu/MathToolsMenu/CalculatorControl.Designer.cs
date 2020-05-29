namespace MathToolsMenu
{
    partial class CalculatorControl
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
            this.percentButton = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.clearElementButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.signChangeButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.mainTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.percentButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.percentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.percentButton.Location = new System.Drawing.Point(97, 146);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(88, 53);
            this.percentButton.TabIndex = 1;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.percentButton_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainTextBox.Location = new System.Drawing.Point(97, 71);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(370, 34);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBoxes_KeyDown);
            // 
            // clearElementButton
            // 
            this.clearElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.clearElementButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearElementButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearElementButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearElementButton.Location = new System.Drawing.Point(191, 146);
            this.clearElementButton.Name = "clearElementButton";
            this.clearElementButton.Size = new System.Drawing.Size(88, 53);
            this.clearElementButton.TabIndex = 3;
            this.clearElementButton.Text = "CE";
            this.clearElementButton.UseVisualStyleBackColor = false;
            this.clearElementButton.Click += new System.EventHandler(this.clearElementButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearButton.Location = new System.Drawing.Point(285, 146);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 53);
            this.clearButton.TabIndex = 4;
            this.clearButton.Tag = "";
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.Location = new System.Drawing.Point(379, 146);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 53);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "⌫";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // devideButton
            // 
            this.devideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.devideButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.devideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devideButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.devideButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.devideButton.Location = new System.Drawing.Point(379, 205);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(88, 53);
            this.devideButton.TabIndex = 9;
            this.devideButton.Text = "÷";
            this.devideButton.UseVisualStyleBackColor = false;
            this.devideButton.Click += new System.EventHandler(this.devideButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.sqrtButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrtButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sqrtButton.Location = new System.Drawing.Point(285, 205);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(88, 53);
            this.sqrtButton.TabIndex = 8;
            this.sqrtButton.Text = "√x";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.powerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.powerButton.Location = new System.Drawing.Point(191, 205);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(88, 53);
            this.powerButton.TabIndex = 7;
            this.powerButton.Text = "x²";
            this.powerButton.UseVisualStyleBackColor = false;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.reverseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reverseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reverseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reverseButton.Location = new System.Drawing.Point(97, 205);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(88, 53);
            this.reverseButton.TabIndex = 6;
            this.reverseButton.Text = "1/x";
            this.reverseButton.UseVisualStyleBackColor = false;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.multiplyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.multiplyButton.Location = new System.Drawing.Point(379, 264);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(88, 53);
            this.multiplyButton.TabIndex = 13;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.nineButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nineButton.Location = new System.Drawing.Point(285, 264);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(88, 53);
            this.nineButton.TabIndex = 12;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.eightButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.eightButton.Location = new System.Drawing.Point(191, 264);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(88, 53);
            this.eightButton.TabIndex = 11;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.sevenButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sevenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sevenButton.Location = new System.Drawing.Point(97, 264);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(88, 53);
            this.sevenButton.TabIndex = 10;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.minusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.minusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.minusButton.Location = new System.Drawing.Point(379, 323);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(88, 53);
            this.minusButton.TabIndex = 17;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.sixButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sixButton.Location = new System.Drawing.Point(285, 323);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(88, 53);
            this.sixButton.TabIndex = 16;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.fiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fiveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fiveButton.Location = new System.Drawing.Point(191, 323);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(88, 53);
            this.fiveButton.TabIndex = 15;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.fourButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fourButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fourButton.Location = new System.Drawing.Point(97, 323);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(88, 53);
            this.fourButton.TabIndex = 14;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.plusButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.plusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plusButton.Location = new System.Drawing.Point(379, 382);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(88, 53);
            this.plusButton.TabIndex = 21;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.threeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.threeButton.Location = new System.Drawing.Point(285, 382);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(88, 53);
            this.threeButton.TabIndex = 20;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.twoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.twoButton.Location = new System.Drawing.Point(191, 382);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(88, 53);
            this.twoButton.TabIndex = 19;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.oneButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.oneButton.Location = new System.Drawing.Point(97, 382);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(88, 53);
            this.oneButton.TabIndex = 18;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.equalsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalsButton.ForeColor = System.Drawing.Color.Black;
            this.equalsButton.Location = new System.Drawing.Point(379, 441);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(88, 53);
            this.equalsButton.TabIndex = 25;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // commaButton
            // 
            this.commaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.commaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.commaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.commaButton.Location = new System.Drawing.Point(285, 441);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(88, 53);
            this.commaButton.TabIndex = 24;
            this.commaButton.Text = ",";
            this.commaButton.UseVisualStyleBackColor = false;
            this.commaButton.Click += new System.EventHandler(this.commaButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.zeroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.zeroButton.Location = new System.Drawing.Point(191, 441);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(88, 53);
            this.zeroButton.TabIndex = 23;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // signChangeButton
            // 
            this.signChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.signChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signChangeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signChangeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signChangeButton.Location = new System.Drawing.Point(97, 441);
            this.signChangeButton.Name = "signChangeButton";
            this.signChangeButton.Size = new System.Drawing.Size(88, 53);
            this.signChangeButton.TabIndex = 22;
            this.signChangeButton.Text = "+/-";
            this.signChangeButton.UseVisualStyleBackColor = false;
            this.signChangeButton.Click += new System.EventHandler(this.signChangeButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.resultTextBox.Location = new System.Drawing.Point(473, 71);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(105, 423);
            this.resultTextBox.TabIndex = 26;
            this.resultTextBox.TabStop = false;
            this.resultTextBox.WordWrap = false;
            this.resultTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultTextBox_MouseDoubleClick);
            // 
            // mainTextBox2
            // 
            this.mainTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.mainTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainTextBox2.Location = new System.Drawing.Point(97, 105);
            this.mainTextBox2.Name = "mainTextBox2";
            this.mainTextBox2.ReadOnly = true;
            this.mainTextBox2.Size = new System.Drawing.Size(370, 34);
            this.mainTextBox2.TabIndex = 27;
            this.mainTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mainTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBoxes_KeyDown);
            // 
            // CalculatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.Controls.Add(this.mainTextBox2);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.signChangeButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.devideButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearElementButton);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.percentButton);
            this.Name = "CalculatorControl";
            this.Size = new System.Drawing.Size(676, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button clearElementButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button signChangeButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox mainTextBox2;
    }
}
