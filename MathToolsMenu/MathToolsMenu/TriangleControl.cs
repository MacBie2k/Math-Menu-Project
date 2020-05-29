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
    public partial class TriangleControl : UserControl
    {
        public TriangleControl()
        {
            InitializeComponent();
            panelsUnvisible();
            anyTrianValueDisable();
            equiTrianValueDisable();
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
        /// <summary>
        /// Metoda włączająca widoczność panelu 
        /// </summary>
        /// <param name="a">panel</param>
        public void panelsVisible(Panel a)
        {
            anyPanel.Visible = false;
            equiPanel.Visible = false;
            a.Visible = true;
        }
        /// <summary>
        /// Metoda wyłączająca widocznosć panelu
        /// </summary>
        public void panelsUnvisible()
        {
            anyPanel.Visible = false;
            equiPanel.Visible = false;
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button trójkątków i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(anyTriangleRadioButton.Checked==true)
            {
                panelsVisible(anyPanel);
            }
            if (equiTriangleRadioButton.Checked == true)
            {
                panelsVisible(equiPanel);
            }
        }

        //any triangle
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button trójkąta i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioTrian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTrianField1.Checked == true)
            {
                anyTrianValueEnableDisable(trianH);
            }
            if (radioTrianField2.Checked == true)
            {
                anyTrianValueEnableDisable(trianGamma);
            }
            if (radioTrianField3.Checked == true)
            {
                anyTrianValueEnableDisable(trianAlpha);
            }
            if (radioTrianCircuit.Checked == true)
            {
                anyTrianValueEnableDisable(trianA);
            }
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych trójkąta
        /// </summary>
        public void anyTrianValueDisable()
        {
            trianA.Enabled = false;
            trianH.Enabled = false;
            trianAlpha.Enabled = false;
            trianGamma.Enabled = false;
            trianBeta.Enabled = false;
            trianB.Enabled = false;
            trianC.Enabled = false;
            trianA.Clear();
            trianB.Clear();
            trianC.Clear();
            trianAlpha.Clear();
            trianBeta.Clear();
            trianGamma.Clear();
            trianH.Clear();
        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego trójkąta
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void anyTrianValueEnableDisable(TextBox a)
        {
            anyTrianValueDisable();
            if(a==trianA)
            {
                trianA.Enabled = true;
                trianB.Enabled = true;
                trianC.Enabled = true;
            }
            if (a == trianH)
            {
                trianA.Enabled = true;
                trianH.Enabled = true;
            }
            if (a == trianGamma)
            {
                trianA.Enabled = true;
                trianB.Enabled = true;
                trianGamma.Enabled = true;
            }
            if (a == trianAlpha)
            {
                trianA.Enabled = true;
                trianBeta.Enabled = true;
                trianGamma.Enabled = true;
                trianAlpha.Enabled = true;
            }
            anyTrianResultTextBox.Clear();
        }
        /// <summary>
        /// Metoda obliczająca pole trójkąta na podstawie podstawy i wysokości
        /// </summary>
        /// <returns>pole trójkąta</returns>
        public double anyTrianField1()
        {
            if (trianA.Text.Length != 0 && trianH.Text.Length != 0 && trianA.Text != "0" && trianH.Text != "0" &&
                trianA.Text != "," && trianH.Text != ",")
                return Math.Round(double.Parse(trianA.Text)* double.Parse(trianH.Text)/2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca pole trójkąta na podstawie dwóch boków i kąta między nimi
        /// </summary>
        /// <returns>pole trójkąta</returns>
        public double anyTrianField2()
        {
            if (trianA.Text.Length != 0 && trianB.Text.Length != 0 && trianGamma.Text.Length != 0 && trianA.Text != "0" && trianB.Text != "0" && trianGamma.Text != "0" &&
                trianA.Text != "," && trianB.Text != "," && trianGamma.Text != ",")
                return Math.Round(Math.Sin(double.Parse(trianGamma.Text) * Math.PI / 180)* double.Parse(trianA.Text)*double.Parse(trianB.Text)/2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczajaca pole trójkąta na podstawie boku i kątów
        /// </summary>
        /// <returns>pole trójkąta</returns>
        public double anyTrianField3()
        {
            if (trianA.Text.Length != 0 && trianBeta.Text.Length != 0 && trianGamma.Text.Length != 0 && trianAlpha.Text.Length != 0 && trianA.Text != "0" && trianBeta.Text != "0"
                && trianGamma.Text != "0" && trianAlpha.Text != "0" && trianA.Text != "," && trianBeta.Text != "," && trianGamma.Text != "," && trianAlpha.Text != ",")
                return Math.Round(Math.Pow(double.Parse(trianA.Text), 2)* Math.Sin(double.Parse(trianBeta.Text) * Math.PI / 180)* Math.Sin(double.Parse(trianGamma.Text) * Math.PI / 180)
                    / Math.Sin(double.Parse(trianAlpha.Text) * Math.PI / 180)/2,2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód trójkąta
        /// </summary>
        /// <returns>obwód trójkąta</returns>
        public double anyTrianCircuit()
        {
            if (trianA.Text.Length != 0 && trianB.Text.Length != 0 && trianC.Text.Length != 0 && trianA.Text != "0" && trianB.Text != "0" && trianC.Text != "0" &&
                trianA.Text != "," && trianB.Text != "," && trianC.Text != ",")
                return Math.Round(double.Parse(trianA.Text)+double.Parse(trianB.Text) + double.Parse(trianC.Text), 2);
            else return 0;
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button trójkąta i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anyTrianResultButton_Click(object sender, EventArgs e)
        {
            if (radioTrianField1.Checked == true)
            {
                anyTrianResultTextBox.Text = anyTrianField1().ToString();
            }
            if (radioTrianField2.Checked == true)
            {
                anyTrianResultTextBox.Text = anyTrianField2().ToString();
            }
            if (radioTrianField3.Checked == true)
            {
                anyTrianResultTextBox.Text = anyTrianField3().ToString();
            }
            if (radioTrianCircuit.Checked == true)
            {
                anyTrianResultTextBox.Text = anyTrianCircuit().ToString();
            }
        }

        //equiTriangle
        /// <summary>
        /// Metoda wyłączająca dostępności pól tekstowych trójkąta równobocznego
        /// </summary>
        public void equiTrianValueDisable()
        {
            equiTrianA.Enabled = false;
            equiTrianH.Enabled = false;
            equiTrianA.Clear();
            equiTrianH.Clear();
        }
        /// <summary>
        /// Metoda włączająca dostępność pól tekstowych trójkąta równoboczneg
        /// </summary>
        /// <param name="a"></param>
        public void equiTrianValueEnableDisable(TextBox a)
        {
            equiTrianValueDisable();
            
            if (a == equiTrianH)
            {
                equiTrianA.Enabled = true;
                equiTrianH.Enabled = true;
            }
            if (a == equiTrianA)
            {
                equiTrianA.Enabled = true;
                
            }
            equiTrianResultTextBox.Clear();
        }
        /// <summary>
        /// Metoda obliczająca pole trójkata równobocznego na podstawie podstawy i wysokości
        /// </summary>
        /// <returns>pole trójkąta równobocznego</returns>
        public double equiTrianField1()
        {
            if (equiTrianA.Text.Length != 0 && equiTrianH.Text.Length != 0 && equiTrianA.Text != "0" && equiTrianH.Text != "0" &&
                equiTrianA.Text != "," && equiTrianH.Text != ",")
                return Math.Round(double.Parse(equiTrianA.Text) * double.Parse(equiTrianH.Text) / 2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca pole trójkąta równobocznego na podstawie boków
        /// </summary>
        /// <returns>pole trójkąta równobocznego</returns>
        public double equiTrianField2()
        {
            if (equiTrianA.Text.Length != 0 && equiTrianA.Text != "0" && equiTrianA.Text != ",")
                return Math.Round(Math.Pow(double.Parse(equiTrianA.Text), 2) * Math.Sqrt(3) / 4, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca wysokość trójkąta równobocznego
        /// </summary>
        /// <returns>wysokość trójkąta równobocznego</returns>
        public double equiTrianHeight()
        {
            if (equiTrianA.Text.Length != 0 && equiTrianA.Text != "0" && equiTrianA.Text != ",")
                return Math.Round(double.Parse(equiTrianA.Text) * Math.Sqrt(3) / 2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obówd trójkąta równobocznego
        /// </summary>
        /// <returns>obwód trójkąta równobocznego</returns>
        public double equiTrianCircuit()
        {
            if (equiTrianA.Text.Length != 0 && equiTrianA.Text != "0" && equiTrianA.Text != ",")
                return Math.Round(double.Parse(equiTrianA.Text)* 3, 2);
            else return 0;
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button trójkąta równobocznego i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioEquiTrian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEquiTrianField1.Checked == true)
            {
                equiTrianValueEnableDisable(equiTrianH);
            }
            if (radioEquiTrianField2.Checked == true)
            {
                equiTrianValueEnableDisable(equiTrianA);
            }
            if (radioEquiTrianHeight.Checked == true)
            {
                equiTrianValueEnableDisable(equiTrianA);
            }
            if (radioEquiTrianCircuit.Checked == true)
            {
                equiTrianValueEnableDisable(equiTrianA);
            }
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button trójkąta równobocznego i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void equiTrianResultButton_Click(object sender, EventArgs e)
        {
            if (radioEquiTrianField1.Checked == true)
            {
                equiTrianResultTextBox.Text = equiTrianField1().ToString();
            }
            if (radioEquiTrianField2.Checked == true)
            {
                equiTrianResultTextBox.Text = equiTrianField2().ToString();
            }
            if (radioEquiTrianHeight.Checked == true)
            {
                equiTrianResultTextBox.Text = equiTrianHeight().ToString();
            }
            if (radioEquiTrianCircuit.Checked == true)
            {
                equiTrianResultTextBox.Text = equiTrianCircuit().ToString();
            }
        }
    }
}
