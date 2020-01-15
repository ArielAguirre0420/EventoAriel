using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class LeeConsola : ILeeConsola 
    {
        public string LeerConsola()
        {
            string Lectura = Console.ReadLine();

            return Lectura;
        }
    }
}
