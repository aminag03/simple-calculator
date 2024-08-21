namespace Simple_Calculator
{
    public partial class SimpleCalculator : Form
    {
        private double number = 0;
        private string operation = "";
        private string lastInput = "";

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void Operation(string op)
        {
            if (lastInput == "+" || lastInput == "-" || lastInput == "*" || lastInput == "/")
            {
                operation = op;
                lastInput = operation;
                lblCache.Text = number.ToString() + operation;
                txtResult.Text = "0";
                return;
            }

            if (txtResult.Text.Length > 0)
                number = double.Parse(txtResult.Text);

            if (lblCache.Text.Contains("+") || lblCache.Text.Contains("-") ||
                lblCache.Text.Contains("*") || lblCache.Text.Contains("/"))
            {
                var cacheNumber = lblCache.Text.Substring(0, lblCache.Text.Length - 1);
                Calculate(double.Parse(cacheNumber), double.Parse(txtResult.Text));
            }
            
            operation = op;
            lastInput = operation;
            lblCache.Text = number.ToString() + operation;
            txtResult.Text = "0";
        }
        
        private void Calculate(double firstNum, double secondNum)
        {
            if (operation == "+")
            {
                txtResult.Text = Convert.ToString(firstNum + secondNum);
                number = double.Parse(txtResult.Text);
            }
            else if (operation == "-")
            {
                txtResult.Text = Convert.ToString(firstNum - secondNum);
                number = double.Parse(txtResult.Text);
            }
            else if (operation == "*")
            {
                txtResult.Text = Convert.ToString(firstNum * secondNum);
                number = double.Parse(txtResult.Text);
            }
            else if (operation == "/")
            {
                if (double.Parse(txtResult.Text) == 0)
                    MessageBox.Show("You cannot divide by zero!");
                else
                {
                    txtResult.Text = Convert.ToString(firstNum / secondNum);
                    number = double.Parse(txtResult.Text);
                }
            }

            operation = "";
            lblCache.Text = number.ToString();
        }

        private void numberClick(Button number)
        {
            if (txtResult.Text == "0")
                txtResult.Text = number.Text;
            else
                txtResult.Text += number.Text;

            lastInput = number.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numberClick(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numberClick(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numberClick(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numberClick(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numberClick(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numberClick(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numberClick(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numberClick(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numberClick(btn9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numberClick(btn0);
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            if (!(txtResult.Text.Contains(",")))
            {
                txtResult.Text += ",";
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                return;

            if (txtResult.Text != "")
            {
                if (txtResult.Text.Substring(0, 1) == "-")
                {
                    txtResult.Text = txtResult.Text.Remove(0, 1);
                }
                else
                {
                    txtResult.Text = $"-{txtResult.Text}";
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double.Parse(lastInput);
            }
            catch
            {
                txtResult.Text = number.ToString();
                lblCache.Text = number.ToString();
                return;
            }

            if (txtResult.Text.Count() > 0)
                Calculate(number, double.Parse(txtResult.Text));
        }

        private void btnDeleteLastInput_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblCache.Text = "";
            number = 0;
        }

        private void btnRemoveLastDigit_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Count() == 1)
                txtResult.Text = "0";
            else if (txtResult.Text.Count() == 2 && txtResult.Text.Contains("-"))
                txtResult.Text = "0";
            else if (txtResult.Text != "")
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
        }

        private void SimpleCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn0_Click(sender, e);
                    break;
                case '1':
                    btn1_Click(sender, e);
                    break;
                case '2':
                    btn2_Click(sender, e);
                    break;
                case '3':
                    btn3_Click(sender, e);
                    break;
                case '4':
                    btn4_Click(sender, e);
                    break;
                case '5':
                    btn5_Click(sender, e);
                    break;
                case '6':
                    btn6_Click(sender, e);
                    break;
                case '7':
                    btn7_Click(sender, e);
                    break;
                case '8':
                    btn8_Click(sender, e);
                    break;
                case '9':
                    btn9_Click(sender, e);
                    break;
                case '\b':
                    btnRemoveLastDigit_Click(sender, e);
                    break;
                case '\r':
                    btnEquals_Click(sender, e);
                    break;
                case '+':
                    btnPlus_Click(sender, e);
                    break;
                case '-':
                    btnMinus_Click(sender, e);
                    break;
                case '*':
                    btnMultiply_Click(sender, e);
                    break;
                case '/':
                    btnDivide_Click(sender, e);
                    break;
                case ',':
                    btnDecimalPoint_Click(sender, e);
                    break;
            }
        }
    }
}
