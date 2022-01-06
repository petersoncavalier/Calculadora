namespace calculadoravisual
{
    public partial class Form1 : Form
    {
        double acumular;
        string operacao;
        double c;

        public Form1()
        {
            InitializeComponent();
            labelAcumular.Text = "";
            labelC.Text = "";
        }








        private void button0_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "0";
            }
            else
            {
                labelResultado.Text += "0";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "1";
            }
            else
            {
                labelResultado.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "2";
            }
            else
            {
                labelResultado.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "3";
            }
            else
            {
                labelResultado.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "4";
            }
            else
            {
                labelResultado.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "5";
            }
            else
            {
                labelResultado.Text += "5";
            }  
                
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "6";
            }
            else
            {
                labelResultado.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "7";
            }
            else
            {
                labelResultado.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "8";
            }
            else
            {
                labelResultado.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = "9";
            }
            else
            {
                labelResultado.Text += "9";
            }
        }
        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            labelResultado.Text += ",";
        }








        private void buttonSoma_Click(object sender, EventArgs e)
        {   
            acumular += double.Parse(labelResultado.Text);
            operacao = "+";
            labelAcumular.Text = acumular.ToString() + " + ";
            labelResultado.Text = "0";
        }
        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            acumular += double.Parse(labelResultado.Text);
            operacao = "-";
            labelAcumular.Text = acumular.ToString() + " - ";
            labelResultado.Text = "0";
        }
        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            acumular += double.Parse(labelResultado.Text);
            operacao = "*";
            labelAcumular.Text = acumular.ToString() + " * ";
            labelResultado.Text = "0";
        }
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            acumular += double.Parse(labelResultado.Text);
            operacao = "/";
            labelAcumular.Text = acumular.ToString() + " / ";
            labelResultado.Text = "0";
        }
        private void buttonPercentual_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(labelResultado.Text);
            double resultado = (valor1 * acumular) / 100;
            if (operacao == "+")
            {
                acumular += resultado;
                labelAcumular.Text += resultado.ToString() + "% = ";
                labelResultado.Text = "0";
            }
            else if (operacao == "-")
            {
                acumular -= resultado;
                labelAcumular.Text += resultado.ToString() + "% = ";
                labelResultado.Text = "0";
            }
            else if (operacao == "*")
            {
                acumular *= resultado;
                labelAcumular.Text += resultado.ToString() + "% = ";
                labelResultado.Text = "0";
            }
            else if (operacao == "/")
            {
                acumular /= resultado;
                labelAcumular.Text += resultado.ToString() + "% = ";
                labelResultado.Text = "0";
            }
            labelResultado.Text = acumular.ToString();
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumular = acumular + double.Parse(labelResultado.Text);
                labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
                labelResultado.Text = acumular.ToString();
                operacao = "";
                acumular = 0;
            }
            else if (operacao == "*")
            {
                acumular *= double.Parse(labelResultado.Text);
                labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
                labelResultado.Text = acumular.ToString();
                operacao = "";
                acumular = 0;
            }
            else if (operacao == "-")
            {
                acumular -= double.Parse(labelResultado.Text);
                labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
                labelResultado.Text = acumular.ToString();
                operacao = "";
                acumular = 0;
            }
            else if (operacao == "/")
            {
                acumular /= double.Parse(labelResultado.Text);
                labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
                labelResultado.Text = acumular.ToString();
                operacao = "";
                acumular = 0;
            }

        }






        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (labelResultado.Text.Length > 1)
            labelResultado.Text = labelResultado.Text.Substring(0, labelResultado.Text.Length - 1);
            else
            {
                labelResultado.Text = "0";
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "0";
            labelAcumular.Text = "";
            labelC.Text = "";
            labelC.Text = "";
            acumular = 0;
            operacao = "";
        }
        private void buttonCe_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "0";
        }

        





        
        
        private void buttonMaisMenos_Click(object sender, EventArgs e)
        {
            double maismenos = double.Parse(labelResultado.Text);
            if (maismenos > 0)
            {
                labelResultado.Text = "-" + labelResultado.Text;
            } 
            else if (maismenos < 0)
            {
                labelResultado.Text = labelResultado.Text.Substring(1);
            }
        }





        private void button1X_Click_1(object sender, EventArgs e)
        {
            acumular = 1 / double.Parse(labelResultado.Text);
            labelAcumular.Text = "1/(" + labelResultado.Text + ")";
            labelResultado.Text = acumular.ToString();
            acumular = 0;
        }
        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            acumular = double.Parse(labelResultado.Text);
            acumular *= acumular;
            labelAcumular.Text = "sqn(" + labelResultado.Text + ")";
            labelResultado.Text = acumular.ToString();
            acumular = 0;
        }
        private void button2vx_Click(object sender, EventArgs e)
        {
            acumular = double.Parse(labelResultado.Text);
            acumular = Math.Sqrt(acumular);
            labelAcumular.Text = "v(" + labelResultado.Text + ")";
            labelResultado.Text = acumular.ToString();
            acumular = 0;
        }






        



        private void buttonMC_Click(object sender, EventArgs e)
        {
            c = 0;
            labelC.Text = "";
            acumular = 0;
        }

        private void buttonMMenos_Click(object sender, EventArgs e)
        {
            c -= double.Parse(labelResultado.Text);
            labelC.Text = c.ToString();
            labelResultado.Text = "";
            labelAcumular.Text = "";
            acumular = 0;
            if (c == 0)
            {
                labelC.Text = "";
            }
        }
        private void buttoMMais_Click(object sender, EventArgs e)
        {
            c = c + double.Parse(labelResultado.Text);
            labelC.Text = c.ToString();
            labelResultado.Text = "";
            labelAcumular.Text = "";
            acumular = 0;
            if (c == 0)
            {
                labelC.Text = "";
            }
        }
        private void buttonMS_Click(object sender, EventArgs e)
        {
            labelResultado.Text = labelC.Text;
            labelC.Text = "";
            c = 0;
            acumular = 0;
        }
        private void buttonMR_Click(object sender, EventArgs e)
        {

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}