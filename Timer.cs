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
            buttonPausar.Visible = false;
            buttonParar.Visible = false;

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
            adbotao();
        }
        private void button00_Click(object sender, EventArgs e)
        {
            adbotao();
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



        private void buttonApagar_Click(object sender, EventArgs e)
        {
            labelSec1.Text = labelSec2.Text;
            labelSec2.Text = labelMin1.Text;

            labelMin1.Text = labelMin2.Text;
            labelMin2.Text = labelHrs1.Text;

            labelHrs1.Text = labelHrs2.Text;
            labelHrs2.Text = "0";

            calcular();
        }
        private void adbotao()
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

            calcular();
        }
        private void calcular()
        {
            hrs = int.Parse(labelHrs2.Text + labelHrs1.Text);
            min = int.Parse(labelMin2.Text + labelMin1.Text);
            sec = int.Parse(labelSec2.Text + labelSec1.Text);

            if (sec > 0)
            {
                buttonIniciar.Visible = true;
                buttonIniciar.Enabled = true;
            }
            if (sec <= 0)
            {
                buttonIniciar.Visible = false;
                buttonPausar.Visible = false;
                buttonParar.Visible = false;
            }
        }



        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            buttonPausar.Visible = true;
            buttonParar.Visible = true;
            buttonIniciar.Enabled = false;
        }
        private void buttonPausar_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            buttonIniciar.Enabled = true;
            buttonPausar.Enabled = false;
        }
        private void buttonParar_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            fim();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec1, sec2, min1, min2, hrs1, hrs2;

            hrs2 = int.Parse(labelHrs2.Text);
            hrs1 = int.Parse(labelHrs1.Text);
            min2 = int.Parse(labelMin2.Text);
            min1 = int.Parse(labelMin1.Text);
            sec2 = int.Parse(labelSec2.Text);
            sec1 = int.Parse(labelSec1.Text);

            if (sec1 > 0)
            {
                sec1--;

                if (sec1 == 0 && sec2 > 0)
                {
                    sec2--;
                    sec1 += 9;

                    if (sec2 == 0 && min1 > 0)
                    {
                        min1--;
                        sec2 += 6;

                        if (min1 == 0 && min2 > 0)
                        {
                            min2--;
                            min1 += 9;

                            if (sec2 == 0 && min1 > 0)
                            {
                                min1--;
                                sec2 += 6;

                                if (min1 == 0 && min2 > 0)
                                {
                                    min2--;
                                    min1 += 9;

                                    if (min2 == 0 && hrs1 > 0)
                                    {
                                        hrs1--;
                                        min2 += 6;

                                        if (hrs1 == 0 && hrs2 > 0)
                                        {
                                            hrs2--;
                                            hrs1 += 9;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                labelSec1.Text = sec1.ToString();
                labelSec2.Text = sec2.ToString();
                labelMin1.Text = min1.ToString();
                labelMin2.Text = min2.ToString();
                labelHrs1.Text = hrs1.ToString();
                labelHrs2.Text = hrs2.ToString();
            }
            else
            {
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

            calcular();
        }
    }
}
