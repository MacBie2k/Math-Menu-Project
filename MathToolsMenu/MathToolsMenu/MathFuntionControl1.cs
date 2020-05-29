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
    public partial class MathFuntionControl1 : UserControl
    {
        public MathFuntionControl1()
        {
            InitializeComponent();
            panel1.BringToFront();


        }

        /// <summary>
        /// Metoda Określająca parametry początkowe wykresu
        /// </summary>
        private void MathFuntionControl1_Load_1(object sender, EventArgs e)
        {

            chart.Series[0].Points.AddXY(0, 1);
            chart.Series[0].Points.AddXY(1, 0);
            chart.Series[0].Points.AddXY(0, -1);
            chart.Series[0].Points.AddXY(-1, 0);
            chart.Series[0].Points.AddXY(0, 1);
            chart.ChartAreas[0].AxisX.Crossing = 0;
            chart.ChartAreas[0].AxisY.Crossing = 0;
            chart.Series[0].Color = Color.White;
            chart.ChartAreas[0].AxisY.ScaleView.Zoom(-10, 10);
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(-10, 10);
            chart.ChartAreas[0].AxisY.ScrollBar.Enabled = false;
            chart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;


            chart.ChartAreas[0].AxisX.Interval = 2;
            chart.ChartAreas[0].AxisY.Interval = 2;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart.Series[1].Points.Clear();
            


        }
        /// <summary>
        /// Metoda wyświetlająca panel odpowiedniej funkcji matematycznej 
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.Text == "Funkcja liniowa")
            {

                linealFunctionPanel.BringToFront();
                chart.Series[1].Points.Clear();

            }
            if (comboBox1.Text == "Funkcja kwadratowa")
            {

                squareFunctionPanel.BringToFront();
                chart.Series[1].Points.Clear();
            }
            if (comboBox1.Text == "Funkcja wykładnicza")
            {

                expoFunctionPanel.BringToFront();
                chart.Series[1].Points.Clear();
            }
            if (comboBox1.Text == "Funkcja logarytmiczna")
            {

                logFunctionPanel.BringToFront();
                chart.Series[1].Points.Clear();
            }
        }


        //lineal function
        /// <summary>
        /// Metoda obliczająca wartość funkcji liniowej
        /// </summary>
        /// <param name="x"> argument funkcji</param>
        /// <returns>wartość funkcji liniowej</returns>
        public double linealFunction(double x)
        {
            return double.Parse(linealATextBox.Text) * x + double.Parse(linealBTextBox.Text);
        }
        /// <summary>
        /// Metoda określająca typ funkcji liniowej
        /// </summary>
        public void typeLinealFunction()
        {
            if(double.Parse(linealATextBox.Text)<0)
            {
                typeLinealTextBox.Text = "Funkcja malejąca";
            }
            else if(double.Parse(linealATextBox.Text) > 0)
            {
                typeLinealTextBox.Text = "Funkcja rosnąca";
            }
            else
            {
                typeLinealTextBox.Text = "Funkcja stała";
            }
        }
        /// <summary>
        /// Metoda wyświetlająca wykres funkcji liniowej i inicjująca inne metody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void linealResultButton_Click(object sender, EventArgs e)
        {
            if (linealATextBox.Text.Length != 0 && linealBTextBox.Text.Length != 0 && linealATextBox.Text != "," && linealBTextBox.Text != ",")
            {
                chart.Series[1].Points.Clear();

                for (int i = -20; i <= 20; i++)
                {
                    chart.Series[1].Points.AddXY(i, linealFunction(i));
                }

                typeLinealFunction();
            }
        }
        /// <summary>
        /// Metoda sprawdzająca wartość funkcji liniowej w określonym argumencie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linealCheckButton_Click(object sender, EventArgs e)
        {
            if (linealATextBox.Text.Length != 0 && linealBTextBox.Text.Length != 0 && linealATextBox.Text != "," && linealBTextBox.Text != "," && linealValueForTextBox.Text.Length != 0)
            {
                double a = double.Parse(linealValueForTextBox.Text);
                textBox1.Text = (Math.Round(linealFunction(a), 2)).ToString();
            }
        }


        //square function
        /// <summary>
        /// Metoda obliczająca deltę funkcji kwadratowej
        /// </summary>
        /// <returns>delta</returns>
        public double delta()
        {
            double a = ((double.Parse(bBox.Text) * double.Parse(bBox.Text)) - (4 * double.Parse(aBox.Text) * double.Parse(cBox.Text)));
            deltaTextBox.Text = a.ToString();
            if (a < 0)
            {
                sqrDeltaTextBox.Text = "-";
            }
            else
            {
                sqrDeltaTextBox.Text = Math.Round(Math.Sqrt(a),2).ToString();
            }
            return a;
        }
        /// <summary>
        /// Metoda obliczająca miejsca zerowe funkcji kwadratowej
        /// </summary>
        public void xSquareFunction()
        {
            double a = delta();
            x1TextBox.Text = null;
            x2TextBox.Text = null;
            if(a>0)
            {
                double x1 = Math.Round(((-1) * double.Parse(bBox.Text) - Math.Sqrt(a)) / (2 * double.Parse(aBox.Text)),2);
                double x2 = Math.Round(((-1) * double.Parse(bBox.Text) + Math.Sqrt(a)) / (2 * double.Parse(aBox.Text)),2);
                x1TextBox.Text = x1.ToString();
                x2TextBox.Text = x2.ToString();
            }
            else if(a==0)
            {
                double x1 = Math.Round(((-1) * double.Parse(bBox.Text)/ (2 * double.Parse(aBox.Text))),2);
                x1TextBox.Text = x1.ToString();
                x2TextBox.Text = "-";
            }
            else
            {
                x1TextBox.Text = "-";
                x2TextBox.Text = "-";
            }
        }
        /// <summary>
        /// Metoda obliczająca współrzędne wierzchołka funkcji kwadratowej
        /// </summary>
        public void pqFunction()
        {
            pTextBox.Text = null;
            qTextBox.Text = null;
            double a = delta();
            double p = Math.Round(((-1) * double.Parse(bBox.Text) / (2 * double.Parse(aBox.Text))),2);
            double q = Math.Round(squareFunction(p),2);
            pTextBox.Text = p.ToString();
            qTextBox.Text = q.ToString();
        }
        /// <summary>
        /// Metoda wypisująca postać ogólną funckji kwadratowej
        /// </summary>
        public void basicFormFunction()
        {
            basicFormTextBox.Text = aBox.Text + "x² + (" + bBox.Text + "x) + (" + cBox.Text+")";
        }
        /// <summary>
        /// Metoda wypisująca postać iloczynową funkcji kwadratowej
        /// </summary>
        public void specialFormFunction()
        {
            double a = delta();
            if (a > 0)
            {
                specialFormTextBox.Text = aBox.Text + "*(x - (" + x1TextBox.Text + "))*(x- (" + x2TextBox.Text + "))";
            }
            else if(a==0)
            {
                specialFormTextBox.Text = aBox.Text + "*(x - (" + x1TextBox.Text + "))²";
            }
            else
            {
                specialFormTextBox.Text = null;
            }
        }
        /// <summary>
        /// Metoda wypisująca postać kanoniczną funkcji kwadratowej
        /// </summary>
        public void canonicalFormFunction()
        {
            canonicaTextBox.Text = aBox.Text + "*(x - (" + pTextBox.Text + "))² + " + "(" + qTextBox.Text + ")";
        }
        /// <summary>
        /// Metoda obliczająca wartość funkcji kwadratowej
        /// </summary>
        /// <param name="x">argument funkcji kwadratowej</param>
        /// <returns>wartość funkcji kwadratowej</returns>
        public double squareFunction(double x)
        {

            return double.Parse(aBox.Text) * x * x + double.Parse(bBox.Text) * x + double.Parse(cBox.Text);

        }
        /// <summary>
        /// Metoda wyświetlająca wykres funkcji kwadratowej i ininjująca inne metody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resultButton_Click(object sender, EventArgs e)
        {
            if (aBox.Text.Length != 0 && bBox.Text.Length != 0 && cBox.Text.Length != 0 && aBox.Text != "," && bBox.Text != "," && cBox.Text != ",")
            {
                chart.Series[1].Points.Clear();

                for (int i = -20; i <= 20; i++)
                {
                    chart.Series[1].Points.AddXY(i, squareFunction(i));
                }
                delta();
                xSquareFunction();
                pqFunction();
                basicFormFunction();
                specialFormFunction();
                canonicalFormFunction();
            }
        }

        

        //exponential function
        /// <summary>
        /// Metoda obliczająca wartość funkcji wykładniczej
        /// </summary>
        /// <param name="x">argument funkcji wykładniczej</param>
        /// <returns>wartość fukcji wykładniczej</returns>
        public double expoFunction(double x)
        {

            double b = double.Parse(expoATextBox.Text);
            return Math.Pow(b, x);
        }
        /// <summary>
        /// Metoda określająca typ funkcji wykładniczej
        /// </summary>
        public void expoTypeFuntion()
        {
            if (double.Parse(expoATextBox.Text)>1)
            {
                expoTypeTextBox.Text = "Funkcja rosnąca";
            }
            if (double.Parse(expoATextBox.Text) < 1)
            {
                expoTypeTextBox.Text = "Funkcja malejąca";
            }
            if (double.Parse(expoATextBox.Text) == 1)
            {
                expoTypeTextBox.Text = "Funkcja stała";
            }
        }
        /// <summary>
        /// Metoda wyświetlająca wykres funkcji wykładniczej i inicjująca inne metody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void expoResultButton_Click(object sender, EventArgs e)
        {
            if (expoATextBox.Text.Length != 0 && expoATextBox.Text != "," && double.Parse(expoATextBox.Text) > 0)
            {
                chart.Series[1].Points.Clear();
                for (double i = -9.8; i < 11; i=i+0.02)
                {
                    chart.Series[1].Points.AddXY(i, expoFunction(i));
                }
                expoTypeFuntion();
            }
        }
        /// <summary>
        /// Metoda obliczająca wartość funkcji wykładniczej w określonym argumencie
        /// </summary>
        public void expoValueForButtonFunction()
        {
            if (expoATextBox.Text.Length != 0)
            {
                double a = expoFunction(double.Parse(expoValueForTextBox.Text));
                expoResultTextBox.Text = a.ToString();

            }
        }

        private void expoValueForButton_Click(object sender, EventArgs e)
        {
            expoValueForButtonFunction();
        }


        //log function
        /// <summary>
        /// Metoda obliczająca wartość funkcji logarytmicznej
        /// </summary>
        /// <param name="x">argument funkcji logarytmicznej</param>
        /// <returns>wartość funkcji logarytmicznej</returns>
        public double logFunction(double x)
        {

            double b = Math.Log10(x) / Math.Log10(double.Parse(logATextBox.Text));
            return b;
        }
        /// <summary>
        /// Metoda obliczająca wartość funckcji logarytmicznej w określonym argumencie 
        /// </summary>
        public void logValueForButtonFunction()
        {
            if (logATextBox.Text.Length != 0)
            {
                double a = logFunction(double.Parse(logValueForTextBox.Text));
                logResultTextBox.Text = a.ToString();

            }
        }
        /// <summary>
        /// Metoda określająca typ funkcji logarytmicznej
        /// </summary>
        public void logTypeFuntion()
        {
            if (double.Parse(logATextBox.Text) > 1)
            {
                logTypeTextBox.Text = "Funkcja rosnąca";
            }
            else if (double.Parse(logATextBox.Text) < 1)
            {
                logTypeTextBox.Text = "Funkcja malejąca";
            }
            
        }
        /// <summary>
        /// Metoda wyświetlająca wykres funkcji logarytmicznej i inicjująca inne metody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logResultButton_Click(object sender, EventArgs e)
        {
            if (logATextBox.Text.Length != 0 && double.Parse(logATextBox.Text)!=0 && double.Parse(logATextBox.Text) != 1 && logATextBox.Text != ",")
            {
                chart.Series[1].Points.Clear();
                
                for (double i = 0.01; i <= 20; i +=0.01)
                {
                    chart.Series[1].Points.AddXY(i, logFunction(i));
                }
                logTypeFuntion();
            }
        }
        private void logValueForButton_Click(object sender, EventArgs e)
        {
            logValueForButtonFunction();
        }


        //validation
        /// <summary>
        /// Metoda określajaca dozwolone znaki w polach funkcji kwadratowej 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abcSquareBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Metoda określajaca dozwolone znaki w polach funkcji logarytmicznej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logATextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        /// Metoda określajaca dozwolone znaki w polach funkcji wykładniczej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void expoATextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        /// Metoda określajaca dozwolone znaki w polach funkcji liniowej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linealABTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
