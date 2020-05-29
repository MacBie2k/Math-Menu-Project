namespace MathToolsMenu
{
    partial class CircleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.partCircRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circlePanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioCircleCircuit = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.circleResultTextBox = new System.Windows.Forms.TextBox();
            this.radioCircleField = new System.Windows.Forms.RadioButton();
            this.circeResultButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.circleR = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.partCircPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioPartCircCircuit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.partCircResultTextBox = new System.Windows.Forms.TextBox();
            this.radioPartCircField = new System.Windows.Forms.RadioButton();
            this.partCircResultButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.partCircR = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.partCircAlpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.circlePanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.partCircPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.circleRadioButton);
            this.panel1.Controls.Add(this.partCircRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 62);
            this.panel1.TabIndex = 6;
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circleRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circleRadioButton.Location = new System.Drawing.Point(226, 21);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(59, 24);
            this.circleRadioButton.TabIndex = 0;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "koło";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            this.circleRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // partCircRadioButton
            // 
            this.partCircRadioButton.AutoSize = true;
            this.partCircRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partCircRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partCircRadioButton.Location = new System.Drawing.Point(355, 21);
            this.partCircRadioButton.Name = "partCircRadioButton";
            this.partCircRadioButton.Size = new System.Drawing.Size(125, 24);
            this.partCircRadioButton.TabIndex = 3;
            this.partCircRadioButton.TabStop = true;
            this.partCircRadioButton.Text = "wycinek koła";
            this.partCircRadioButton.UseVisualStyleBackColor = true;
            this.partCircRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.partCircPanel);
            this.panel2.Controls.Add(this.circlePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 498);
            this.panel2.TabIndex = 8;
            // 
            // circlePanel
            // 
            this.circlePanel.BackColor = System.Drawing.Color.DarkGray;
            this.circlePanel.Controls.Add(this.panel7);
            this.circlePanel.Controls.Add(this.circleR);
            this.circlePanel.Controls.Add(this.pictureBox5);
            this.circlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circlePanel.Location = new System.Drawing.Point(0, 0);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Size = new System.Drawing.Size(676, 498);
            this.circlePanel.TabIndex = 17;
            this.circlePanel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.radioCircleCircuit);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.circleResultTextBox);
            this.panel7.Controls.Add(this.radioCircleField);
            this.panel7.Controls.Add(this.circeResultButton);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(399, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 287);
            this.panel7.TabIndex = 7;
            // 
            // radioCircleCircuit
            // 
            this.radioCircleCircuit.AutoSize = true;
            this.radioCircleCircuit.Location = new System.Drawing.Point(18, 76);
            this.radioCircleCircuit.Name = "radioCircleCircuit";
            this.radioCircleCircuit.Size = new System.Drawing.Size(14, 13);
            this.radioCircleCircuit.TabIndex = 12;
            this.radioCircleCircuit.TabStop = true;
            this.radioCircleCircuit.UseVisualStyleBackColor = true;
            this.radioCircleCircuit.CheckedChanged += new System.EventHandler(this.radioCircle_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label13.Location = new System.Drawing.Point(31, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "L=2*π*r";
            // 
            // circleResultTextBox
            // 
            this.circleResultTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circleResultTextBox.Location = new System.Drawing.Point(13, 185);
            this.circleResultTextBox.Multiline = true;
            this.circleResultTextBox.Name = "circleResultTextBox";
            this.circleResultTextBox.ReadOnly = true;
            this.circleResultTextBox.Size = new System.Drawing.Size(184, 45);
            this.circleResultTextBox.TabIndex = 5;
            this.circleResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioCircleField
            // 
            this.radioCircleField.Location = new System.Drawing.Point(19, 43);
            this.radioCircleField.Name = "radioCircleField";
            this.radioCircleField.Size = new System.Drawing.Size(13, 13);
            this.radioCircleField.TabIndex = 0;
            this.radioCircleField.TabStop = true;
            this.radioCircleField.UseVisualStyleBackColor = true;
            this.radioCircleField.CheckedChanged += new System.EventHandler(this.radioCircle_CheckedChanged);
            // 
            // circeResultButton
            // 
            this.circeResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circeResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.circeResultButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.circeResultButton.Location = new System.Drawing.Point(13, 144);
            this.circeResultButton.Name = "circeResultButton";
            this.circeResultButton.Size = new System.Drawing.Size(184, 35);
            this.circeResultButton.TabIndex = 4;
            this.circeResultButton.Text = "Oblicz";
            this.circeResultButton.UseVisualStyleBackColor = true;
            this.circeResultButton.Click += new System.EventHandler(this.circeResultButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label15.Location = new System.Drawing.Point(31, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 6;
            this.label15.Text = "P=π*r²";
            // 
            // circleR
            // 
            this.circleR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circleR.Location = new System.Drawing.Point(204, 240);
            this.circleR.Multiline = true;
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(46, 33);
            this.circleR.TabIndex = 3;
            this.circleR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(33, 85);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(300, 300);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // partCircPanel
            // 
            this.partCircPanel.BackColor = System.Drawing.Color.DarkGray;
            this.partCircPanel.Controls.Add(this.label3);
            this.partCircPanel.Controls.Add(this.partCircAlpha);
            this.partCircPanel.Controls.Add(this.panel4);
            this.partCircPanel.Controls.Add(this.partCircR);
            this.partCircPanel.Controls.Add(this.pictureBox1);
            this.partCircPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partCircPanel.Location = new System.Drawing.Point(0, 0);
            this.partCircPanel.Name = "partCircPanel";
            this.partCircPanel.Size = new System.Drawing.Size(676, 498);
            this.partCircPanel.TabIndex = 18;
            this.partCircPanel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioPartCircCircuit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.partCircResultTextBox);
            this.panel4.Controls.Add(this.radioPartCircField);
            this.panel4.Controls.Add(this.partCircResultButton);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Location = new System.Drawing.Point(399, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 287);
            this.panel4.TabIndex = 7;
            // 
            // radioPartCircCircuit
            // 
            this.radioPartCircCircuit.AutoSize = true;
            this.radioPartCircCircuit.Location = new System.Drawing.Point(18, 76);
            this.radioPartCircCircuit.Name = "radioPartCircCircuit";
            this.radioPartCircCircuit.Size = new System.Drawing.Size(14, 13);
            this.radioPartCircCircuit.TabIndex = 12;
            this.radioPartCircCircuit.TabStop = true;
            this.radioPartCircCircuit.UseVisualStyleBackColor = true;
            this.radioPartCircCircuit.CheckedChanged += new System.EventHandler(this.partCirc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "L=2*π*r*α/360°";
            // 
            // partCircResultTextBox
            // 
            this.partCircResultTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partCircResultTextBox.Location = new System.Drawing.Point(13, 185);
            this.partCircResultTextBox.Multiline = true;
            this.partCircResultTextBox.Name = "partCircResultTextBox";
            this.partCircResultTextBox.ReadOnly = true;
            this.partCircResultTextBox.Size = new System.Drawing.Size(184, 45);
            this.partCircResultTextBox.TabIndex = 5;
            this.partCircResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioPartCircField
            // 
            this.radioPartCircField.Location = new System.Drawing.Point(19, 43);
            this.radioPartCircField.Name = "radioPartCircField";
            this.radioPartCircField.Size = new System.Drawing.Size(13, 13);
            this.radioPartCircField.TabIndex = 0;
            this.radioPartCircField.TabStop = true;
            this.radioPartCircField.UseVisualStyleBackColor = true;
            this.radioPartCircField.CheckedChanged += new System.EventHandler(this.partCirc_CheckedChanged);
            // 
            // partCircResultButton
            // 
            this.partCircResultButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partCircResultButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.partCircResultButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.partCircResultButton.Location = new System.Drawing.Point(13, 144);
            this.partCircResultButton.Name = "partCircResultButton";
            this.partCircResultButton.Size = new System.Drawing.Size(184, 35);
            this.partCircResultButton.TabIndex = 4;
            this.partCircResultButton.Text = "Oblicz";
            this.partCircResultButton.UseVisualStyleBackColor = true;
            this.partCircResultButton.Click += new System.EventHandler(this.partCircResultButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "P=π*r²*α/360°";
            // 
            // partCircR
            // 
            this.partCircR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partCircR.Location = new System.Drawing.Point(204, 258);
            this.partCircR.Multiline = true;
            this.partCircR.Name = "partCircR";
            this.partCircR.Size = new System.Drawing.Size(46, 33);
            this.partCircR.TabIndex = 3;
            this.partCircR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partCircR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // partCircAlpha
            // 
            this.partCircAlpha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partCircAlpha.Location = new System.Drawing.Point(140, 192);
            this.partCircAlpha.Multiline = true;
            this.partCircAlpha.Name = "partCircAlpha";
            this.partCircAlpha.Size = new System.Drawing.Size(46, 33);
            this.partCircAlpha.TabIndex = 8;
            this.partCircAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partCircAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxesValidation_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(228, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "?";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.label25.Location = new System.Drawing.Point(107, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 25);
            this.label25.TabIndex = 18;
            this.label25.Text = "α";
            // 
            // CircleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CircleControl";
            this.Size = new System.Drawing.Size(676, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.circlePanel.ResumeLayout(false);
            this.circlePanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.partCircPanel.ResumeLayout(false);
            this.partCircPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.RadioButton partCircRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel circlePanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioCircleCircuit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox circleResultTextBox;
        private System.Windows.Forms.RadioButton radioCircleField;
        private System.Windows.Forms.Button circeResultButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox circleR;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel partCircPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partCircAlpha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioPartCircCircuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partCircResultTextBox;
        private System.Windows.Forms.RadioButton radioPartCircField;
        private System.Windows.Forms.Button partCircResultButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partCircR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label25;
    }
}
