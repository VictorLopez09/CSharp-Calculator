namespace CSharp_Calculator
{
    public partial class frmCalculator : Form
    {
        double number1 = 0;
        double number2 = 0;
        string operation = "";
        bool isNewNumber = true;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewNumber = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = "0";
            number1 = 0;
            number2 = 0;
            operation = "";
            isNewNumber = true;
        }
        private void btn0_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtDisplay.Text == "0" || isNewNumber)
            {
                txtDisplay.Text = "";
                isNewNumber = false;
            }

            txtDisplay.Text += btn.Text;
        }


        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            number2 = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result = number1 / number2;
                    break;
            }

            txtDisplay.Text = result.ToString();
            isNewNumber = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewNumber = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewNumber = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewNumber = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            number1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewNumber = true;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewNumber = true;
        }
    }
}
