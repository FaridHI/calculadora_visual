using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacion = "";
        private string lblOperacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //numero 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //numero 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //numero 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacion = "SUMA";
            lblOperacion = "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //numero 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //numero 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //numero 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacion = "RESTA";
            lblOperacion = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //numero 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //numero 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //numero 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacion = "MULTI";
            lblOperacion = "x";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //numero 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            if (operacion == "SUMA")
            {
                textBox1.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacion == "RESTA")
            {
                textBox1.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacion == "MULTI")
            {
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textBox1.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacion = "DIVI";
            lblOperacion = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //punto
            textBox1.Text = textBox1.Text + ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}