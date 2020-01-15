using Capacitacion_SOLID.Interfaces;
using System;

namespace Capacitacion_SOLID.Clases
{
    public class Imprimir : IImprimir 
    {
        public void print(string _Mensajes)
        {
            Console.WriteLine(_Mensajes);
        }
    }
}
