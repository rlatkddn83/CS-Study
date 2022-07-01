namespace Project1
{
    public partial class Calculator : Form
    {

        private List<double> var = new List<double>();
        private List<int> operate = new List<int>();
        private bool eq = false;
        // 1:Plus, 2:Minus, 3:Multi, 4:Divide

        private double result = 0;

        

        public Calculator()
        {
            InitializeComponent();
        }

        public void Init()
        {
            txtView.Text = "";
            txtResult.Text = "0";
            eq = false;
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();
            var.Add(double.Parse(txtResult.Text));
            txtView.Text += txtResult.Text + btnEq.Text;
            
            for (int i = 0; i < var.Count; i++)
            {
                if (i==0)
                {
                    result = var[i];
                    continue;
                }
                switch (operate[i-1])
                { 
                    case 1:
                        result += var[i];
                        break;
                    case 2:
                        result -= var[i];
                        break;
                    case 3:
                        result *= var[i];
                        break;
                    case 4:
                        result /= var[i];
                        break;
                }
            }
            double x = Math.Round(result, 10);
            txtResult.Text = x.ToString();
            var = new List<double>();
            operate = new List<int>();
            eq = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "1";
            else
                txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "2";
            else
                txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "3";
            else
                txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "4";
            else
                txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "5";
            else
                txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "6";
            else
                txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "7";
            else
                txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "8";
            else
                txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "9";
            else
                txtResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            if (txtResult.Text == "0")
                txtResult.Text = "0";
            else
                txtResult.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();
            if(!txtResult.Text.ToString().Contains("."))
                txtResult.Text += ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                txtResult.Text = txtResult.Text;
                txtView.Text = txtResult.Text;
                eq = false;
            }
            var.Add(double.Parse(txtResult.Text));
            operate.Add(1);
            txtView.Text += txtResult.Text + btnPlus.Text;
            txtResult.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                txtResult.Text = txtResult.Text;
                txtView.Text = txtResult.Text;
                eq = false;
            }
            var.Add(double.Parse(txtResult.Text));
            operate.Add(2);
            txtView.Text += txtResult.Text + btnMinus.Text;
            txtResult.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                txtResult.Text = txtResult.Text;
                txtView.Text = txtResult.Text;
                eq = false;
            }
            var.Add(double.Parse(txtResult.Text));
            operate.Add(3);
            txtView.Text += txtResult.Text + btnMulti.Text;
            txtResult.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                txtResult.Text = txtResult.Text;
                txtView.Text = txtResult.Text;
                eq = false;
            }
            var.Add(double.Parse(txtResult.Text));
            operate.Add(4);
            txtView.Text += txtResult.Text + btnDivide.Text;
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();
            txtResult.Text = "0";
        }

        private void btnBacksplace_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            string temp = txtResult.Text;
            if (temp.Length == 1)
            {
                if (temp != "0")
                {
                    temp = "0";
                }
            }
            else if (temp.Length > 1)
                temp = temp.Substring(0, temp.Length - 1);
            txtResult.Text = temp;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();

            double x = double.Parse(txtResult.Text.ToString()) / 100;
            txtResult.Text = x.ToString();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();
            double x = double.Parse(txtResult.Text.ToString());
            if (x!=0)
                txtResult.Text = (1.0/x).ToString();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (eq)
                Init();
            double x = double.Parse(txtResult.Text.ToString());
            txtResult.Text = (x * x).ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtResult.Text.ToString());
            double y = 1;
            while (Math.Round(y*y,10)!=x)
            {
                y = (y + (x / y))/2;
                Console.WriteLine("{0}, {1}, {2}", y, y * y, x);
            }
            y = Math.Round(y, 10);
            txtResult.Text = y.ToString();
        }
    }
} 