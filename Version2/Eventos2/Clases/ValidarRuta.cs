using Eventos2.Interfaces;
using System;
using System.IO;

namespace Eventos2.Clases
{
    public class ValidarRuta : IValidarRuta 
    {
        public StreamReader ExisteArchivo(string Ruta)
        {
            try
            {
                StreamReader sr = new StreamReader(Ruta);

                return sr;
            }
            catch (Exception)
            {
                throw new Exception("El archivo no fue encontrado");
            }
        }
    }
}
