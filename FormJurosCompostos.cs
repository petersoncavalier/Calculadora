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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "0";
                }
                else
                {
                    labelMeses.Text += "0";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "0";
                }
                else
                {
                    labelPeriodo.Text += "0";
                }
            }
            calcular();
        }

        private void button1_Click(object sender, EventArgs e)
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "1";
                }
                else
                {
                    labelMeses.Text += "1";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "1";
                }
                else
                {
                    labelPeriodo.Text += "1";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "2";
                }
                else
                {
                    labelMeses.Text += "2";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "2";
                }
                else
                {
                    labelPeriodo.Text += "2";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "3";
                }
                else
                {
                    labelMeses.Text += "3";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "3";
                }
                else
                {
                    labelPeriodo.Text += "3";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "4";
                }
                else
                {
                    labelMeses.Text += "4";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "4";
                }
                else
                {
                    labelPeriodo.Text += "4";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "5";
                }
                else
                {
                    labelMeses.Text += "5";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "5";
                }
                else
                {
                    labelPeriodo.Text += "5";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "6";
                }
                else
                {
                    labelMeses.Text += "6";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "6";
                }
                else
                {
                    labelPeriodo.Text += "6";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "7";
                }
                else
                {
                    labelMeses.Text += "7";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "7";
                }
                else
                {
                    labelPeriodo.Text += "7";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "8";
                }
                else
                {
                    labelMeses.Text += "8";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "8";
                }
                else
                {
                    labelPeriodo.Text += "8";
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

                if (labelMeses.Text == "0")
                {
                    labelMeses.Text = "9";
                }
                else
                {
                    labelMeses.Text += "9";
                }
            }
            else if (checkBox3.Checked == true)
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
            else if (checkBox4.Checked == true)
            {
                if (labelPeriodo.Text == "0")
                {
                    labelPeriodo.Text = "9";
                }
                else
                {
                    labelPeriodo.Text += "9";
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
            else if (checkBox4.Checked == true)
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}