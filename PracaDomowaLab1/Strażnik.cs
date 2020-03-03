using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowaLab1
{
    /// <summary>
    /// Abstrakcyjna klasa Strażnik 
    /// </summary>
    public abstract class Strażnik
    {
        //Chroniona referencja do klasy Random
        protected Random losuj;
        // Publiczna abstrakcyjna metoda Chron
        public abstract int Chron();
        // Publiczna wirtualna metoda Odblokuj
        public virtual void Odblokuj(Button button)
        {
            // Odblokuj przysk
            button.Enabled=true;
        }
    }
}
