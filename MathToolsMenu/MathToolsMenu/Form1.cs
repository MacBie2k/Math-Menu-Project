using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathToolsMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homePageControl1.BringToFront();
            clickedButtonStyle(homeButton);
            design();
        }

        public void clickedButtonStyle(Button button)
        {
            colorPanel.Top = button.Top;
        }
        public void design()
        {
            figuresSubMenu.Visible = false;
        }
        public void hideSubMenu()
        {
            if (figuresSubMenu.Visible == true)
            {
                figuresSubMenu.Visible = false;
            }
        }
        public void showSubMenu(Panel subMenu)
        {

            if(subMenu.Visible == false)
            {
                hideSubMenu();
               subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        private void calcButton_Click(object sender, EventArgs e)
        {
            calculatorControl1.BringToFront();
            clickedButtonStyle(calcButton);
            hideSubMenu();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homePageControl1.BringToFront();
            clickedButtonStyle(homeButton);
            hideSubMenu();
        }

        private void MathFunctionsButton_Click(object sender, EventArgs e)
        {
            mathFuntionControl11.BringToFront();
            clickedButtonStyle(mathFunctionsButton);
            hideSubMenu();
        }

        private void figuresButton_Click(object sender, EventArgs e)
        {
            clickedButtonStyle(figuresButton);
            showSubMenu(figuresSubMenu);
        }

        private void circle_Click(object sender, EventArgs e)
        {
            circleControl1.BringToFront();
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            triangleControl1.BringToFront();
        }

        private void quadangle_Click(object sender, EventArgs e)
        {
            quadrangleControl1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
