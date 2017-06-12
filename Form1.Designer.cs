namespace FlappyBird
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
            this.Postac = new System.Windows.Forms.PictureBox();
            this.Dolna_rura = new System.Windows.Forms.PictureBox();
            this.Gorna_rura = new System.Windows.Forms.PictureBox();
            this.Wynik_text = new System.Windows.Forms.Label();
            this.Koniec_text1 = new System.Windows.Forms.Label();
            this.Koniec_text2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Postac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dolna_rura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gorna_rura)).BeginInit();
            this.SuspendLayout();
            // 
            // Postac
            // 
            this.Postac.BackColor = System.Drawing.Color.Transparent;
            this.Postac.Image = global::FlappyBird.Properties.Resources.bird_straight;
            this.Postac.Location = new System.Drawing.Point(12, 80);
            this.Postac.Name = "Postac";
            this.Postac.Size = new System.Drawing.Size(58, 44);
            this.Postac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Postac.TabIndex = 1;
            this.Postac.TabStop = false;
            // 
            // Dolna_rura
            // 
            this.Dolna_rura.BackColor = System.Drawing.Color.Transparent;
            this.Dolna_rura.Image = global::FlappyBird.Properties.Resources.pipe;
            this.Dolna_rura.Location = new System.Drawing.Point(114, 285);
            this.Dolna_rura.Name = "Dolna_rura";
            this.Dolna_rura.Size = new System.Drawing.Size(100, 126);
            this.Dolna_rura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dolna_rura.TabIndex = 2;
            this.Dolna_rura.TabStop = false;
            // 
            // Gorna_rura
            // 
            this.Gorna_rura.BackColor = System.Drawing.Color.Transparent;
            this.Gorna_rura.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.Gorna_rura.Location = new System.Drawing.Point(187, -4);
            this.Gorna_rura.Name = "Gorna_rura";
            this.Gorna_rura.Size = new System.Drawing.Size(100, 171);
            this.Gorna_rura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gorna_rura.TabIndex = 3;
            this.Gorna_rura.TabStop = false;
            // 
            // Wynik_text
            // 
            this.Wynik_text.AutoSize = true;
            this.Wynik_text.BackColor = System.Drawing.Color.Transparent;
            this.Wynik_text.Location = new System.Drawing.Point(111, 9);
            this.Wynik_text.Name = "Wynik_text";
            this.Wynik_text.Size = new System.Drawing.Size(34, 13);
            this.Wynik_text.TabIndex = 4;
            this.Wynik_text.Text = "wynik";
            // 
            // Koniec_text1
            // 
            this.Koniec_text1.AutoSize = true;
            this.Koniec_text1.BackColor = System.Drawing.Color.Transparent;
            this.Koniec_text1.Location = new System.Drawing.Point(110, 143);
            this.Koniec_text1.Name = "Koniec_text1";
            this.Koniec_text1.Size = new System.Drawing.Size(35, 13);
            this.Koniec_text1.TabIndex = 5;
            this.Koniec_text1.Text = "label2";
            // 
            // Koniec_text2
            // 
            this.Koniec_text2.AutoSize = true;
            this.Koniec_text2.BackColor = System.Drawing.Color.Transparent;
            this.Koniec_text2.Location = new System.Drawing.Point(110, 182);
            this.Koniec_text2.Name = "Koniec_text2";
            this.Koniec_text2.Size = new System.Drawing.Size(35, 13);
            this.Koniec_text2.TabIndex = 6;
            this.Koniec_text2.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(299, 401);
            this.Controls.Add(this.Koniec_text2);
            this.Controls.Add(this.Koniec_text1);
            this.Controls.Add(this.Wynik_text);
            this.Controls.Add(this.Gorna_rura);
            this.Controls.Add(this.Dolna_rura);
            this.Controls.Add(this.Postac);
            this.Name = "Form1";
            this.Text = "Wynik";
            ((System.ComponentModel.ISupportInitialize)(this.Postac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dolna_rura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gorna_rura)).EndInit();
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
    }
}

