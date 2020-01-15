using System;

namespace Eventos2.Interfaces
{
    public interface IComparaFechas
    {
        int CompararFechas(DateTime dtFechaBase, DateTime dtFechaComparaar, string cPeriodo);
    }
}
