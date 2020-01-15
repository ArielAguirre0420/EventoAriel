using Eventos2.Clases;
using Eventos2.Controllers;
using Eventos2.DTO;
using Eventos2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Eventos2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Iniciar();
        }

        public static void Iniciar()
        {
            #region Interfacez
            IImprimir msgSimple = new Imprimir();
            IFinaliza FinProgram = new Finaliza();
            ILimpiaConsola limpiarConsola = new LimpiaConsola();
            ILeeConsola leerConsola = new LeeConsola();
            IValidarRuta validarArchivo = new ValidarRuta();
            IValidarFechaEvento validarFecha = new ValidarFechaEvento();
            IObtenerArchivoInfo obtenerInfoArchivo = new ObtenerArchivoInfo(validarFecha);
            IFechaBase fechaBase = new FechaBase();
            IOcurrioEvento eventoOcurrido = new OcurrioEvento();
            IImprimirEvento imprimirMensajeEvento = new ImprimirEvento();
            #endregion

            #region variables
            string msgEventoHaPasado, cValorDiferencia, cRuta, tempDiferencia;
            int iValorDiferencia;
            #endregion

            RecuperaDiferenciaFechaEvento program = new RecuperaDiferenciaFechaEvento(msgSimple, FinProgram, limpiarConsola);

            try
            {
                cRuta = program.LeerRutaArchivo(leerConsola);

                StreamReader sr = program.validarArchivo(validarArchivo, cRuta);

                List<Eventos> lstEventos = program.ObtenerDatosArchivoTxt(obtenerInfoArchivo, sr);

                DateTime FechaBase = program.ObtenerFechaBase(fechaBase, "");

                foreach (var _lstEventos in lstEventos)
                {
                    tempDiferencia = DiferenciaFechas(FechaBase, _lstEventos.dtFechaEvento, program);

                    cValorDiferencia = tempDiferencia.Split(',')[1];

                    iValorDiferencia = int.Parse(tempDiferencia.Split(',')[0]);

                    msgEventoHaPasado = program.EventoOcurrio(eventoOcurrido, iValorDiferencia);

                    imprimirMensajeEvento.ImprimeMensajeEvento(_lstEventos.cNombreEvento, msgEventoHaPasado, cValorDiferencia);
                }

                program.ContinuarOTerminarProgram();
            }
            catch (Exception e)
            {
                msgSimple.ImprimirMensaje(e.Message);
                program.ContinuarOTerminarProgram();
            }

            Iniciar();
        }

        public static string DiferenciaFechas(DateTime _FechaBase, DateTime _dtFechaEvento, RecuperaDiferenciaFechaEvento program)
        {
            IComparaFechas compararDosFechas = new ComparaFechas();
            IObtenerDiferenciaFecha obtenerDiferenciaFechas = new ObtenerDiferenciaFecha(compararDosFechas);

            string valorDiferencia;

            valorDiferencia = program.DiferenciaMeses(obtenerDiferenciaFechas, _FechaBase, _dtFechaEvento);

            return valorDiferencia;
        }
    }
}
