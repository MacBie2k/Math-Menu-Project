using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathToolsMenu
{
    public partial class CircleControl : UserControl
    {
        public CircleControl()
        {
            InitializeComponent();
            panelsUnvisible();
            circValueDisable();
            partCircValueDisable();
        }
        /// <summary>
        /// Metoda włączająca widoczność panelu
        /// </summary>
        /// <param name="a">panel</param>
        public void panelsVisible(Panel a)
        {
            panelsUnvisible();
            a.Visible = true;
        }
        /// <summary>
        /// Metoda wyłączająca widoczność paneli
        /// </summary>
        public void panelsUnvisible()
        {
            circlePanel.Visible = false;
            partCircPanel.Visible = false;
           
        }
        /// <summary>
        /// Metoda spawdzająca zaznaczony radio button i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(circleRadioButton.Checked==true)
            {
                panelsVisible(circlePanel);
            }
            if (partCircRadioButton.Checked == true)
            {
                panelsVisible(partCircPanel);
            }
        }
        /// <summary>
        /// Metoda określająca dozwolone znaki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxesValidation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        //circle
        /// <summary>
        /// Metoda obliczająca pole koła
        /// </summary>
        /// <returns>pole koła</returns>
        public double circleField()
        {
            if (circleR.Text.Length != 0 && circleR.Text != "0" && circleR.Text != ",")
                return Math.Round(Math.Pow(double.Parse(circleR.Text), 2) * Math.PI,2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód koła
        /// </summary>
        /// <returns>obówd koła</returns>
        public double circleCircuit()
        {
            if (circleR.Text.Length != 0 && circleR.Text != "0" && circleR.Text != ",")
                return Math.Round(2*double.Parse(circleR.Text) * Math.PI,2);
            else return 0;
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych koła
        /// </summary>
        public void circValueDisable()
        {
            circleR.Enabled = false;
            circleR.Clear();
        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego 
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void circValueEnableDisable(TextBox a)
        {
            circValueDisable();
            a.Enabled = true;
            circleResultTextBox.Clear();

        }
        /// <summary>
        /// Metoda spawdzająca zaznaczony radio button i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioCircle_CheckedChanged(object sender, EventArgs e)
        {
            if(radioCircleField.Checked==true)
            {
                circValueEnableDisable(circleR);
            }
            if (radioCircleCircuit.Checked == true)
            {
                circValueEnableDisable(circleR);
            }
        }
        /// <summary>
        /// Metoda spawdzająca zaznaczony radio button i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void circeResultButton_Click(object sender, EventArgs e)
        {
            if (radioCircleField.Checked == true)
            {
                circleResultTextBox.Text = circleField().ToString();
            }
            if (radioCircleCircuit.Checked == true)
            {
                circleResultTextBox.Text = circleCircuit().ToString();
            }
        }

        //part circle
        /// <summary>
        /// Metoda obliczająca pole wycinku koła
        /// </summary>
        /// <returns>pole wycinku koła</returns>
        public double partCircleField()
        {
            if (partCircR.Text.Length != 0 && partCircAlpha.Text.Length != 0 && partCircR.Text != "0" && partCircR.Text != "," && partCircAlpha.Text != "0" && partCircAlpha.Text != ",")
                return Math.Round(Math.Pow(double.Parse(partCircR.Text), 2) * Math.PI * double.Parse(partCircAlpha.Text) / 360, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca długość łuku koła
        /// </summary>
        /// <returns>długość łuku koła</returns>
        public double partCircleCircuit()
        {
            if (partCircR.Text.Length != 0 && partCircAlpha.Text.Length != 0 && partCircR.Text != "0" && partCircR.Text != "," && partCircAlpha.Text != "0" && partCircAlpha.Text != ",")
                return Math.Round(2 * double.Parse(partCircR.Text) * Math.PI* double.Parse(partCircAlpha.Text)/360, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych wycinku koła
        /// </summary>
        public void partCircValueDisable()
        {
            partCircR.Enabled = false;
            partCircR.Clear();
            partCircAlpha.Enabled = false;
            partCircAlpha.Clear();
        }
        /// <summary>
        /// Metoda włączająca dostępność pól tekstowych wycinku koła
        /// </summary>
        public void partCircValueEnableDisable()
        {
            partCircValueDisable();
            partCircAlpha.Enabled = true;
            partCircR.Enabled = true;
            partCircResultTextBox.Clear();

        }
        /// <summary>
        /// Metoda spawdzająca zaznaczony radio button i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partCirc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPartCircField.Checked == true)
            {
                partCircValueEnableDisable();
            }
            if (radioPartCircCircuit.Checked == true)
            {
                partCircValueEnableDisable();
            }
        }
        /// <summary>
        /// Metoda spawdzająca zaznaczony radio button i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partCircResultButton_Click(object sender, EventArgs e)
        {
            if (radioPartCircField.Checked == true)
            {
                partCircResultTextBox.Text = partCircleField().ToString();
            }
            if (radioPartCircCircuit.Checked == true)
            {
                partCircResultTextBox.Text = partCircleCircuit().ToString();
            }
        }
    }
}
