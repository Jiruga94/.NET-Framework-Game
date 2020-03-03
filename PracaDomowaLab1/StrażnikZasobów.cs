using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Publiczna klasa StrażnikZasobów
    /// </summary>
    public class StrażnikZasobów : Strażnik,IStrzeż
    {
        /// <summary>
        /// Przeciązona metoda klasy Strażnik
        /// </summary>
        /// <returns></returns>
        public override int Chron()
        {
            // Stworzenie nowego obiektu typu Random
           losuj = new Random();
            // Wylosowanie oraz przypisanie losowej liczby 
           int ilosc = losuj.Next(1, 5);
            // Zwroc wylosowana liczbe
            return ilosc;
        }

        /// <summary>
        /// Metoda interfejsu IStrzez chroniaca czas zasobow na okres kilku tur
        /// </summary>
        /// <param name="dlugoscOchrony"></param>
        /// <returns></returns>
        public int StrzezZasoby(int dlugoscOchrony)
        {
            // Stworzenie nowego obiektu klasy Random
            losuj = new Random();
            // Ustawienie ilosci chronionych tur
            dlugoscOchrony = losuj.Next(1, 3);
            // Zwroc dlugosc trwania ochrony
            return dlugoscOchrony;
        }
    }
}
