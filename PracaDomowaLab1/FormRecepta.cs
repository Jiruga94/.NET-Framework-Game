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
    public partial class FormRecepta : Form
    {
        //Dekalruje referencje do klasy FormStart
        FormStart formStart;
        //Wartosc logiczna dzieki ktorej wiem jakie okno otworzyc
        public bool wroc = false;
        public FormRecepta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Zamknij startowe okno, nastepnie stwórz onko gry i otówrz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWróć_Click(object sender, EventArgs e)
        {
            if(wroc)
            {
                //Ukryj ten obiekt
                this.Hide();
                //Otworz obiekt gra
                FormGra.gra.Show();
            }
            else
            {
                //Stworz nowy obiekt typu FormStart
                formStart = new FormStart();
                //Pokaz stworzony obiekt
                formStart.Show();
            }
           
            
        }
    }
}
