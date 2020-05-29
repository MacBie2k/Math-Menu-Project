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
    public partial class QuadrangleControl : UserControl
    {
        public QuadrangleControl()
        {

            InitializeComponent();
            sqrValueDisable();
            rectValueDisable();
            diamValueDisable();
            deltValueDisable();
            trapValueDisable();
            parallValueDisable();

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
            sqrPanel.Visible = false;
            rectPanel.Visible = false;
            diamPanel.Visible = false;
            deltPanel.Visible = false;
            trapPanel.Visible = false;
            parallPanel.Visible = false;
            a.Visible = true;

        }
        /// <summary>
        /// Metoda sprawdzająca zaznaczony radio button i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (squareRadioButton.Checked == true)
            {
                panelsVisible(sqrPanel);
            }
            if (rectangleRadioButton.Checked == true)
            {
                panelsVisible(rectPanel);
            }
            if (diamondRadioButton.Checked == true)
            {
                panelsVisible(diamPanel);
            }
            if (deltoidRadioButton.Checked == true)
            {
                panelsVisible(deltPanel);
            }
            if (trapezoidRadioButton.Checked == true)
            {
                panelsVisible(trapPanel);
            }
            if (parallelogramRadioButton.Checked == true)
            {
                panelsVisible(parallPanel);
            }

        }

        //square
        /// <summary>
        /// Metoda obliczająca pole kwadratu na podstawie długości boku kwadratu
        /// </summary>
        /// <returns>pole kwadratu</returns>
        public double sqrField1()
        {
            if (squareA.Text.Length != 0 && squareA.Text != "0" && squareA.Text != ",")
                return Math.Round(Math.Pow(double.Parse(squareA.Text), 2));
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca pole kwadratu na podstawie długości przekątnej kwadratu
        /// </summary>
        /// <returns>pole kwadratu</returns>
        public double sqrField2()
        {
            if (squareD.Text.Length != 0 && squareD.Text != "0" && squareD.Text != ",")
                return Math.Round((Math.Pow(double.Parse(squareD.Text), 2) / 2));
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód kwadratu
        /// </summary>
        /// <returns>obwód kwadratu</returns>
        public double sqrCircuit()
        {
            if (squareA.Text.Length != 0 && squareA.Text != "0" && squareA.Text != ",")
                return Math.Round(4 * double.Parse(squareA.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca długość przekątnej kwadratu
        /// </summary>
        /// <returns>przekątna kwadratu</returns>
        public double sqrDiagonal()
        {
            if (squareA.Text.Length != 0 && squareA.Text != "0" && squareA.Text != ",")
                return Math.Round(Math.Sqrt(2) * double.Parse(squareA.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych kwadratu
        /// </summary>
        public void sqrValueDisable()
        {
            squareA.Enabled = false;
            squareD.Enabled = false;

        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego kwadratu
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void sqrValueEnableDisable(TextBox a)
        {
            squareA.Enabled = false;
            squareA.Clear();
            squareD.Enabled = false;
            squareD.Clear();
            a.Enabled = true;
            sqrResultTextBox.Clear();
        }
        /// <summary>
        /// Metoda sprawdzająca zaznaczony radio button kwadratu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuareResultButton_Click(object sender, EventArgs e)
        {
            if (radioField1.Checked == true)
            {

                sqrResultTextBox.Text = sqrField1().ToString();
            }
            if (radioField2.Checked == true)
            {

                sqrResultTextBox.Text = sqrField2().ToString();
            }
            if (radioDiagonal.Checked == true)
            {

                sqrResultTextBox.Text = sqrDiagonal().ToString();
            }
            if (radioCircuit.Checked == true)
            {

                sqrResultTextBox.Text = sqrCircuit().ToString();
            }
        }
        /// <summary>
        /// Metoda sprawdzająca zaznaczony radio button kwadratu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioSqr_CheckedChanged(object sender, EventArgs e)
        {
            if (radioField1.Checked == true)
            {
                sqrValueEnableDisable(squareA);

            }
            if (radioField2.Checked == true)
            {
                sqrValueEnableDisable(squareD);

            }
            if (radioDiagonal.Checked == true)
            {
                sqrValueEnableDisable(squareA);

            }
            if (radioCircuit.Checked == true)
            {
                sqrValueEnableDisable(squareA);

            }
        }


        //rect
        /// <summary>
        /// Metoda obliczająca pole prostokąta
        /// </summary>
        /// <returns>pole prostokąta</returns>
        public double rectField()
        {
            if (rectA.Text.Length != 0 && rectB.Text.Length != 0 && rectA.Text != "0" && rectB.Text != "0" && rectA.Text != "," && rectB.Text != ",")
                return Math.Round(double.Parse(rectA.Text) * double.Parse(rectB.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód prostokąta
        /// </summary>
        /// <returns>obwód prostokąta</returns>
        public double rectCircuit()
        {
            if (rectA.Text.Length != 0 && rectB.Text.Length != 0 && rectA.Text != "0" && rectB.Text != "0" && rectA.Text != "," && rectB.Text != ",")
                return Math.Round(2 * double.Parse(rectA.Text) + (2 * double.Parse(rectB.Text)), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca długość przekątnej prostokąta
        /// </summary>
        /// <returns>przekątna prostokąta</returns>
        public double rectDiagonal()
        {
            if (rectA.Text.Length != 0 && rectB.Text.Length != 0 && rectA.Text != "0" && rectB.Text != "0" && rectA.Text != "," && rectB.Text != ",")
                return Math.Round(Math.Sqrt(Math.Pow(double.Parse(rectA.Text), 2) + Math.Pow(double.Parse(rectB.Text), 2)), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych prostokąta
        /// </summary>
        public void rectValueDisable()
        {
            rectA.Enabled = false;
            rectB.Enabled = false;

        }
        /// <summary>
        /// Metoda włączająca dostępność pół tekstowych prostokąta
        /// </summary>
        public void rectValueEnable()
        {
            rectA.Enabled = true;
            rectB.Enabled = true;

        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego prostokąta
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void rectValueEnableDisable(TextBox a)
        {
            rectA.Enabled = false;
            rectA.Clear();
            rectB.Enabled = false;
            rectB.Clear();
            a.Enabled = true;
            rectResultTextBox.Clear();
        }
        /// <summary>
        /// Metoda sprawdzająca zaznaczony radio button prostokąta i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rectResultButton_Click(object sender, EventArgs e)
        {
            if (radioRectField.Checked == true)
            {
                rectResultTextBox.Text = rectField().ToString();
            }
            if (radioRectDiagonal.Checked == true)
            {
                rectResultTextBox.Text = rectDiagonal().ToString();
            }
            if (radioRectCircuit.Checked == true)
            {
                rectResultTextBox.Text = rectCircuit().ToString();
            }
        }
        /// <summary>
        /// Metoda sprawdzająca zaznaczony radio button prostokąta i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioRect_CheckedChanged(object sender, EventArgs e)
        {
            rectValueEnable();
            rectResultTextBox.Clear();
            rectA.Clear();
            rectB.Clear();
        }

        //diamond
        /// <summary>
        /// Metoda obliczająca pole rombu na podstawie boku i kąta
        /// </summary>
        /// <returns>pole rombu</returns>
        public double diamField2()
        {
            if (diamA.Text.Length != 0 && diamA.Text != "0" && diamA.Text != "," && diamAlpha.Text.Length != 0 && diamAlpha.Text != "0" && diamAlpha.Text != ",")
                return Math.Round(Math.Pow(double.Parse(diamA.Text), 2) * Math.Sin(double.Parse(diamAlpha.Text) * Math.PI / 180), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca pole rombu na podstawie przekątnych
        /// </summary>
        /// <returns>pole rombu</returns>
        public double diamField()
        {
            if (diamE.Text.Length != 0 && diamF.Text.Length != 0 && diamE.Text != "0" && diamF.Text != "0" && diamE.Text != "," && diamF.Text != ",")
                return Math.Round((double.Parse(diamE.Text) * double.Parse(diamF.Text)) / 2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód rombu
        /// </summary>
        /// <returns>obwód rombu</returns>
        public double diamCircuit()
        {
            if (diamA.Text.Length != 0 && diamA.Text != "0")
                return Math.Round(4 * double.Parse(diamA.Text), 2);
            else return 0;
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button rombu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioDiam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDiamField.Checked == true)
            {
                diamValueEnableDisable(diamE);

            }
            if (radioDiamCircuit.Checked == true)
            {
                diamValueEnableDisable(diamA);

            }
            if (radioDiamField2.Checked == true)
            {
                diamValueEnableDisable(diamAlpha);

            }
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych rombu
        /// </summary>
        public void diamValueDisable()
        {
            diamA.Enabled = false;
            diamE.Enabled = false;
            diamF.Enabled = false;
            diamAlpha.Enabled = false;
        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego rombu
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void diamValueEnableDisable(TextBox a)
        {
            diamValueDisable();
            diamA.Clear();
            diamE.Clear();
            diamF.Clear();
            if (a == diamE || a == diamF)
            {
                diamE.Enabled = true;
                diamF.Enabled = true;
            }
            else if (a == diamAlpha)
            {
                diamA.Enabled = true;
                diamAlpha.Enabled = true;
            }
            else
            {
                a.Enabled = true;
            }

            diamResultTextBox.Clear();
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button rombu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void diamResultButton_Click(object sender, EventArgs e)
        {
            if (radioDiamField.Checked == true)
            {
                diamResultTextBox.Text = diamField().ToString();
            }
            if (radioDiamCircuit.Checked == true)
            {
                diamResultTextBox.Text = diamCircuit().ToString();
            }
            if (radioDiamField2.Checked == true)
            {
                diamResultTextBox.Text = diamField2().ToString();
            }
        }

        //deltoid
        /// <summary>
        /// Metoda obliczająca pole deltoidu
        /// </summary>
        /// <returns>pole deltoidu</returns>
        public double deltField()
        {
            if (deltE.Text.Length != 0 && deltF.Text.Length != 0 && deltE.Text != "0" && deltF.Text != "0" && deltE.Text != "," && deltF.Text != ",")
                return Math.Round((double.Parse(deltE.Text) * double.Parse(deltF.Text)) / 2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód deltoidu
        /// </summary>
        /// <returns>obwód deltoidu</returns>
        public double deltCircuit()
        {
            if (deltA.Text.Length != 0 && deltA.Text != "0" && deltA.Text != "," && deltB.Text.Length != 0 && deltB.Text != "0" && deltB.Text != ",")
                return Math.Round(2 * double.Parse(deltA.Text) + 2 * double.Parse(deltB.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól tekstowych deltoidu
        /// </summary>
        public void deltValueDisable()
        {
            deltA.Enabled = false;
            deltB.Enabled = false;
            deltE.Enabled = false;
            deltF.Enabled = false;
        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego deltoidu
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void deltValueEnableDisable(TextBox a)
        {
            deltValueDisable();
            deltA.Clear();
            deltB.Clear();
            deltE.Clear();
            deltF.Clear();
            if (a == deltE || a == deltF)
            {
                deltE.Enabled = true;
                deltF.Enabled = true;
            }
            else if (a == deltA || a == deltB)
            {
                deltA.Enabled = true;
                deltB.Enabled = true;
            }

            deltResultTextBox.Clear();
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button deltoidu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioDelt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeltField.Checked == true)
            {
                deltValueEnableDisable(deltE);

            }
            if (radioDeltCircuit.Checked == true)
            {
                deltValueEnableDisable(deltA);

            }
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button deltoidu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deltResultButton_Click(object sender, EventArgs e)
        {
            if (radioDeltField.Checked == true)
            {
                deltResultTextBox.Text = deltField().ToString();
            }
            if (radioDeltCircuit.Checked == true)
            {
                deltResultTextBox.Text = deltCircuit().ToString();
            }
        }

        //trapezoid
        /// <summary>
        /// Metoda wyłączająca dostępnośc pól tekstowych trapezu
        /// </summary>
        public void trapValueDisable()
        {
            trapA.Enabled = false;
            trapB.Enabled = false;
            trapH.Enabled = false;
            trapC.Enabled = false;
            trapD.Enabled = false;
        }
        /// <summary>
        /// Metoda włączająca dostępność pola tekstowego trapezu
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void trapValueEnableDisable(TextBox a)
        {
            trapValueDisable();
            trapA.Clear();
            trapB.Clear();
            trapH.Clear();
            trapD.Clear();
            trapC.Clear();
            if (a == trapH)
            {
                trapB.Enabled = true;
                trapA.Enabled = true;
                trapH.Enabled = true;
            }
            if (a == trapA || a == trapB || a == trapC || a == trapD)
            {
                trapA.Enabled = true;
                trapB.Enabled = true;
                trapD.Enabled = true;
                trapC.Enabled = true;
            }

            trapResultTextBox.Clear();
        }
        /// <summary>
        /// Metoda obliczająca pole trapezu
        /// </summary>
        /// <returns>pole trapezu</returns>
        public double trapField()
        {
            if (trapA.Text.Length != 0 && trapB.Text.Length != 0 && trapH.Text.Length != 0 && trapA.Text != "0"
                && trapB.Text != "0" && trapH.Text != "0" && trapA.Text != "," && trapB.Text != "," && trapH.Text != ",")
                return Math.Round((double.Parse(trapA.Text) + double.Parse(trapB.Text)) * double.Parse(trapH.Text) / 2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód trapezu
        /// </summary>
        /// <returns>obwód trapezu</returns>
        public double trapCircuit()
        {
            if (trapA.Text.Length != 0 && trapB.Text.Length != 0 && trapD.Text.Length != 0 && trapC.Text.Length != 0 && trapA.Text != "0"
                && trapB.Text != "0" && trapD.Text != "0" && trapC.Text != "0" && trapA.Text != "," && trapB.Text != "," && trapD.Text != "," && trapC.Text != ",")
                return Math.Round(double.Parse(trapA.Text) + double.Parse(trapC.Text) + double.Parse(trapD.Text) + double.Parse(trapB.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda sprawdzająca zaznaczony radio button trapezu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioTrap_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTrapField.Checked == true)
            {
                trapValueEnableDisable(trapH);

            }
            if (radioTrapCircuit.Checked == true)
            {
                trapValueEnableDisable(trapA);

            }
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button trapezu i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trapResultButton_Click(object sender, EventArgs e)
        {
            if (radioTrapField.Checked == true)
            {
                trapResultTextBox.Text = trapField().ToString();
            }
            if (radioTrapCircuit.Checked == true)
            {
                trapResultTextBox.Text = trapCircuit().ToString();
            }
        }

        //parallelogram
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button równoległoboku i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioParall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioParallField1.Checked == true)
            {
                parallValueEnableDisable(parallH);

            }
            if(radioParallField2.Checked == true)
            {
                parallValueEnableDisable(parallPhi);

            }
            if(radioParallField3.Checked == true)
            {
                parallValueEnableDisable(parallAlpha);

            }
            if (radioParallCircuit.Checked == true)
            {
                parallValueEnableDisable(parallA);

            }
        }
        /// <summary>
        /// Metoda wyłączająca dostępność pól teksotwych równoległoboku
        /// </summary>
        public void parallValueDisable()
        {
            parallA.Enabled = false;
            parallB.Enabled = false;
            parallAlpha.Enabled = false;
            parallPhi.Enabled = false;
            parallAC.Enabled = false;
            parallBD.Enabled = false;
            parallH.Enabled = false;
        }
        /// <summary>
        /// Metoda obliczająca pole równoległoboku na podstwie boku i wysokości
        /// </summary>
        /// <returns>pole równoległoboku</returns>
        public double parallField1()
        {
            if (parallA.Text.Length != 0 && parallH.Text.Length != 0 && parallA.Text != "0" && parallH.Text != "0" && parallA.Text != "," && parallH.Text != ",")
                return Math.Round(double.Parse(parallA.Text) * double.Parse(parallH.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca pole równoległoboku na podstawie boków i kąta między nimi
        /// </summary>
        /// <returns>pole równoległoboku</returns>
        public double parallField3()
        {
            if (parallA.Text.Length != 0 && parallB.Text.Length != 0 && parallAlpha.Text.Length != 0
                && parallA.Text != "0" && parallB.Text != "0" && parallAlpha.Text != "0" && parallA.Text != "," && parallB.Text != "," && parallAlpha.Text != ",")
                return Math.Round(double.Parse(parallA.Text) * double.Parse(parallB.Text) * Math.Sin(double.Parse(parallAlpha.Text) * Math.PI / 180), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca pole równoległoboku na podstawie przekątnych i kąta między nimi
        /// </summary>
        /// <returns>pole równoległoboku</returns>
        public double parallField2()
        {
            if (parallAC.Text.Length != 0 && parallBD.Text.Length != 0 && parallPhi.Text.Length != 0
                && parallAC.Text != "0" && parallBD.Text != "0" && parallPhi.Text != "0" && parallAC.Text != "," && parallBD.Text != "," && parallPhi.Text != ",")
                return Math.Round(double.Parse(parallAC.Text) * double.Parse(parallBD.Text) * Math.Sin(double.Parse(parallPhi.Text) * Math.PI / 180)/2, 2);
            else return 0;
        }
        /// <summary>
        /// Metoda obliczająca obwód równoległoboku
        /// </summary>
        /// <returns>obwód równoległoboku</returns>
        public double parallCircuit()
        {
            if (parallA.Text.Length != 0 && parallB.Text.Length != 0 && parallA.Text != "0" && parallB.Text != "0" && parallA.Text != "," && parallB.Text != ",")
                return Math.Round(2 * double.Parse(parallA.Text) + 2 * double.Parse(parallB.Text), 2);
            else return 0;
        }
        /// <summary>
        /// Metoda włączająca dostepność pola tekstowego równoległoboku
        /// </summary>
        /// <param name="a">pole tekstowe</param>
        public void parallValueEnableDisable(TextBox a)
        {
            parallValueDisable();
            parallA.Clear();
            parallB.Clear();
            parallH.Clear();
            parallBD.Clear();
            parallAC.Clear();
            parallPhi.Clear();
            parallAlpha.Clear();
            if (a == parallH)
            {

                parallA.Enabled = true;
                parallH.Enabled = true;
            }
            if (a == parallPhi)
            {
                parallAC.Enabled = true;
                parallBD.Enabled = true;
                parallPhi.Enabled = true;

            }
            if (a == parallAlpha)
            {
                parallA.Enabled = true;
                parallB.Enabled = true;
                parallAlpha.Enabled = true;
            }
            if (a == parallA)
            {
                parallA.Enabled = true;
                parallB.Enabled = true;

            }
            parallResultTextBox.Clear();
        }
        /// <summary>
        ///  Metoda sprawdzająca zaznaczony radio button równoległoboku i wywołująca odpowiednią metodę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void parallResultButton_Click(object sender, EventArgs e)
        {
            if (radioParallField1.Checked == true)
            {
                parallResultTextBox.Text = parallField1().ToString();

            }
            if (radioParallField2.Checked == true)
            {
                parallResultTextBox.Text = parallField2().ToString();

            }
            if (radioParallField3.Checked == true)
            {
                parallResultTextBox.Text = parallField3().ToString();

            }
            if (radioParallCircuit.Checked == true)
            {
                parallResultTextBox.Text = parallCircuit().ToString();

            }
        }
    }
}
