using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class LimpiaConsola : ILimpiaConsola
    {
        public void CleanConsole()
        {
            Console.Clear();
        }
    }
}
