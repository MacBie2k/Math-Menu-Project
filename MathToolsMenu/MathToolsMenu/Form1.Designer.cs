namespace MathToolsMenu
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.figuresSubMenu = new System.Windows.Forms.Panel();
            this.circle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.quadrangle = new System.Windows.Forms.Button();
            this.figuresButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.mathFunctionsButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.calcButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.circleControl1 = new MathToolsMenu.CircleControl();
            this.triangleControl1 = new MathToolsMenu.TriangleControl();
            this.quadrangleControl1 = new MathToolsMenu.QuadrangleControl();
            this.mathFuntionControl11 = new MathToolsMenu.MathFuntionControl1();
            this.calculatorControl1 = new MathToolsMenu.CalculatorControl();
            this.homePageControl1 = new MathToolsMenu.HomePageControl();
            this.panel1.SuspendLayout();
            this.figuresSubMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.colorPanel);
            this.panel1.Controls.Add(this.figuresSubMenu);
            this.panel1.Controls.Add(this.figuresButton);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.mathFunctionsButton);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.calcButton);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(53)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 404);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(174, 1);
            this.panel9.TabIndex = 12;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.colorPanel.Location = new System.Drawing.Point(0, 125);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(21, 45);
            this.colorPanel.TabIndex = 11;
            // 
            // figuresSubMenu
            // 
            this.figuresSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.figuresSubMenu.Controls.Add(this.circle);
            this.figuresSubMenu.Controls.Add(this.triangle);
            this.figuresSubMenu.Controls.Add(this.quadrangle);
            this.figuresSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.figuresSubMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.figuresSubMenu.Location = new System.Drawing.Point(0, 308);
            this.figuresSubMenu.Name = "figuresSubMenu";
            this.figuresSubMenu.Size = new System.Drawing.Size(174, 96);
            this.figuresSubMenu.TabIndex = 10;
            // 
            // circle
            // 
            this.circle.DialogResult = System.Windows.Forms.DialogResult.No;
            this.circle.Dock = System.Windows.Forms.DockStyle.Top;
            this.circle.FlatAppearance.BorderSize = 0;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.circle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.circle.Location = new System.Drawing.Point(0, 60);
            this.circle.Name = "circle";
            this.circle.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.circle.Size = new System.Drawing.Size(174, 30);
            this.circle.TabIndex = 12;
            this.circle.Text = "Koła";
            this.circle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // triangle
            // 
            this.triangle.DialogResult = System.Windows.Forms.DialogResult.No;
            this.triangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.triangle.FlatAppearance.BorderSize = 0;
            this.triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.triangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.triangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.triangle.Location = new System.Drawing.Point(0, 30);
            this.triangle.Name = "triangle";
            this.triangle.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.triangle.Size = new System.Drawing.Size(174, 30);
            this.triangle.TabIndex = 11;
            this.triangle.Text = "Trójkąty";
            this.triangle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // quadrangle
            // 
            this.quadrangle.DialogResult = System.Windows.Forms.DialogResult.No;
            this.quadrangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.quadrangle.FlatAppearance.BorderSize = 0;
            this.quadrangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quadrangle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.quadrangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quadrangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.quadrangle.Location = new System.Drawing.Point(0, 0);
            this.quadrangle.Name = "quadrangle";
            this.quadrangle.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.quadrangle.Size = new System.Drawing.Size(174, 30);
            this.quadrangle.TabIndex = 10;
            this.quadrangle.Text = "Czworokąty";
            this.quadrangle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.quadrangle.UseVisualStyleBackColor = true;
            this.quadrangle.Click += new System.EventHandler(this.quadangle_Click);
            // 
            // figuresButton
            // 
            this.figuresButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.figuresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.figuresButton.FlatAppearance.BorderSize = 0;
            this.figuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figuresButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.figuresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.figuresButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.figuresButton.Location = new System.Drawing.Point(0, 263);
            this.figuresButton.Name = "figuresButton";
            this.figuresButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.figuresButton.Size = new System.Drawing.Size(174, 45);
            this.figuresButton.TabIndex = 9;
            this.figuresButton.Text = "Figury";
            this.figuresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.figuresButton.UseVisualStyleBackColor = true;
            this.figuresButton.Click += new System.EventHandler(this.figuresButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 262);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(174, 1);
            this.panel8.TabIndex = 8;
            // 
            // mathFunctionsButton
            // 
            this.mathFunctionsButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.mathFunctionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mathFunctionsButton.FlatAppearance.BorderSize = 0;
            this.mathFunctionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mathFunctionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathFunctionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mathFunctionsButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mathFunctionsButton.Location = new System.Drawing.Point(0, 217);
            this.mathFunctionsButton.Name = "mathFunctionsButton";
            this.mathFunctionsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.mathFunctionsButton.Size = new System.Drawing.Size(174, 45);
            this.mathFunctionsButton.TabIndex = 7;
            this.mathFunctionsButton.Text = "Funkcje";
            this.mathFunctionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mathFunctionsButton.UseVisualStyleBackColor = true;
            this.mathFunctionsButton.Click += new System.EventHandler(this.MathFunctionsButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 216);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(174, 1);
            this.panel7.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.calcButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.calcButton.FlatAppearance.BorderSize = 0;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calcButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calcButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calcButton.Location = new System.Drawing.Point(0, 171);
            this.calcButton.Name = "calcButton";
            this.calcButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.calcButton.Size = new System.Drawing.Size(174, 45);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Kalkulator";
            this.calcButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(174, 1);
            this.panel6.TabIndex = 3;
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homeButton.Location = new System.Drawing.Point(0, 125);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(174, 45);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 1);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 124);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.panel3.Location = new System.Drawing.Point(174, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 20);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(174, 580);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 20);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(656, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(636, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // circleControl1
            // 
            this.circleControl1.BackColor = System.Drawing.Color.DarkGray;
            this.circleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleControl1.Location = new System.Drawing.Point(174, 20);
            this.circleControl1.Name = "circleControl1";
            this.circleControl1.Size = new System.Drawing.Size(676, 560);
            this.circleControl1.TabIndex = 8;
            // 
            // triangleControl1
            // 
            this.triangleControl1.BackColor = System.Drawing.Color.DarkGray;
            this.triangleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangleControl1.Location = new System.Drawing.Point(174, 20);
            this.triangleControl1.Name = "triangleControl1";
            this.triangleControl1.Size = new System.Drawing.Size(676, 560);
            this.triangleControl1.TabIndex = 7;
            // 
            // quadrangleControl1
            // 
            this.quadrangleControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.quadrangleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quadrangleControl1.Location = new System.Drawing.Point(174, 20);
            this.quadrangleControl1.Name = "quadrangleControl1";
            this.quadrangleControl1.Size = new System.Drawing.Size(676, 560);
            this.quadrangleControl1.TabIndex = 6;
            // 
            // mathFuntionControl11
            // 
            this.mathFuntionControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.mathFuntionControl11.Cursor = System.Windows.Forms.Cursors.Default;
            this.mathFuntionControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mathFuntionControl11.Location = new System.Drawing.Point(174, 20);
            this.mathFuntionControl11.Name = "mathFuntionControl11";
            this.mathFuntionControl11.Size = new System.Drawing.Size(676, 560);
            this.mathFuntionControl11.TabIndex = 5;
            // 
            // calculatorControl1
            // 
            this.calculatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.calculatorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculatorControl1.Location = new System.Drawing.Point(174, 20);
            this.calculatorControl1.Name = "calculatorControl1";
            this.calculatorControl1.Size = new System.Drawing.Size(676, 560);
            this.calculatorControl1.TabIndex = 3;
            // 
            // homePageControl1
            // 
            this.homePageControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.homePageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePageControl1.Location = new System.Drawing.Point(0, 0);
            this.homePageControl1.Name = "homePageControl1";
            this.homePageControl1.Size = new System.Drawing.Size(850, 600);
            this.homePageControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(98)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.circleControl1);
            this.Controls.Add(this.triangleControl1);
            this.Controls.Add(this.quadrangleControl1);
            this.Controls.Add(this.mathFuntionControl11);
            this.Controls.Add(this.calculatorControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homePageControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.figuresSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button calcButton;
        private CalculatorControl calculatorControl1;
        private HomePageControl homePageControl1;
        private MathFuntionControl1 mathFuntionControl11;
        private System.Windows.Forms.Button mathFunctionsButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel figuresSubMenu;
        private System.Windows.Forms.Button figuresButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button quadrangle;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel panel9;
        private QuadrangleControl quadrangleControl1;
        private TriangleControl triangleControl1;
        private CircleControl circleControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

