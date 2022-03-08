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
    public partial class Timer : Form
    {
        int sec = 0;
        int min = 0;
        int hrs = 0;
        double? botao = null;



        public Timer()
        {
            InitializeComponent();
            buttonIniciar.Visible = false;

        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
        private void labelSec1_Click(object sender, EventArgs e)
        {

        }
        private void labelS_Click(object sender, EventArgs e)
        {

        }
        private void labelM_Click(object sender, EventArgs e)
        {

        }
        private void labelHrs2_Click(object sender, EventArgs e)
        {

        }






        private void button0_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void button00_Click(object sender, EventArgs e)
        {
            calcular();
            calcular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botao = 1;
            calcular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            botao = 2;
            calcular();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            botao = 3;
            calcular();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            botao = 4;
            calcular();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            botao = 5;
            calcular();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            botao = 6;
            calcular();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            botao = 7;
            calcular();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            botao = 8;
            calcular();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            botao = 9;
            calcular();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            labelSec1.Text = labelSec2.Text;
            labelSec2.Text = labelMin1.Text;

            labelMin1.Text = labelMin2.Text;
            labelMin2.Text = labelHrs1.Text;

            labelHrs1.Text = labelHrs2.Text;
            labelHrs2.Text = "0";
        }



        private void calcular()
        {
            if (hrs < 10)
            {
                labelHrs2.Text = labelHrs1.Text;
                labelHrs1.Text = labelMin2.Text;

                labelMin2.Text = labelMin1.Text;
                labelMin1.Text = labelSec2.Text;

                labelSec2.Text = labelSec1.Text;
                labelSec1.Text = botao.ToString();

                botao = 0;
            }

            hrs = int.Parse(labelHrs2.Text + labelHrs1.Text);
            min = int.Parse(labelMin2.Text + labelMin1.Text);
            sec = int.Parse(labelSec2.Text + labelSec1.Text);

            if (sec > 0)
            {
                buttonIniciar.Visible = true;
            }
        }



        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                labelHrss.Text = hrs.ToString();
                labelMinn.Text = min.ToString();
                labelSecc.Text = sec.ToString();
                sec--;
                if (sec == 0 && min > 0)
                {
                    min--;
                    sec += 60;
                    if (min == 0 && hrs > 0)
                    {
                        hrs--;
                        min += 60;
                    }
                }
            }
            else
            {
                labelHrss.Text = hrs.ToString();
                labelMinn.Text = min.ToString();
                labelSecc.Text = sec.ToString();
                this.timer1.Enabled = false;
                MessageBox.Show("Tempo Esgotado!!!");
                fim();
            }
        }

        private void fim()
        {
            labelHrs2.Text = "0";
            labelHrs1.Text = "0";
            labelMin2.Text = "0";
            labelMin1.Text = "0";
            labelSec2.Text = "0";
            labelSec1.Text = "0";


            hrs = 0;
            min = 0;
            sec = 0;
        }
    }
}
