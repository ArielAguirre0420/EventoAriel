using Eventos2.Interfaces;

namespace Eventos2.Clases
{
    public class OcurrioEvento : IOcurrioEvento 
    {
        public string MensajeEventoOcurrio(int _valor)
        {
            string cResultado;

            if (_valor == 0)
            {
                cResultado = "es ahora";
            }
            else
            {
                cResultado = _valor < 0 ? "ocurrió hace" : "ocurrirá dentro de";
            }

            return cResultado;
        }
    }
}
