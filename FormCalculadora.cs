namespace calculadoravisual
{
    public partial class FormCalculadora : Form
    {
        double acumular;
        double c;
        string? operacao;
        int botao;

        public FormCalculadora()
        {
            InitializeComponent();
            labelAcumular.Text = "";
            labelC.Text = "";
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
            labelResultado.Text += ",";
        }

         private void adbotao()
         {
            if (labelResultado.Text == "0")
            {
                labelResultado.Text = $"{botao}";
            }
            else
            {
                labelResultado.Text += $"{botao}";
            }

            botao = 0;
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
            switch (operacao)
            {
                case "+": psoma(); break;
                case "-": psubtracao(); break;
                case "*": pmultiplicacao(); break;
                case "/": pdivisao(); break;
            }
            labelResultado.Text = acumular.ToString();
        }

        private void psoma()
        {
            double valor1 = double.Parse(labelResultado.Text);
            double resultado = (valor1 * acumular) / 100;
            acumular += resultado;
            labelAcumular.Text += resultado.ToString() + "% = ";
            labelResultado.Text = "0";
        }
        private void psubtracao()
        {
            double valor1 = double.Parse(labelResultado.Text);
            double resultado = (valor1 * acumular) / 100;
            acumular -= resultado;
            labelAcumular.Text += resultado.ToString() + "% = ";
            labelResultado.Text = "0";
        }
        private void pmultiplicacao()
        {
            double valor1 = double.Parse(labelResultado.Text);
            double resultado = (valor1 * acumular) / 100;
            acumular *= resultado;
            labelAcumular.Text += resultado.ToString() + "% = ";
            labelResultado.Text = "0";
        }
        private void pdivisao()
        {
            double valor1 = double.Parse(labelResultado.Text);
            double resultado = (valor1 * acumular) / 100;
            acumular /= resultado;
            labelAcumular.Text += resultado.ToString() + "% = ";
            labelResultado.Text = "0";
        }





        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "+": soma(); break;
                case "-": subtacao(); break;
                case "/": divisao(); break;
                case "*": multipicacao(); break;
            }
        }

        private void soma()
        {
            acumular += double.Parse(labelResultado.Text);
            labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
            labelResultado.Text = acumular.ToString();
            operacao = "";
            acumular = 0;
        }
        private void subtacao()
        {
            acumular -= double.Parse(labelResultado.Text);
            labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
            labelResultado.Text = acumular.ToString();
            operacao = "";
            acumular = 0;
        }
        private void multipicacao()
        {
            acumular *= double.Parse(labelResultado.Text);
            labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
            labelResultado.Text = acumular.ToString();
            operacao = "";
            acumular = 0;
        }
        private void divisao()
        {
            acumular /= double.Parse(labelResultado.Text);
            labelAcumular.Text = " " + labelAcumular.Text + labelResultado.Text + " = ";
            labelResultado.Text = acumular.ToString();
            operacao = "";
            acumular = 0;
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
            if (labelResultado.Text == "")
            {
            }
            else
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
            labelAcumular.Text = "0";
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
            acumular = 0;
            if (c == 0)
            {
                labelC.Text = "";
            }
        }
        private void buttonMS_Click(object sender, EventArgs e)
        {   
            if (labelC.Text == "")
            {

            } else
            {
                labelResultado.Text = labelC.Text;
                labelC.Text = "";
                labelAcumular.Text = "";
                c = 0;
                acumular = 0;
            }
            
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
















        private void buttonMoedas_Click(object sender, EventArgs e)
        {
            Comprimento comprimentoForm = new Comprimento();
            comprimentoForm.Show();
        }

        private void buttonJurosSimples_Click(object sender, EventArgs e)
        {
            FormJurosSimples jurosSimplesForm = new FormJurosSimples();
            jurosSimplesForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormJurosCompostos jurosCompostosForm = new FormJurosCompostos();
            jurosCompostosForm.Show();
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            Timer TimerForm = new Timer();
            TimerForm.Show();
        }

        private void buttonCronometro_Click(object sender, EventArgs e)
        {
            Cronometro CronometroForm = new Cronometro();
            CronometroForm.Show();
        }
    }
}