using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Publiczna klasa StrażnikRecept
    /// </summary>
    public class StrażnikRecept : Strażnik
    {
        /// <summary>
        /// Przeciążenie metody klasy Strażnik
        /// </summary>
        /// <returns></returns>
        public override int Chron()
        {
            // Stworzenie nowego obiektu klasy Random
            losuj = new Random();
            //Utworzenie lokalnej zmiennej i przypsianie do niej wylosowanej wartosci
            int ilosc = losuj.Next(1, 2);
            // Zwrocenie wylosowanej wartosci
            return ilosc;
        }
        /// <summary>
        /// Przeciązona metoda klasy Straznik 
        /// </summary>
        /// <param name="button"></param>
        public override void Odblokuj(Button button)
        {
            //Wywołaj cialo z metody Odblokuj z klasy bazowej i odblokuj przycisk
            base.Odblokuj(button); 
        }
    }
}
