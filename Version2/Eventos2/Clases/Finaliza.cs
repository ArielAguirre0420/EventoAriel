using Eventos2.Interfaces;
using System;

namespace Eventos2.Clases
{
    public class Finaliza : IFinaliza 
    {
        public void CerrarConsola()
        {
            Environment.Exit(-1);
        }
    }
}
