using Capacitacion_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Capacitacion_SOLID.Clases
{
    public class ObtenerArchivoInfo :  IArchivos
    {
        private readonly IImprimir printsimple;

        public ObtenerArchivoInfo(IImprimir Printsimple)
        {
            printsimple = Printsimple;
        }

        public List<Evento> FomatearDatosArchivo(StreamReader _sr, List<Evento> _datos)
        {
            string linea;
            int cont = 0;
            try
            {
                while ((linea = _sr.ReadLine()) != null)
                {
                    string cnombre = linea.Split(',')[0];
                    DateTime dtFechaEvento = DateTime.Parse(linea.Split(',')[1]);

                    _datos.Add(new Evento
                    {
                        cNombreEvento = cnombre,
                        dtFechaEvento = dtFechaEvento
                    });

                    cont++;
                }
            }
            catch (Exception) { printsimple.print("El formato de los datos del archivo no es el correcto"); }
            return _datos;
        }

        public List<Evento> LeerArchivo(string _rutaArchivo)
        {
            List<Evento> datos = new List<Evento>();
            try
            {
                StreamReader sr = new StreamReader(_rutaArchivo);

                datos = FomatearDatosArchivo(sr, datos);

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                printsimple.print("No se encontró el archivo, introduzca una ruta valida");
            }
            catch (NotSupportedException)
            {
                printsimple.print("No se puede leer el archivo");
            }
            catch (ArgumentException)
            {
                printsimple.print("Debe de Ingresar una ruta");
            }

            return datos;
        }

        public string ObtenerRutaArchivo()
        {
            string ruta;

            printsimple.print("Ingrese la ruta de su archivo");

            ruta = Console.ReadLine();

            return ruta;
        }
    }
}
