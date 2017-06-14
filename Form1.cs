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
       
        int grawitacja = 3;
        int predkosc = 3;
        int wynik = 0;
       // int koniec = 1;
        //int sufit = Screen.PrimaryScreen.Bounds.Heig;

        Random los = new Random();


        public Form1()
        {
            InitializeComponent();
            //Koniec_text1.Text = "Koniec Gry !!";
            //Koniec_text2.Text = "Twój wynik to: " + wynik;

            Koniec_text1.Visible = false; //niewidoczny
            Koniec_text2.Visible = false;
            Wynik_text.Text = "" + wynik;

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
            Gorna_rura.Left -= predkosc;
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

            else if(Postac.Bounds.IntersectsWith(Dolna_rura.Bounds))
            {
                koniec_gry();
            }


            // pojawianie się rur 
            if ( Dolna_rura.Right < -93) 
            {
                Dolna_rura.Left = los.Next(323, 553);
                wynik += 1 ;
                Wynik_text.Text = " " + wynik;
                Dolna_rura.Size = new Size(91, los.Next(81, 131));
            }


            if (Gorna_rura.Left < -93)
            {
                Gorna_rura.Left = los.Next(352, 535);
                wynik += 1;
                Wynik_text.Text = " " + wynik;
                Gorna_rura.Size = new Size(91, los.Next(80, 131));
            }
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

        // koniec gry
        private void koniec_gry()
        {
            timer1.Stop();
            Koniec_text1.Text = "Koniec Gry !!";
            Koniec_text2.Text = "Twój wynik to: " + wynik;


            Koniec_text1.Visible = true;
            Koniec_text2.Visible = true;
            Wynik_text.Text = " " + wynik;

        }


        private void Dolna_rura_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
