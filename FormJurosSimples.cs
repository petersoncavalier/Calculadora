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
        int botao = 0;
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
            botao = 0;
            adbotao();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            botao = 1;
            adbotao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            botao = 2;
            adbotao();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            botao = 3;
            adbotao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            botao = 4;
            adbotao();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            botao = 5;
            adbotao();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            botao = 6;
            adbotao();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            botao = 7;
            adbotao();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            botao = 8;
            adbotao();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            botao = 9;
            adbotao();
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

        private void adbotao()
        {
            if (checkBox1.Checked == true)
            {
                if (labelInicial.Text == "0")
                {
                    labelInicial.Text = $"{botao}";
                }
                else
                {
                    labelInicial.Text += $"{botao}";
                }
            }
            else if (checkBox2.Checked == true)
            {

                if (labelJuros.Text == "0")
                {
                    labelJuros.Text = $"{botao}";
                }
                else
                {
                    labelJuros.Text += $"{botao}";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = $"{botao}";
                }
                else
                {
                    labelMeses.Text += $"{botao}";
                }
            }
            calcular();
            botao = 0;
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
            labelResultado.Text = pc.ToString("C2");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
