using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowaLab1
{
    public partial class FormStart : Form
    {
        //Deklaruje referencje typu FormGra
        FormGra form2;
        //Deklaruje referencje typu FormRecepta
        FormRecepta recepty;
        //Tworze pole typu int do kotrolowania czasu gry
        public static int interwal = 1;
        public FormStart()
        {
            InitializeComponent();
            //Wyswiela wartosc w textBox
            textBoxInterwal.Text = interwal.ToString();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
                     
        }

        /// <summary>
        /// Zamknij okno startowe, stórz okno gry i otórz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Ukryj ten obiekt 
            this.Hide();
            //Stworz nowy obiekt typu FormGra
            form2 = new FormGra();
            //Pokaz nowy obiekt
            form2.Show();
            
        }
        /// <summary>
        /// Zamknij okno startowe, stórz okno recept i otwórz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecepty_Click(object sender, EventArgs e)
        {
            //Ukryj ten obiekt 
            this.Hide();
            //Stworz  nowy obiekt typu Form3
            recepty = new FormRecepta();
            //Wyswietl nowy obiekt
            recepty.Show();
        }
        /// <summary>
        /// Zwekszam czas trwania gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            //Zwiekzam czas trwania o 1
            interwal += 1;
            //Wyswiela wartosc w textBox
            textBoxInterwal.Text = interwal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Jezeli wartosc jest wieksza od 1
            if(interwal>1)
            {
                //Zmniejsz wartosc o 1
                interwal -= 1;
                //Wyswiela wartosc w textBox
                textBoxInterwal.Text = interwal.ToString();
            }
            
        }
    }
}
