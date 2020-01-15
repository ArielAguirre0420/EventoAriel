using System.IO;

namespace Eventos2.Interfaces
{
    public interface IValidarRuta
    {
        StreamReader ExisteArchivo(string Ruta);
    }
}
