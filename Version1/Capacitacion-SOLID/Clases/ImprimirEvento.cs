using Capacitacion_SOLID.Interfaces;
using System;

namespace Capacitacion_SOLID.Clases
{
    public class ImprimirEvento : IImprimirEvento 
    {
        public void PrintMensajeEvento(string _cNombreEvento, string _cYaOcurrio, string _cPeriodo)
        {
            string mensaje = "El evento " + _cNombreEvento + " " + _cYaOcurrio + " " + _cPeriodo;
            Console.WriteLine(mensaje);
        }
    }
}
