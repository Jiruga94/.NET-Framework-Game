using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Publiczna kalsa ZłodziejZasobów
    /// </summary>
    public class ZlodziejZasobow : Złodziej, IBlokuj
    {
          /// <summary>
          /// Przeciązona metoda klasy Złodziej do okradania zasobow
          /// </summary>
          /// <param name="ilosc"></param>
          /// <returns></returns>
        public override int Okradnij()
        {
            // Stworzenie nowego obiektu klasy Random
            losuj = new Random();
            //Stworznie lokjnej zmiennej i przypisanie wylosowanej wartosci
            int ilosc = losuj.Next(15, 30);
            // Zwroc wylosowana wartosc
            return ilosc;
        }

        /// <summary>
        /// Metoda interfejsu IBlokuj blokujaca wzrost zasobow przez okres kilku tur
        /// </summary>
        /// <param name="zwiekszanie"></param>
        /// <returns></returns>
        public int BlokujZasob(int zwiekszanie)
        {
            //Ustawienie zweikszania zasobow co ture na 0
            zwiekszanie = 0;
            //Ustawienie dlugosci trwania zablokowania 
            int  dlugoscTrwania = losuj.Next(2, 5);
            //Zwroc dlugosc trwania blokady
            return dlugoscTrwania;
        }


    }
}
