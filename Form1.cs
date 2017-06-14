using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        bool skok = false;
        int grawitacja = 3;
        int predkosc = 3;
        int wynik = 0;

        Random los = new Random();


        public Form1()
        {
            InitializeComponent();
            //Koniec_text1.Text = "Koniec Gry !!";
            //Koniec_text2.Text = "Twój wynik to: " + wynik;

            Koniec_text1.Visible = false; //niewidoczny
            Koniec_text2.Visible = false;
            Wynik_text.Text = "" + wynik;
            Start_b.Visible = false;

        }

        private void Start_gry()
        {

            Koniec_text1.Visible = false; //niewidoczny
            Koniec_text2.Visible = false;
            Wynik_text.Text = "" + wynik;


        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Dolna_rura.Left -= predkosc; // brak przesuniecia rury w prawo
            Dolna_rura2.Left -= predkosc;
            Gorna_rura.Left -= predkosc;
            Gorna_rura2.Left -= predkosc;
            Postac.Top += grawitacja;   // ruch postaci


            // zderzenia 
            if(Postac.Bounds.IntersectsWith(Ziemia.Bounds))
            {
                koniec_gry();
            }

            else if(Postac.Bounds.IntersectsWith(Gorna_rura.Bounds))
            {
                koniec_gry();
            }

            else if (Postac.Bounds.IntersectsWith(Gorna_rura2.Bounds))
            {
                koniec_gry();
            }

            else if(Postac.Bounds.IntersectsWith(Dolna_rura.Bounds))
            {
                koniec_gry();
            }
            else if (Postac.Bounds.IntersectsWith(Dolna_rura2.Bounds))
            {
                koniec_gry();
            }


            // pojawianie się rur 
            if ( Dolna_rura.Right < 0 ) 
            {
                Dolna_rura.Left = los.Next(381, 482);
                wynik += 1 ;
                Wynik_text.Text = " " + wynik;
                Dolna_rura.Size = new Size(91, los.Next(81, 216));

            }

            if (Dolna_rura2.Right < 0)
            {
                Dolna_rura2.Left = los.Next(381, 482)+30;
                wynik += 1;
                Wynik_text.Text = " " + wynik;
                Dolna_rura2.Size = new Size(91, los.Next(81, 216));
            }

            if (Gorna_rura.Right  < 0)
            {
                Gorna_rura.Left = los.Next(381, 535);
                wynik += 1;
                Wynik_text.Text = " " + wynik;
                Gorna_rura.Size = new Size(91, los.Next(80, 216));
            }


            if (Gorna_rura2.Right < 0)
            {
                Gorna_rura2.Left = los.Next(381, 529);
                wynik += 1;
                Wynik_text.Text = " " + wynik;
                Gorna_rura2.Size = new Size(91, los.Next(80, 216));
            }



        }


        // Zmiana lotu birdsa [ spacja - zmiana z lotu na dol na lot do gory
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                grawitacja = -3;
                skok = true;
                
            }

        }

        // Zmiana lotu na lot do dołu 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                grawitacja = 2;
                skok = true;
            }
        }

        // koniec gry
        private void koniec_gry()
        {
            timer1.Stop();
            Koniec_text1.Text = "Koniec Gry !!";
            Koniec_text2.Text = "Twój wynik to: " + wynik;


            Koniec_text1.Visible = true;
            Koniec_text2.Visible = true;
            Wynik_text.Text = " " + wynik;
            Start_b.Visible = true;

        }


        private void Dolna_rura_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_b_Click(object sender, EventArgs e)
        {
            Application.Restart();
                
        }
    }
}
