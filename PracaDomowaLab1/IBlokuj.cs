using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Interfejs umozliwiajacy zablokowanie zwiekszania zasobu
    /// </summary>
    interface IBlokuj
    {
        /// <summary>
        /// Metoda blokujaca dany zasob
        /// </summary>
        /// <param name="zwiekszanie"></param>      
        /// <returns></returns>
        int BlokujZasob(int zwiekszanie);

    }
}
