using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class ImprimirEvento : IImprimirEvento 
    {
        public void ImprimeMensajeEvento(string cEvento, string cEventoHaPasado, string cDiferenciaFechas)
        {
            string mensaje = "El evento " + cEvento + " " + cEventoHaPasado + " " + cDiferenciaFechas;
            Console.WriteLine(mensaje);
        }
    }
}
