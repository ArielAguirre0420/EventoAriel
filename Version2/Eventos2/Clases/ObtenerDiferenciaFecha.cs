using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class ObtenerDiferenciaFecha : IObtenerDiferenciaFecha 
    {
        private IComparaFechas compararFechas;
        public ObtenerDiferenciaFecha(IComparaFechas _compararFechas)
        {
            compararFechas = _compararFechas;
        }

        public int ObtenerDiferenciaDias(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Dia");

            return resultado;
        }

        public int ObtenerDiferenciaHoras(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Hora");

            return resultado;
        }

        public int ObtenerDiferenciaMes(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Mes");

            return resultado;
        }

        public int ObtenerDiferenciaMinutos(DateTime dtFechaBase, DateTime dtFechaComparar)
        {
            int resultado;

            resultado = compararFechas.CompararFechas(dtFechaBase, dtFechaComparar, "Minuto");

            return resultado;
        }
    }
}
