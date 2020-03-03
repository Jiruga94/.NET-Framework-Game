using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowaLab1
{
    /// <summary>
    /// Publiczna abstrakcyjna klasa Złodziej
    /// </summary>
    public abstract class Złodziej
    {

        // Chroniona referencja do klasy Random
        protected Random losuj;
        // Publiczna abstrakcyjna metoda Okradnij  
        public abstract int Okradnij();
        // Publiczna virtualna metoda SkrocCzas
        public virtual bool SkrocCzas(bool skroc)
        {
            // Skroc czas na wytworzenie itemu o polowe
            skroc = true;
            //Zwroc parametr funkcji
            return skroc;
        }
        // Publiczna wirtualna metoda Zzablokuj
        public virtual void Zablokuj(Button button)
        {
            // Zablokuj przycisk
            button.Enabled = false;
        }
    }
}
