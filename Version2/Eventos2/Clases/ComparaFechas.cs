using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class ComparaFechas : IComparaFechas
    {
        public int CompararFechas(DateTime _dtFechaBase, DateTime _dtFechaComparar, string _cPeriodo)
        {
            int diferencia = 0;

            TimeSpan intervalo = _dtFechaComparar - _dtFechaBase;

            switch (_cPeriodo)
            {
                case "Mes": diferencia = (intervalo.Days / 30); break;
                case "Dia": diferencia = intervalo.Days; break;
                case "Hora": diferencia = intervalo.Hours; break;
                case "Minuto": diferencia = intervalo.Minutes; break;
            }

            return diferencia;
        }

    }
}
