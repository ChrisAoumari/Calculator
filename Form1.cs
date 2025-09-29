using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Askisi4
{
    public partial class Form1 : Form
    {
        public string symbol;
        public Form1()
        {
            InitializeComponent();
            this.Text="Calculator";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (symbol == "=")
            {
                textBox1.Clear();
                symbol = " ";
            }
            if (textBox1.Text.Length != 0 )
            textBox1.AppendText("0");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            textBox1.AppendText("0,");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            symbol = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
                textBox1.AppendText("+");
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("-");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("/");
        }

        private void button19_Click(object sender, EventArgs e)
        {

            try
            {
                string expression = textBox1.Text.Replace(",", "."); // decimal dot
                var result = new System.Data.DataTable().Compute(expression, null);
                textBox1.Text = result.ToString();
                symbol = "=";
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("(");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(")");
        }
    }
}
