using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoravisual
{
    public partial class Moedas : Form
    {
        public Moedas()
        {
            double moeda1 = 0;
            double moeda2 = 0;
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "0";
            }
            else
            {
                labelEntrada.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "1";
            }
            else
            {
                labelEntrada.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "2";
            }
            else
            {
                labelEntrada.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "3";
            }
            else
            {
                labelEntrada.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "4";
            }
            else
            {
                labelEntrada.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "5";
            }
            else
            {
                labelEntrada.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "6";
            }
            else
            {
                labelEntrada.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "7";
            }
            else
            {
                labelEntrada.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "8";
            }
            else
            {
                labelEntrada.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text == "0")
            {
                labelEntrada.Text = "9";
            }
            else
            {
                labelEntrada.Text += "9";
            }
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
                labelEntrada.Text += ",";
        }








        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text.Length > 1)
                labelEntrada.Text = labelEntrada.Text.Substring(0, labelEntrada.Text.Length - 1);
            else
            {
                labelEntrada.Text = "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelEntrada.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Real")
            {

            }
        }
    }
}
