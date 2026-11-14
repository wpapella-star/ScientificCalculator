namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double lastAnswer = 0;
        double firstNumber = 0;
        double secondNumber = 0;

        string operation = "";

        bool isNewNumber = true;
        bool isDegreeMode = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string number = button.Text;

            if (isNewNumber)
            {
                txtDisplay.Text = number;

                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += number;
            }
        }


        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(txtDisplay.Text);

            operation = button.Text;

            txtHistory.Text = firstNumber + " " + operation;

            isNewNumber = true;
        }


        private void EqualsButton_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(txtDisplay.Text);

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;

                case "^":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;

                default:
                    MessageBox.Show("Invalid operator.");
                    return;
            }

            txtHistory.Text = firstNumber + " " + operation + " " + secondNumber + " =";

            txtDisplay.Text = result.ToString();
            lastAnswer = result;

            isNewNumber = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            txtHistory.Text = "";

            firstNumber = 0;
            secondNumber = 0;

            operation = "";

            isNewNumber = true;
        }


        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (isNewNumber)
            {
                txtDisplay.Text = "0.";
                isNewNumber = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }


        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(
                    0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            number = -number;

            txtDisplay.Text = number.ToString();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double result = Math.Pow(number, 2);

            txtDisplay.Text = result.ToString();

            txtHistory.Text = number + "²";
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            if (number < 0)
            {
                MessageBox.Show("Cannot calculate square root of a negative number.");
                return;
            }

            double result = Math.Sqrt(number);

            txtDisplay.Text = result.ToString();

            txtHistory.Text = "√" + number;
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            isDegreeMode = !isDegreeMode;

            if (isDegreeMode)
            {
                btnMode.Text = "DEG";
            }
            else
            {
                btnMode.Text = "RAD";
            }
        }


        private void SinButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double angle;

            if (isDegreeMode)
            {
                angle = number * Math.PI / 180;
            }
            else
            {
                angle = number;
            }

            double result = Math.Sin(angle);

            txtHistory.Text = "sin(" + number + ")";

            txtDisplay.Text = result.ToString();

            isNewNumber = true;
        }


        private void CosButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double angle;

            if (isDegreeMode)
            {
                angle = number * Math.PI / 180;
            }
            else
            {
                angle = number;
            }

            double result = Math.Cos(angle);

            txtHistory.Text = "cos(" + number + ")";

            txtDisplay.Text = result.ToString();

            isNewNumber = true;
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double angle;

            if (isDegreeMode)
            {
                angle = number * Math.PI / 180;
            }
            else
            {
                angle = number;
            }

            double result = Math.Tan(angle);

            txtHistory.Text = "tan(" + number + ")";

            txtDisplay.Text = result.ToString();

            isNewNumber = true;
        }


        private void LogButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            if (number <= 0)
            {
                MessageBox.Show("Logarithm requires a positive number.");
                return;
            }

            double result = Math.Log10(number);

            txtHistory.Text = "log(" + number + ")";

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void LnButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            if (number <= 0)
            {
                MessageBox.Show("Natural logarithm requires a positive number.");
                return;
            }

            double result = Math.Log(number);

            txtHistory.Text = "ln(" + number + ")";

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void CubeButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double result = Math.Pow(number, 3);

            txtHistory.Text = number + "³";

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void CubeRootButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double result = Math.Cbrt(number);

            txtHistory.Text = "∛(" + number + ")";

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            if (number == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return;
            }

            double result = 1 / number;

            txtHistory.Text = "1/(" + number + ")";

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            if (number < 0 || number != Math.Floor(number))
            {
                MessageBox.Show("Factorial requires a non-negative integer.");
                return;
            }

            if (number > 170)
            {
                MessageBox.Show("Number is too large.");
                return;
            }

            double result = 1;

            for (int i = 1; i <= (int)number; i++)
            {
                result *= i;
            }

            txtHistory.Text = number + "!";

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void EulerButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.E.ToString("G10");

            txtHistory.Text = "e";

            isNewNumber = true;
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);

            operation = "^";

            txtHistory.Text = firstNumber + "^";

            isNewNumber = true;
        }

        private void PowerOfTenButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double result = Math.Pow(10, number);

            txtHistory.Text = "10^" + number;

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void PowerOfTwoButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtDisplay.Text);

            double result = Math.Pow(2, number);

            txtHistory.Text = "2^" + number;

            txtDisplay.Text = result.ToString("G10");

            isNewNumber = true;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = lastAnswer.ToString("G10");

            isNewNumber = false;
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            EqualsButton_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            DecimalButton_Click(sender, e);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            BackspaceButton_Click(sender, e);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            SignButton_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SquareButton_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SquareRootButton_Click(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SinButton_Click(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CosButton_Click(sender, e);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TanButton_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            LogButton_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LnButton_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CubeButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CubeRootButton_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReciprocalButton_Click(sender, e);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FactorialButton_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EulerButton_Click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PowerButton_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PowerOfTenButton_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PowerOfTwoButton_Click(sender, e);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            AnswerButton_Click(sender, e);
        }
    }
}
