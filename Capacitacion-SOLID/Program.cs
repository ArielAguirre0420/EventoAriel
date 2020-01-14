using Capacitacion_SOLID.Clases;
using Capacitacion_SOLID.Interfaces;

namespace Capacitacion_SOLID
{

    public class Program
    {
        public static void Main(string[] args)
        {
            IImprimir nuevoimprime = new Imprimir();
            IArchivos nuevoArchivo = new ObtenerArchivoInfo(nuevoimprime);
            ObtenerFechaDiferenteEvento nuevo = new ObtenerFechaDiferenteEvento(nuevoArchivo);

            nuevo.ObtenerEventosPasadosFuturos();

        }
    }
}