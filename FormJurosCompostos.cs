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
    public partial class FormJurosCompostos : Form
    {
        int botao;
        public FormJurosCompostos()
        {
            InitializeComponent();
            comboBoxMeses.Text = "ao mês";
            comboBox2.Text = "meses";
        }

        private void FormJurosCompostos_Load(object sender, EventArgs e)
        {

        }







        private void button0_Click(object sender, EventArgs e)
        {
            botao = 0;
            adbotao();
        }

        private void button1_Click(object sender, EventArgs e)
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
            botao = 6;
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
            else if (checkBox4.Checked == true)
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = $"{botao}";
                }
                else
                {
                    labelMeses.Text += $"{botao}";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = $"{botao}";
                }
                else
                {
                    labelPeriodo.Text += $"{botao}";
                }
            }
            botao = 0;
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
                if (labelMeses.Text.Length > 1)
                    labelMeses.Text = labelMeses.Text.Substring(0, labelMeses.Text.Length - 1);
                else
                {
                    labelMeses.Text = "0";
                }
            }
            else if (checkBox3.Checked == true)
            {

                if (labelJuros.Text.Length > 1)
                    labelJuros.Text = labelJuros.Text.Substring(0, labelJuros.Text.Length - 1);
                else
                {
                    labelJuros.Text = "0";
                }
            }
            else if (checkBox4.Checked == true)
            {

                if (labelPeriodo.Text.Length > 1)
                    labelPeriodo.Text = labelPeriodo.Text.Substring(0, labelPeriodo.Text.Length - 1);
                else
                {
                    labelPeriodo.Text = "0";
                }
            }
            calcular();
        }
        

        

        

        

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }
        private void labelInicial_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }
        private void labelMeses_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }
        private void labelJuros_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }
        private void labelPeriodo_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void comboBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcular();
        }










        private void calcular()
        {
            double periodo = 0;
            double pc = 0;
            switch (comboBoxMeses.Text)
            {
                case "ao mês": pc = double.Parse(labelJuros.Text); break;
                case "ao ano": pc = double.Parse(labelJuros.Text) / 12; break;
                default: comboBoxMeses.Text = "meses"; break;
            }
            switch (comboBox2.Text)
            {
                case "meses": periodo = double.Parse(labelPeriodo.Text); break;
                case "anos": periodo = double.Parse(labelPeriodo.Text) * 12; break;
                default: comboBox2.Text = "meses"; break;
            }
            


            double acumular = double.Parse(labelInicial.Text);

            for (var i = periodo; i > 0; i--)
                {
                    acumular += pc * (acumular / 100);
                    acumular += double.Parse(labelMeses.Text);
                }
            labelResultado.Text = acumular.ToString("C2");
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}