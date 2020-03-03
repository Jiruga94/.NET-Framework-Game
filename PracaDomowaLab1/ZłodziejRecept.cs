using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowaLab1
{
    /// <summary>
    /// Publiczna klasa ZłodziejRecept
    /// </summary>
    public class ZłodziejRecept : Złodziej
    {
        /// <summary>
        /// Przecaznona metoda okradnij klasy Złodziej
        /// </summary>
        /// <param name="ilosc"></param>
        /// <returns></returns>
        public override int Okradnij()
        {
            //Stworznie nowego obiektu klasy Random
            losuj = new Random();
            //Stworznie lokalnej zmiennej i Wylosowanie i przypisanie ilosci okradzionych zasobow
            int ilosc = losuj.Next(1, 2);
            // Zwroc ilosc
            return ilosc;
        }
        /// <summary>
        /// Przeciązona metoda klasy Złodziej blokujaca przycisk 
        /// </summary>
        /// <param name="button"></param>
        public override void Zablokuj(Button button)
        {
            // Wywołanie ciala z metody bazowej klasy Złodziej
            base.Zablokuj(button);
        }
    }
}
