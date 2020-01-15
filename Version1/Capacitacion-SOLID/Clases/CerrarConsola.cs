using Capacitacion_SOLID.Interfaces;
using System;

namespace Capacitacion_SOLID.Clases
{
    public class CerrarConsola : ICerrarConsola 
    {
        public void CierraConsola()
        {
            Environment.Exit(-1);
        }
    }
}
