using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaLab1
{

    /// <summary>
    /// Interfejs umozliwiajacy ochrone zasobow
    /// </summary>
    interface IStrzeż
    {
        /// <summary>
        /// Metoda chroniaca zasob przed kradzieza
        /// </summary>
        /// <param name="dlugoscOchrony"></param>
        /// <returns></returns>
        int StrzezZasoby(int dlugoscOchrony);

    }
}
