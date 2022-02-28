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
    public partial class FormJurosSimples : Form
    {
        public FormJurosSimples()
        {
            InitializeComponent();
        }











        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }








        private void button0_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "0";
                }
                else
                {
                    labelInicial.Text += "0";
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "0";
                }
                else
                {
                    labelJuros.Text += "0";
                }
            }
            else if (checkBox3.Checked == true)
            {
                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "0";
                }
                else
                {
                    labelMeses.Text += "0";
                }
            }
            calcular();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "1";
                }
                else
                {
                    labelInicial.Text += "1";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "1";
                }
                else
                {
                    labelJuros.Text += "1";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "1";
                }
                else
                {
                    labelMeses.Text += "1";
                }
            }
            calcular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "2";
                }
                else
                {
                    labelInicial.Text += "2";
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "2";
                }
                else
                {
                    labelJuros.Text += "2";
                }
            }
            else if (checkBox3.Checked == true)
            {
                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "2";
                }
                else
                {
                    labelMeses.Text += "2";
                }
            }
            calcular();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "3";
                }
                else
                {
                    labelInicial.Text += "3";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "3";
                }
                else
                {
                    labelJuros.Text += "3";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "3";
                }
                else
                {
                    labelMeses.Text += "3";
                }
            }
            calcular();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "4";
                }
                else
                {
                    labelInicial.Text += "4";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "4";
                }
                else
                {
                    labelJuros.Text += "4";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "4";
                }
                else
                {
                    labelMeses.Text += "4";
                }
            }
            calcular();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "5";
                }
                else
                {
                    labelInicial.Text += "5";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "5";
                }
                else
                {
                    labelJuros.Text += "5";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "5";
                }
                else
                {
                    labelMeses.Text += "5";
                }
            }
            calcular();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "6";
                }
                else
                {
                    labelInicial.Text += "6";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "6";
                }
                else
                {
                    labelJuros.Text += "6";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "6";
                }
                else
                {
                    labelMeses.Text += "6";
                }
            }
            calcular();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "7";
                }
                else
                {
                    labelInicial.Text += "7";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "7";
                }
                else
                {
                    labelJuros.Text += "7";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "7";
                }
                else
                {
                    labelMeses.Text += "7";
                }
            }
            calcular();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "8";
                }
                else
                {
                    labelInicial.Text += "8";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "8";
                }
                else
                {
                    labelJuros.Text += "8";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "8";
                }
                else
                {
                    labelMeses.Text += "8";
                }
            }
            calcular();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = "9";
                }
                else
                {
                    labelInicial.Text += "9";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = "9";
                }
                else
                {
                    labelJuros.Text += "9";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "9";
                }
                else
                {
                    labelMeses.Text += "9";
                }
            }
            calcular();
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                labelInicial.Text += ",";
            }
            else if (checkBox2.Checked == true)
            {

                labelJuros.Text += ",";
            }
            else if (checkBox3.Checked == true)
            {

                labelMeses.Text += ",";
            }
            calcular();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text.Length > 1)
                    labelInicial.Text = labelInicial.Text.Substring(0, labelInicial.Text.Length - 1);
                else
                {
                    labelInicial.Text = "0";
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (labelJuros.Text.Length > 1)
                    labelJuros.Text = labelJuros.Text.Substring(0, labelJuros.Text.Length - 1);
                else
                {
                    labelJuros.Text = "0";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text.Length > 1)
                    labelMeses.Text = labelMeses.Text.Substring(0, labelMeses.Text.Length - 1);
                else
                {
                    labelMeses.Text = "0";
                }
            }
            calcular();
        }











        private void labelInicial_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void labelJuros_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void labelMeses_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void calcular()
        {
            double inicial = double.Parse(labelInicial.Text);
            double pc = double.Parse(labelJuros.Text) * (inicial / 100);
            pc = inicial + (pc * double.Parse(labelMeses.Text));
            labelResultado.Text = pc.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void FormJurosSimples_Load(object sender, EventArgs e)
        {

        }
    }
}
