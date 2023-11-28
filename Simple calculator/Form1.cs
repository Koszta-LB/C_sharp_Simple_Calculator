using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_calculator
{
    public partial class Form1 : Form
    {
        public string number = "0";
        public string calcnumber = "0";
        public int interaction = 0;
        // if interaction = 1 -> +
        // if interaction = 2 -> -
        // if interaction = 3 -> *
        // if interaction = 4 -> /
        public Form1()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            richTextBox1.Text = number;
        }
        public string square(string num)
        {
            double temp = double.Parse(num);
            return (temp * temp).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Initializating
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "/";
            button11.Text = "*";
            button12.Text = "-";
            button13.Text = "+";
            button14.Text = ".";
            button15.Text = "0";
            button16.Text = "C";
            button17.Text = "x^2";
            button18.Text = "=";
            button19.Text = "+ / -";
            refresh();
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(number == "0")
            {
                number = "1";
            }
            else
            {
                number += "1";
            }
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "2";
            }
            else
            {
                number += "2";
            }
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "3";
            }
            else
            {
                number += "3";
            }
            refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "4";
            }
            else
            {
                number += "4";
            }
            refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "5";
            }
            else
            {
                number += "5";
            }
            refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "6";
            }
            else
            {
                number += "6";
            }
            refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "7";
            }
            else
            {
                number += "7";
            }
            refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "8";
            }
            else
            {
                number += "8";
            }
            refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (number == "0")
            {
                number = "9";
            }
            else
            {
                number += "9";
            }
            refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (number != "0")
            {
                number += "0";
            }
            refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!number.Contains("."))
            {
                number += ".";
            }
            refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number = "0";
            refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number = square(number);
            refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // /
            calcnumber = number;
            number = "0";
            interaction = 4;
            refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // *
            calcnumber = number;
            number = "0";
            interaction = 3;
            refresh();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // -
            calcnumber = number;
            number = "0";
            interaction = 2;
            refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // +
            calcnumber = number;
            number = "0";
            interaction = 1;
            refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // =
            // if interaction = 1 -> +
            // if interaction = 2 -> -
            // if interaction = 3 -> *
            // if interaction = 4 -> /
            if (interaction == 1)
            {
                double temp = double.Parse(calcnumber) + double.Parse(number);
                number = temp.ToString();
                calcnumber = "0";
            } 
            else if (interaction == 2)
            {
                double temp = double.Parse(calcnumber) - double.Parse(number);
                number = temp.ToString();
                calcnumber = "0";
            }
            else if (interaction == 3)
            {
                double temp = double.Parse(calcnumber) * double.Parse(number);
                number = temp.ToString();
                calcnumber = "0";
            }
            else if (interaction == 4)
            {
                double temp = double.Parse(calcnumber) / double.Parse(number);
                number = temp.ToString();
                calcnumber = "0";
            }
            refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            number = (double.Parse(number) * -1).ToString();
            refresh();
        }
    }
}
