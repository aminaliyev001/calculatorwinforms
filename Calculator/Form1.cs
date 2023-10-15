namespace Calculator
{
    public partial class Form1 : Form
    {
        private double fnumber = 0;
        private double tempn = 0;
        private string sign;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            fnumber = 0;
            tempn = 0;
            sign = null;
        }
        private void number_click(int num)
        {
            label2.Text += num.ToString();
        }
        private void operator_click(string s)
        {
            tempn = Convert.ToDouble(label2.Text);

            if (sign != null)
            {
                Operation_func();
                label2.Text = fnumber.ToString();
            }
            else
            {
                fnumber = tempn;
            }

            sign = s;
            label2.Text = "";

        }
        private void button19_Click(object sender, EventArgs e)
        {
            number_click(0);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            number_click(1);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            number_click(2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number_click(3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number_click(4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number_click(5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number_click(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number_click(7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number_click(8);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number_click(9);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operator_click("+");
        }
        private void Operation_func()
        {
            switch (sign)
            {
                case "+":
                    fnumber += tempn;
                    break;
                case "-":
                    fnumber -= tempn;
                    break;
                case "*":
                    fnumber *= tempn;
                    break;
                case "/":
                    if (tempn == 0)
                    {
                        MessageBox.Show("0-a bolune bilmez.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label2.Text = "";
                        return;
                    }
                    fnumber /= tempn;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operator_click("-");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operator_click("*");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operator_click("/");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tempn = Convert.ToDouble(label2.Text);

            if (sign != null)
            {
                Operation_func();
                label2.Text = fnumber.ToString();
                sign = null;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(label2.Text))
                    label2.Text = "0.";
                else
                    label2.Text += ".";
            }
        }
    }
}