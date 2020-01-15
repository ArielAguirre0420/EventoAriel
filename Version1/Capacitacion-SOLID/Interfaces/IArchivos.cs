using Capacitacion_SOLID.Clases;
using System.Collections.Generic;
using System.IO;

namespace Capacitacion_SOLID.Interfaces
{
    public interface IArchivos
    {
        string ObtenerRutaArchivo();
        List<Evento> LeerArchivo(string _rutaArchivo);
        List<Evento> FomatearDatosArchivo(StreamReader _sr, List<Evento> _datos);
    }
}
