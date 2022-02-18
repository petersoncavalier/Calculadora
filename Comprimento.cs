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
    public partial class Comprimento : Form
    {
        double acumular = 0;
        bool att;

        public Comprimento()
        {
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
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
            recalcular();
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
                labelEntrada.Text = ",";
            recalcular();
        }











        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (labelEntrada.Text.Length > 1)
                labelEntrada.Text = labelEntrada.Text.Substring(0, labelEntrada.Text.Length - 1);
            else
            {
                labelEntrada.Text = "0";
            }
            recalcular();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelEntrada.Text = "0"; 
            recalcular();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            recalcular();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            recalcular();
        }



        private void recalcular() 
        {
            if (comboBox1.Text == "Milimetros")
            {
                if (comboBox2.Text == "Milimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Centimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular / 10;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Metros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular / 1000;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Quilometros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular / 100000000;
                    labelSaida.Text = acumular.ToString();
                }
            }

            if (comboBox1.Text == "Centimetros")
            {
                if (comboBox2.Text == "Milimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular * 10;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Centimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Metros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular / 100;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Quilometros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular / 100000;
                    labelSaida.Text = acumular.ToString();
                }
            }

            if (comboBox1.Text == "Metros")
            {
                if (comboBox2.Text == "Milimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular * 1000;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Centimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular * 100;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Metros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Quilometros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular / 1000;
                    labelSaida.Text = acumular.ToString();
                }
            }

            if (comboBox1.Text == "Quilometros")
            {
                if (comboBox2.Text == "Milimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular * 1000000;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Centimetros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular * 100000;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Metros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    acumular = acumular * 1000;
                    labelSaida.Text = acumular.ToString();
                }
                if (comboBox2.Text == "Quilometros")
                {
                    acumular = double.Parse(labelEntrada.Text);
                    labelSaida.Text = acumular.ToString();
                }

            }
        }
    }
}
