using Eventos2.DTO;
using System.Collections.Generic;
using System.IO;

namespace Eventos2.Interfaces
{
    public interface IObtenerArchivoInfo
    {
         List<Eventos> ObtenerDatosArchivo(StreamReader archivo);
    }
}
