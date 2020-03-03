using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Publiczna klasa ZlodziejCzasu, dziedziczaca po abstrakcyjnej klasie Zlodziej
    /// </summary>
    public class ZłodziejCzasu:Złodziej
    {      

        /// <summary>
        /// Przeciązenie metody Okradnij z klasy Złodziej
        /// </summary>
        /// <param name="ilosc"></param>
        /// <returns></returns>
        public override int Okradnij()
        {
            // Utworzenie nowego obiektu klasy Random
            losuj = new Random();
            //Stworzenie lokalnej zmiennej i wylosowanie liczby
            int  ilosc = losuj.Next(2, 6);
            // Zwracanie liczby
            return ilosc;
        }

        /// <summary>
        /// Przeciązenie metody SkrocCzas klasy Złodziej
        /// </summary>
        /// <param name="czas"></param>
        public override bool SkrocCzas(bool skroc)
        {
            // Wywołaj ciało z metody bazowej klasy Złodziej
            base.SkrocCzas(skroc);
            // Zwróć parametr funkcji
            return true;
        }


    }
}
