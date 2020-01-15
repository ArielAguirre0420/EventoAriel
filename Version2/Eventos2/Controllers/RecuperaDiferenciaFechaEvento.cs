using Eventos2.DTO;
using Eventos2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Eventos2.Controllers
{
    public class RecuperaDiferenciaFechaEvento
    {
        private IImprimir msgSimple;
        private IFinaliza FinProgram;
        private ILimpiaConsola limpiarConsola;

        public RecuperaDiferenciaFechaEvento(IImprimir _msgSimple, IFinaliza _FinProgram, ILimpiaConsola _limpiarConsola)
        {
            msgSimple = _msgSimple;
            FinProgram = _FinProgram;
            limpiarConsola = _limpiarConsola;

            return;
        }

        public string LeerRutaArchivo(ILeeConsola leer)
        {
            msgSimple.ImprimirMensaje("Ingrese la ruta del archivo");
            string cRuta = leer.LeerConsola();

            return cRuta;
        }

        public StreamReader validarArchivo(IValidarRuta validarArchivo, string cRuta)
        {
            try
            {
                StreamReader sr = validarArchivo.ExisteArchivo(cRuta);
                return sr;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Eventos> ObtenerDatosArchivoTxt(IObtenerArchivoInfo ObtenerArchivoInfo, StreamReader sr)
        {
            try
            {
                List<Eventos> lstEventos = ObtenerArchivoInfo.ObtenerDatosArchivo(sr);
                return lstEventos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                //msgSimple.PrintMensajeSimple(e.Message);
            }
        }

        public DateTime ObtenerFechaBase(IFechaBase fechaBase, string _FechaEspecifica)
        {
            try
            {
                DateTime FechaEspecifica = fechaBase.RecuperaFechaBase(_FechaEspecifica);
                return FechaEspecifica;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string DiferenciaMeses(IObtenerDiferenciaFecha obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaMes(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = DiferenciaDias(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " mes";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " meses";
                    break;
            }

            return cResultado;
        }

        public string DiferenciaDias(IObtenerDiferenciaFecha obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaDias(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = DiferenciaHoras(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " día";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " días";
                    break;
            }

            return cResultado;
        }

        public string DiferenciaHoras(IObtenerDiferenciaFecha obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaHoras(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = DiferenciaMinutos(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " hora";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " horas";
                    break;
            }

            return cResultado;
        }

        public string DiferenciaMinutos(IObtenerDiferenciaFecha obtenerDiferenciaFechas, DateTime _FechaBase, DateTime _dtFechaEvento)
        {
            string cResultado;
            int valor = obtenerDiferenciaFechas.ObtenerDiferenciaMinutos(_FechaBase, _dtFechaEvento);

            switch (Math.Abs(valor))
            {
                case 0:
                    cResultado = valor + ", ";
                    break;
                case 1:
                    cResultado = valor + "," + Math.Abs(valor) + " minuto";
                    break;
                default:
                    cResultado = valor + "," + Math.Abs(valor) + " minutos";
                    break;
            }

            return cResultado;
        }

        public string EventoOcurrio(IOcurrioEvento eventoOcurrio, int iValor)
        {
            string cResultado = eventoOcurrio.MensajeEventoOcurrio(iValor);

            return cResultado;
        }

        public void ContinuarOTerminarProgram()
        {
            msgSimple.ImprimirMensaje("Presione cualquier tecla para continuar o 0 <cero> para cerrar la consola");
            string cRespuesta = Console.ReadLine();
            if (cRespuesta != "0")
            {
                limpiarConsola.CleanConsole();
            }
            else
            {
                FinProgram.CerrarConsola();
            }
        }
    }
}
