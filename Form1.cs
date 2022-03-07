using System.Diagnostics;

namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        private bool Operator = false;
        private string[] myArray = new string[] { };
        private string num = "";
        private int value = 0;
        private bool plus = false;
        private bool minus = false;

        private void check(string i)
        {
            Array.Resize(ref myArray, myArray.Length + 1);
            myArray[myArray.GetUpperBound(0)] = i;
        }

        private void check1()
        {
            foreach (string values in myArray)
            {
                if (plus)
                {
                    if (values == "+")
                    {
                        plus = false;
                        break;
                    }
                    value += int.Parse(values);
                    plus = false;
                    continue;
                }

                if (minus)
                {
                    if (values == "-")
                    {
                        minus = false;
                        break;
                    }
                    value -= int.Parse(values);
                    minus = false;
                    continue;
                }

                if (values == "+")
                {
                    plus = true;
                    continue;
                }

                if (values == "-")
                {
                    minus = true;
                    continue;
                }

                value = int.Parse(values);
            }
            Console.WriteLine(value);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            form.Text = "°è»ê±â";
            KeyPreview = true;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num += 0;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button1_Click(object sender, EventArgs e) // 1
        {
            num += 1;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e) // 2
        {
            num += 2;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e) // 3
        {
            num += 3;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button4_Click(object sender, EventArgs e) // 4
        {
            num += 4;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            num += 5;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e) // 6
        {
            num += 6;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e) // 7
        {
            num += 7;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e) // 8
        {
            num += 8;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e) // 9
        {
            num += 9;
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button10_Click(object sender, EventArgs e) // = (result)
        {
            /*if (Operator)
            {
                return;
            }
            Operator = true;
            Button button = (Button)sender;*/
            check(num);
            //Console.WriteLine(string.Join(",", myArray));
            check1();
            myArray = new string[] { };
            //Console.WriteLine(string.Join(",", myArray));
            num = "";
            Operator = false;
            //check(value.ToString());
            num += value.ToString();
            textBox1.Text = value.ToString();
            textBox2.Text = value.ToString();
            value = 0;
        }

        private void button11_Click(object sender, EventArgs e) // +
        {
            if (Operator)
            {
                return;
            }
            check(num);
            check("+");
            num = "";
            Operator = true;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button12_Click(object sender, EventArgs e) // -
        {
            if (Operator)
            {
                return;
            }
            check(num);
            check("-");
            num = "";
            Operator = true;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // input
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // output
        {

        }

        private void button14_Click(object sender, EventArgs e) // .
        {
            num += ".";
            Operator = false;
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button15_Click(object sender, EventArgs e) // ?
        {

        }

        private void button16_Click(object sender, EventArgs e) // c
        {
            myArray = new string[] { };
            num = "";
            value = 0;
            Operator = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}