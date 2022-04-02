namespace calculadoravisual
{
    partial class Cronometro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelSec2 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelHrs2 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelMin2 = new System.Windows.Forms.Label();
            this.labelMin1 = new System.Windows.Forms.Label();
            this.labelSec1 = new System.Windows.Forms.Label();
            this.labelHrs1 = new System.Windows.Forms.Label();
            this.buttonPausar = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonVolta = new System.Windows.Forms.Button();
            this.labelV1 = new System.Windows.Forms.Label();
            this.labelV2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cronômetro";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIniciar.Location = new System.Drawing.Point(120, 200);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(80, 40);
            this.buttonIniciar.TabIndex = 64;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click_1);
            // 
            // labelSec2
            // 
            this.labelSec2.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSec2.ForeColor = System.Drawing.Color.White;
            this.labelSec2.Location = new System.Drawing.Point(229, 73);
            this.labelSec2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSec2.Name = "labelSec2";
            this.labelSec2.Size = new System.Drawing.Size(40, 89);
            this.labelSec2.TabIndex = 71;
            this.labelSec2.Text = "0";
            this.labelSec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelS.ForeColor = System.Drawing.Color.White;
            this.labelS.Location = new System.Drawing.Point(299, 132);
            this.labelS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(16, 16);
            this.labelS.TabIndex = 69;
            this.labelS.Text = "S";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelH.ForeColor = System.Drawing.Color.White;
            this.labelH.Location = new System.Drawing.Point(80, 132);
            this.labelH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(17, 16);
            this.labelH.TabIndex = 68;
            this.labelH.Text = "H";
            // 
            // labelHrs2
            // 
            this.labelHrs2.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHrs2.ForeColor = System.Drawing.Color.White;
            this.labelHrs2.Location = new System.Drawing.Point(10, 73);
            this.labelHrs2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHrs2.Name = "labelHrs2";
            this.labelHrs2.Size = new System.Drawing.Size(40, 89);
            this.labelHrs2.TabIndex = 73;
            this.labelHrs2.Text = "0";
            this.labelHrs2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelM.ForeColor = System.Drawing.Color.White;
            this.labelM.Location = new System.Drawing.Point(190, 132);
            this.labelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(18, 16);
            this.labelM.TabIndex = 70;
            this.labelM.Text = "M";
            // 
            // labelMin2
            // 
            this.labelMin2.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin2.ForeColor = System.Drawing.Color.White;
            this.labelMin2.Location = new System.Drawing.Point(120, 73);
            this.labelMin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin2.Name = "labelMin2";
            this.labelMin2.Size = new System.Drawing.Size(40, 89);
            this.labelMin2.TabIndex = 72;
            this.labelMin2.Text = "0";
            this.labelMin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMin1
            // 
            this.labelMin1.AutoSize = true;
            this.labelMin1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin1.ForeColor = System.Drawing.Color.White;
            this.labelMin1.Location = new System.Drawing.Point(142, 73);
            this.labelMin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin1.Name = "labelMin1";
            this.labelMin1.Size = new System.Drawing.Size(74, 89);
            this.labelMin1.TabIndex = 66;
            this.labelMin1.Text = "0";
            this.labelMin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSec1
            // 
            this.labelSec1.AutoSize = true;
            this.labelSec1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSec1.ForeColor = System.Drawing.Color.White;
            this.labelSec1.Location = new System.Drawing.Point(251, 73);
            this.labelSec1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSec1.Name = "labelSec1";
            this.labelSec1.Size = new System.Drawing.Size(74, 89);
            this.labelSec1.TabIndex = 67;
            this.labelSec1.Text = "0";
            this.labelSec1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHrs1
            // 
            this.labelHrs1.AutoSize = true;
            this.labelHrs1.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHrs1.ForeColor = System.Drawing.Color.White;
            this.labelHrs1.Location = new System.Drawing.Point(33, 73);
            this.labelHrs1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHrs1.Name = "labelHrs1";
            this.labelHrs1.Size = new System.Drawing.Size(74, 89);
            this.labelHrs1.TabIndex = 65;
            this.labelHrs1.Text = "0";
            this.labelHrs1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPausar
            // 
            this.buttonPausar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPausar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPausar.Location = new System.Drawing.Point(85, 205);
            this.buttonPausar.Name = "buttonPausar";
            this.buttonPausar.Size = new System.Drawing.Size(30, 30);
            this.buttonPausar.TabIndex = 74;
            this.buttonPausar.Text = "||";
            this.buttonPausar.UseVisualStyleBackColor = false;
            this.buttonPausar.Click += new System.EventHandler(this.buttonPausar_Click_1);
            // 
            // buttonParar
            // 
            this.buttonParar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonParar.Location = new System.Drawing.Point(205, 205);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(30, 30);
            this.buttonParar.TabIndex = 75;
            this.buttonParar.Text = "X";
            this.buttonParar.UseVisualStyleBackColor = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonVolta
            // 
            this.buttonVolta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolta.ForeColor = System.Drawing.Color.Black;
            this.buttonVolta.Location = new System.Drawing.Point(123, 246);
            this.buttonVolta.Name = "buttonVolta";
            this.buttonVolta.Size = new System.Drawing.Size(75, 23);
            this.buttonVolta.TabIndex = 76;
            this.buttonVolta.Text = "volta";
            this.buttonVolta.UseVisualStyleBackColor = false;
            this.buttonVolta.Click += new System.EventHandler(this.buttonVolta_Click);
            // 
            // labelV1
            // 
            this.labelV1.AutoSize = true;
            this.labelV1.ForeColor = System.Drawing.Color.White;
            this.labelV1.Location = new System.Drawing.Point(81, 311);
            this.labelV1.Name = "labelV1";
            this.labelV1.Size = new System.Drawing.Size(13, 15);
            this.labelV1.TabIndex = 77;
            this.labelV1.Text = "0";
            // 
            // labelV2
            // 
            this.labelV2.AutoSize = true;
            this.labelV2.ForeColor = System.Drawing.Color.White;
            this.labelV2.Location = new System.Drawing.Point(81, 326);
            this.labelV2.Name = "labelV2";
            this.labelV2.Size = new System.Drawing.Size(13, 15);
            this.labelV2.TabIndex = 78;
            this.labelV2.Text = "0";
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(324, 398);
            this.Controls.Add(this.labelV2);
            this.Controls.Add(this.labelV1);
            this.Controls.Add(this.buttonVolta);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonPausar);
            this.Controls.Add(this.labelSec2);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelHrs2);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelMin2);
            this.Controls.Add(this.labelMin1);
            this.Controls.Add(this.labelSec1);
            this.Controls.Add(this.labelHrs1);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cronometro";
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Cronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button buttonIniciar;
        private Label labelSec2;
        private Label labelS;
        private Label labelH;
        private Label labelHrs2;
        private Label labelM;
        private Label labelMin2;
        private Label labelMin1;
        private Label labelSec1;
        private Label labelHrs1;
        private Button buttonPausar;
        private Button buttonParar;
        private Button buttonVolta;
        private Label labelV1;
        private Label labelV2;
    }
}