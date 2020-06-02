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
    public partial class CalculatorControl : UserControl
    {
        public CalculatorControl()
        {
            InitializeComponent();
            resultTextBox.ScrollBars = ScrollBars.Both;         
        }
        /// <summary>
        /// Pierwsza liczba działania
        /// </summary>
        private string firstNumber = null;
        /// <summary>
        /// Druga liczba działania
        /// </summary>
        private string secondNumber = null;
        /// <summary>
        /// Znak Działania
        /// </summary>
        private char actionSymbol = ' ';
        /// <summary>
        /// Zmienna sprawdzająca czy działanie wykonało się poprawnie
        /// </summary>
        private int buffer = 0;
        
        public string FirstNumber
        {
            get
            {
                return firstNumber;
            }
        }
        
        public string SecondNumber
        {
            get
            {
                return secondNumber;
            }
        }
        
        public char ActionSymbol
        {
            get
            {
                return actionSymbol;
            }
        }
        /// <summary>
        /// Metoda dodająca cyfrę do zmiennych firstNumber/secondNumber
        /// </summary>
        /// <param name="number">dodawana cyfra</param>
        public void addNumber(string number)
        {
            if(actionSymbol == ' ')
            {
                firstNumber += number;
                mainTextBox.Text += number;
            }
            if (actionSymbol != ' ')
            {
                secondNumber += number;
                
                mainTextBox2.Text += number;
            }
        }
        /// <summary>
        /// Metoda określająca symbol działania matematycznego
        /// </summary>
        /// <param name="symbol">symbol działania</param>
        public void addActionSymbol(char symbol)
        {
            if(firstNumber!=null&& firstNumber.Length!=0 && (secondNumber==null || secondNumber.Length==0))
            {
                if(firstNumber.Last()==',')
                {
                    firstNumber=firstNumber.Remove(firstNumber.Length - 1);
                }
                actionSymbol = symbol;
                mainTextBox.Text =firstNumber + symbol;
            }
            else if (actionSymbol == '/' && double.Parse(secondNumber) == 0)
            {
                MessageBox.Show("Niedozwolone dzielenie przez 0");
            }
            else if (secondNumber != null && secondNumber.Length != 0)
            {
                calculationFunction();
                actionSymbol = symbol;
                mainTextBox.Text = firstNumber + symbol;
            }
        }
        /// <summary>
        /// Metoda obliczająca działanie matematyczne
        /// </summary>
        public void calculationFunction()
        {
            double calcResult=0;
            if (actionSymbol == '/' && double.Parse(secondNumber) == 0)
            {
                MessageBox.Show("Niedozwolone dzielenie przez 0");
            }
            else
            {
                if (secondNumber != null && secondNumber.Length != 0)
                {
                    switch (actionSymbol)
                    {
                        case ('+'):
                            {
                                calcResult = double.Parse(firstNumber) + double.Parse(secondNumber);
                                firstNumber = calcResult.ToString();
                                mainTextBox.Text = firstNumber;
                                mainTextBox2.Text = null;
                                secondNumber = null;
                                actionSymbol = ' ';
                                buffer = 1;
                            }
                            break;
                        case ('-'):
                            {
                                calcResult = double.Parse(firstNumber) - double.Parse(secondNumber);
                                firstNumber = calcResult.ToString();
                                mainTextBox.Text = firstNumber;
                                mainTextBox2.Text = null;
                                secondNumber = null;
                                actionSymbol = ' ';
                                buffer = 1;
                            }
                            break;
                        case ('*'):
                            {
                                calcResult = double.Parse(firstNumber) * double.Parse(secondNumber);
                                firstNumber = calcResult.ToString();
                                mainTextBox.Text = firstNumber;
                                mainTextBox2.Text = null;
                                secondNumber = null;
                                actionSymbol = ' ';
                                buffer = 1;
                            }
                            break;
                        case ('/'):
                            {
                                calcResult = double.Parse(firstNumber) / double.Parse(secondNumber);
                                firstNumber = calcResult.ToString();
                                mainTextBox.Text = firstNumber;
                                mainTextBox2.Text = null;
                                secondNumber = null;
                                actionSymbol = ' ';
                                buffer = 1;
                            }
                            break;
                        case ('%'):
                            {
                                calcResult = double.Parse(firstNumber) / 100 * double.Parse(secondNumber);
                                firstNumber = calcResult.ToString();
                                mainTextBox.Text = firstNumber;
                                mainTextBox2.Text = null;
                                secondNumber = null;
                                actionSymbol = ' ';
                                buffer = 1;
                            }
                            break;

                    }
                }
            }
            

        }
        /// <summary>
        /// Metoda dopisująca wynik działania do pola z wynikami
        /// </summary>
        public void equalButtonFunction()
        {


            if (actionSymbol == '/' && double.Parse(secondNumber) == 0)
            {
                MessageBox.Show("Niedozwolone dzielenie przez 0");
            }
            else
            {
                calculationFunction();
                if (buffer == 1)
                {
                    buffer = 0;
                    resultTextBox.Text += firstNumber + Environment.NewLine;
                    mainTextBox.Text = null;

                    firstNumber = null;
                }
            }
            
        }
        /// <summary>
        /// Metoda dodająca przecinek do liczby
        /// </summary>
        public void commaButtonFunction()
        {
            if(firstNumber==null || firstNumber.Length==0)
            {
                firstNumber = "0,";
                mainTextBox.Text= "0,";
            }
            else if(firstNumber!=null && firstNumber.Contains(',')==false && actionSymbol==' ')
            {
                firstNumber += ',';
                mainTextBox.Text = firstNumber;
            }
            else if ((secondNumber == null || secondNumber.Length==0) && actionSymbol!=' ')
            {
                secondNumber = "0,";
                mainTextBox2.Text += "0,";
            }
            else if(secondNumber != null && secondNumber.Contains(',') == false)
            {
                secondNumber += ',';
                mainTextBox2.Text = secondNumber;
            }

        }
        /// <summary>
        /// Metoda zmieniająca liczbę na przeciwną
        /// </summary>
        public void signChangeButtonFunction()
        {
            if(firstNumber!=null && actionSymbol==' ')
            {
                firstNumber = (double.Parse(firstNumber)*(-1)).ToString();
                

                    mainTextBox.Text =  firstNumber;
                
                
            }
            if (secondNumber != null)
            {
                secondNumber = (double.Parse(secondNumber) * (-1)).ToString();
               
                    mainTextBox2.Text =secondNumber;
                
               
                
                
            }
        }
        /// <summary>
        /// Metoda usuwająca jeden znak z obszaru do wporwadznia działania
        /// </summary>
        public void backButtonFunction()
        {
            if (secondNumber != null && secondNumber.Length != 0 && actionSymbol != ' ')
            {
                secondNumber = secondNumber.Remove(secondNumber.Length - 1);
                mainTextBox2.Text = secondNumber;
                if (secondNumber == "-")
                {
                    secondNumber = null;
                    mainTextBox2.Text = null;
                }
            }
            else if ((secondNumber == null || secondNumber.Length == 0) && actionSymbol != ' ')
            {
                actionSymbol = ' ';
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);

            }
            else if (firstNumber!=null && firstNumber.Length!=0 && actionSymbol==' ')
            {
                firstNumber = firstNumber.Remove(firstNumber.Length - 1);
                mainTextBox.Text = firstNumber;
                if (firstNumber == "-")
                {
                    firstNumber = null;
                    mainTextBox.Text = null;
                }
            }
            
        }
        /// <summary>
        /// Metoda czyszcząca obszar do wprowadznia działania
        /// </summary>
        public void clearButtonFunction()
        {
            mainTextBox2.Text = null;
            mainTextBox.Text = null;
            firstNumber = null;
            secondNumber = null;
            actionSymbol = ' ';
        }
        /// <summary>
        /// Metoda usuwająca jeden segment działania
        /// </summary>
        public void clearElementButtonFunction()
        {
            if (secondNumber != null )
            {
                secondNumber = null;
                mainTextBox2.Text = null;
            }
            else if(actionSymbol!=' ' && secondNumber==null)
            {
                actionSymbol = ' ';
                mainTextBox.Text = firstNumber; 
            }
            else
            {
                firstNumber = null;
                mainTextBox.Text = null;
            }
        }
        /// <summary>
        /// Metoda podnosząca liczbę do potęgi drugiej
        /// </summary>
        public void powerButtonFunction()
        {
            if (secondNumber != null && secondNumber.Length != 0)
            {
                secondNumber = (Math.Pow(double.Parse(secondNumber), 2)).ToString();
                mainTextBox2.Text = secondNumber;
            }
            if(firstNumber != null && firstNumber.Length != 0 &&actionSymbol ==' ')
            {
                firstNumber = (Math.Pow(double.Parse(firstNumber), 2)).ToString();
                mainTextBox.Text = firstNumber;
            }
        }
        /// <summary>
        /// Metoda licząca pierwiastek drugiego stopnia z liczby
        /// </summary>
        public void sqrtButtonFunction()
        {
            if (secondNumber != null && secondNumber.Length != 0)
            {
                secondNumber = (Math.Sqrt(double.Parse(secondNumber))).ToString();
                mainTextBox2.Text = secondNumber;
            }
            if (firstNumber != null && firstNumber.Length != 0 && actionSymbol == ' ')
            {
                firstNumber = (Math.Sqrt(double.Parse(firstNumber))).ToString();
                mainTextBox.Text = firstNumber;
            }
        }
        /// <summary>
        /// Metoda odwracająca liczbę
        /// </summary>
        public void reverseButtonFunction()
        {
            if (secondNumber != null && secondNumber.Length != 0)
            {
                secondNumber = (1/(double.Parse(secondNumber))).ToString();
                mainTextBox2.Text = secondNumber;
            }
            if (firstNumber != null && firstNumber.Length != 0 && actionSymbol == ' ')
            {
                firstNumber = (1/(double.Parse(firstNumber))).ToString();
                mainTextBox.Text = firstNumber;
            }
        }





        public void plusButton_Click(object sender, EventArgs e)
        {
            addActionSymbol('+');
        }

        public void minusButton_Click(object sender, EventArgs e)
        {
            addActionSymbol('-');
        }

        public void multiplyButton_Click(object sender, EventArgs e)
        {
            addActionSymbol('*');
        }

        public void devideButton_Click(object sender, EventArgs e)
        {
            addActionSymbol('/');
        }



        public void commaButton_Click(object sender, EventArgs e)
        {
            commaButtonFunction();
        }

        public void equalsButton_Click(object sender, EventArgs e)
        {
            equalButtonFunction();
        }

        public void signChangeButton_Click(object sender, EventArgs e)
        {
            signChangeButtonFunction();
        }

        public void backButton_Click(object sender, EventArgs e)
        {
            backButtonFunction();
        }

        public void clearButton_Click(object sender, EventArgs e)
        {
            clearButtonFunction();
        }

        public void clearElementButton_Click(object sender, EventArgs e)
        {
            clearElementButtonFunction();
        }

        public void powerButton_Click(object sender, EventArgs e)
        {
            powerButtonFunction();
        }

        public void sqrtButton_Click(object sender, EventArgs e)
        {
            sqrtButtonFunction();
        }

        public void reverseButton_Click(object sender, EventArgs e)
        {
            reverseButtonFunction();
        }

        public void percentButton_Click(object sender, EventArgs e)
        {
            addActionSymbol('%');
        }



        private void oneButton_Click(object sender, EventArgs e)
        {
            addNumber("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            addNumber("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            addNumber("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            addNumber("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            addNumber("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            addNumber("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            addNumber("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            addNumber("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            addNumber("9");
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            addNumber("0");
        }

        private void resultTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            resultTextBox.Text = null;
        }

        /// <summary>
        /// Metoda określająca dozowolone znaki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTextBoxes_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case (Keys.NumPad0):
                    {
                        addNumber("0");
                    }
                    break;
                case (Keys.NumPad1):
                    {
                        addNumber("1");
                    }
                    break;
                case (Keys.NumPad2):
                    {
                        addNumber("2");
                    }
                    break;
                case (Keys.NumPad3):
                    {
                        addNumber("3");
                    }
                    break;
                case (Keys.NumPad4):
                    {
                        addNumber("4");
                    }
                    break;
                case (Keys.NumPad5):
                    {
                        addNumber("5");
                    }
                    break;
                case (Keys.NumPad6):
                    {
                        addNumber("6");
                    }
                    break;
                case (Keys.NumPad7):
                    {
                        addNumber("7");
                    }
                    break;
                case (Keys.NumPad8):
                    {
                        addNumber("8");
                    }
                    break;
                case (Keys.NumPad9):
                    {
                        addNumber("9");
                    }
                    break;
                case (Keys.Enter):
                    {
                        equalButtonFunction();
                    }
                    break;
                case (Keys.Subtract):
                    {
                        addActionSymbol('-');
                    }
                    break;
                case (Keys.Multiply):
                    {
                        addActionSymbol('*');
                    }
                    break;
                case (Keys.Add):
                    {
                        addActionSymbol('+');
                    }
                    break;
                case (Keys.Divide):
                    {
                        addActionSymbol('/');
                    }
                    break;
                case (Keys.Decimal):
                    {
                        commaButtonFunction();
                    }
                    break;
                case (Keys.Back):
                    {
                        backButtonFunction();
                    }
                    break;
                case (Keys.Delete):
                    {
                        clearElementButtonFunction();
                    }
                    break;
                case (Keys.End):
                    {
                        clearButtonFunction();
                    }
                    break;
                case (Keys.PageUp):
                    {
                        powerButtonFunction();
                    }
                    break;
                case (Keys.PageDown):
                    {
                        sqrtButtonFunction();
                    }
                    break;
                case (Keys.Home):
                    {
                        addActionSymbol('%');
                    }
                    break;
                case (Keys.Insert):
                    {
                        reverseButtonFunction();
                    }
                    break;
                case (Keys.Pause):
                    {
                        signChangeButtonFunction();
                    }
                    break;


            }

        }
    }
}
