﻿namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Wynik_text = new System.Windows.Forms.Label();
            this.Koniec_text1 = new System.Windows.Forms.Label();
            this.Koniec_text2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Gorna_rura = new System.Windows.Forms.PictureBox();
            this.Dolna_rura = new System.Windows.Forms.PictureBox();
            this.Postac = new System.Windows.Forms.PictureBox();
            this.Ziemia = new System.Windows.Forms.PictureBox();
            this.Start_b = new System.Windows.Forms.Button();
            this.Dolna_rura2 = new System.Windows.Forms.PictureBox();
            this.Gorna_rura2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gorna_rura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dolna_rura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Postac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ziemia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dolna_rura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gorna_rura2)).BeginInit();
            this.SuspendLayout();
            // 
            // Wynik_text
            // 
            this.Wynik_text.AutoSize = true;
            this.Wynik_text.BackColor = System.Drawing.Color.Transparent;
            this.Wynik_text.Location = new System.Drawing.Point(165, 9);
            this.Wynik_text.Name = "Wynik_text";
            this.Wynik_text.Size = new System.Drawing.Size(34, 13);
            this.Wynik_text.TabIndex = 4;
            this.Wynik_text.Text = "wynik";
            // 
            // Koniec_text1
            // 
            this.Koniec_text1.AutoSize = true;
            this.Koniec_text1.BackColor = System.Drawing.Color.Transparent;
            this.Koniec_text1.Location = new System.Drawing.Point(148, 143);
            this.Koniec_text1.Name = "Koniec_text1";
            this.Koniec_text1.Size = new System.Drawing.Size(68, 13);
            this.Koniec_text1.TabIndex = 5;
            this.Koniec_text1.Text = "Koniec Gry !!";
            // 
            // Koniec_text2
            // 
            this.Koniec_text2.AutoSize = true;
            this.Koniec_text2.BackColor = System.Drawing.Color.Transparent;
            this.Koniec_text2.Location = new System.Drawing.Point(139, 182);
            this.Koniec_text2.Name = "Koniec_text2";
            this.Koniec_text2.Size = new System.Drawing.Size(87, 13);
            this.Koniec_text2.TabIndex = 6;
            this.Koniec_text2.Text = "Twój wynik to :   ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Gorna_rura
            // 
            this.Gorna_rura.BackColor = System.Drawing.Color.Transparent;
            this.Gorna_rura.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.Gorna_rura.Location = new System.Drawing.Point(222, -1);
            this.Gorna_rura.Name = "Gorna_rura";
            this.Gorna_rura.Size = new System.Drawing.Size(91, 171);
            this.Gorna_rura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gorna_rura.TabIndex = 3;
            this.Gorna_rura.TabStop = false;
            // 
            // Dolna_rura
            // 
            this.Dolna_rura.BackColor = System.Drawing.Color.Transparent;
            this.Dolna_rura.Image = global::FlappyBird.Properties.Resources.pipe;
            this.Dolna_rura.Location = new System.Drawing.Point(168, 319);
            this.Dolna_rura.Name = "Dolna_rura";
            this.Dolna_rura.Size = new System.Drawing.Size(91, 126);
            this.Dolna_rura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dolna_rura.TabIndex = 2;
            this.Dolna_rura.TabStop = false;
            this.Dolna_rura.Click += new System.EventHandler(this.Dolna_rura_Click);
            // 
            // Postac
            // 
            this.Postac.BackColor = System.Drawing.Color.Transparent;
            this.Postac.Image = global::FlappyBird.Properties.Resources.bird_straight;
            this.Postac.Location = new System.Drawing.Point(12, 88);
            this.Postac.Name = "Postac";
            this.Postac.Size = new System.Drawing.Size(47, 43);
            this.Postac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Postac.TabIndex = 1;
            this.Postac.TabStop = false;
            // 
            // Ziemia
            // 
            this.Ziemia.BackColor = System.Drawing.Color.Transparent;
            this.Ziemia.Image = global::FlappyBird.Properties.Resources.ground;
            this.Ziemia.Location = new System.Drawing.Point(-11, 404);
            this.Ziemia.Name = "Ziemia";
            this.Ziemia.Size = new System.Drawing.Size(570, 41);
            this.Ziemia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ziemia.TabIndex = 7;
            this.Ziemia.TabStop = false;
            // 
            // Start_b
            // 
            this.Start_b.BackColor = System.Drawing.Color.MintCream;
            this.Start_b.Location = new System.Drawing.Point(134, 248);
            this.Start_b.Name = "Start_b";
            this.Start_b.Size = new System.Drawing.Size(96, 31);
            this.Start_b.TabIndex = 8;
            this.Start_b.Text = "Start";
            this.Start_b.UseVisualStyleBackColor = false;
            this.Start_b.Click += new System.EventHandler(this.Start_b_Click);
            // 
            // Dolna_rura2
            // 
            this.Dolna_rura2.BackColor = System.Drawing.Color.Transparent;
            this.Dolna_rura2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.Dolna_rura2.Location = new System.Drawing.Point(468, 267);
            this.Dolna_rura2.Name = "Dolna_rura2";
            this.Dolna_rura2.Size = new System.Drawing.Size(91, 251);
            this.Dolna_rura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dolna_rura2.TabIndex = 9;
            this.Dolna_rura2.TabStop = false;
            // 
            // Gorna_rura2
            // 
            this.Gorna_rura2.BackColor = System.Drawing.Color.Transparent;
            this.Gorna_rura2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.Gorna_rura2.Location = new System.Drawing.Point(561, -1);
            this.Gorna_rura2.Name = "Gorna_rura2";
            this.Gorna_rura2.Size = new System.Drawing.Size(91, 132);
            this.Gorna_rura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gorna_rura2.TabIndex = 10;
            this.Gorna_rura2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(365, 439);
            this.Controls.Add(this.Wynik_text);
            this.Controls.Add(this.Koniec_text1);
            this.Controls.Add(this.Koniec_text2);
            this.Controls.Add(this.Gorna_rura2);
            this.Controls.Add(this.Start_b);
            this.Controls.Add(this.Ziemia);
            this.Controls.Add(this.Gorna_rura);
            this.Controls.Add(this.Dolna_rura);
            this.Controls.Add(this.Postac);
            this.Controls.Add(this.Dolna_rura2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Wynik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Gorna_rura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dolna_rura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Postac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ziemia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dolna_rura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gorna_rura2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Postac;
        private System.Windows.Forms.PictureBox Dolna_rura;
        private System.Windows.Forms.PictureBox Gorna_rura;
        private System.Windows.Forms.Label Wynik_text;
        private System.Windows.Forms.Label Koniec_text1;
        private System.Windows.Forms.Label Koniec_text2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Ziemia;
        private System.Windows.Forms.Button Start_b;
        private System.Windows.Forms.PictureBox Dolna_rura2;
        private System.Windows.Forms.PictureBox Gorna_rura2;
    }
}

