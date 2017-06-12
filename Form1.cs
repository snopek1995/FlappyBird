using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
       
        int grawitacja = 5;
        int predkosc = 5;
        int wynik = 0;


        public Form1()
        {
            InitializeComponent();
            Koniec_text1.Text = "Koniec Gry !!";
            Koniec_text2.Text = "Twój wynik to:  " + wynik;

            Koniec_text1.Visible = false; //niewidoczny
            Koniec_text2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dolna_rura.Left -= predkosc; // brak przesuniecia rury w prawo
            Gorna_rura.Left -= predkosc;
            Postac.Top += grawitacja;   // ruch postaci

        }

        // Zmiana lotu birdsa [ spacja - zmiana z lotu na dol na lot do gory
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                grawitacja = -3;
            }

        }

        // Zmiana lotu na lot do dołu 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                grawitacja = 2;
            }
        }
    }
}
