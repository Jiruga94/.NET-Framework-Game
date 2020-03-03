using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Publiczna klasa StrażnikCzasu
    /// </summary>
    public class StraznikCzasu : Strażnik
    {
        /// <summary>
        /// Przeciążona metoda Chron z klasy Straznik
        /// </summary>
        /// <returns></returns>
        public override int Chron()
        {
            // Ilosc ochrony równe 1
            int ilosc = 1;
            // zwróc ilosc
            return ilosc;
        }
    }
}
