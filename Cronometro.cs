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
    public partial class Cronometro : Form
    {

        public Cronometro()
        {
            InitializeComponent();
            buttonPausar.Visible = false;
            buttonPausar.Enabled = false;
            buttonParar.Visible = false;
            buttonParar.Enabled = false;

            labelV1.Text = "";
            labelV2.Text = "";
        }

        private void Cronometro_Load(object sender, EventArgs e)
        {

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

            if (hrs2 == 9 && hrs1 == 9 && min2 == 5 && min1 == 9 && sec2 == 5 && sec1 == 9)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("O cronômetro chegou ao seu tempo limite!!!");
                Fim();
            }
            else
            {
                sec1++;

                if (sec1 == 10)
                {
                    sec2++;
                    sec1 = 0;

                    if (sec2 == 6)
                    {
                        min1++;
                        sec2 = 0;

                        if (min1 == 10)
                        {
                            min2++;
                            min1 = 0;

                            if (min2 == 6)
                            {
                                hrs1++;
                                min2 = 0;

                                if (hrs1 == 10)
                                {
                                    hrs2++;
                                    hrs1 = 0;
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
        }

        private void labelSec_Click(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

            buttonPausar.Visible = true;
            buttonPausar.Enabled = true;
            buttonParar.Visible = true;
            buttonParar.Enabled = true;
            buttonIniciar.Enabled = false;
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            Fim();
            buttonPausar.Visible = false;
            buttonPausar.Enabled = false;
            buttonParar.Visible = false;
            buttonParar.Enabled = false;
            buttonIniciar.Enabled = true;
        }

        private void buttonPausar_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();

            buttonPausar.Enabled = false;
            buttonIniciar.Enabled = true;
        }

        private void Fim()
        {
            this.timer1.Enabled = false;

            labelSec1.Text = "0";
            labelSec2.Text = "0";
            labelMin1.Text = "0";
            labelMin2.Text = "0";
            labelHrs1.Text = "0";
            labelHrs2.Text = "0";
        }

        private void buttonVolta_Click(object sender, EventArgs e)
        {
            if (labelV1.Text == "")
            {
                labelV1.Text = "1| " + labelHrs2.Text + labelHrs1.Text + ":" + labelMin2.Text + labelMin1.Text + ":" + labelSec2.Text + labelSec1.Text;
            }
        }
    }
}
