using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class ValidarFechaEvento : IValidarFechaEvento 
    {
        public DateTime ValidaFechaEvento(string cFecha)
        {
            try
            {
                DateTime dtFechaEvento = DateTime.Parse(cFecha);

                return dtFechaEvento;
            }
            catch (Exception)
            {
                throw new Exception("La fecha no tiene un formato correcto");
            }

        }
    }
}
