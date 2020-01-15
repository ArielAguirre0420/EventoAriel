using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class Imprimir : IImprimir 
    {
        public void ImprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
