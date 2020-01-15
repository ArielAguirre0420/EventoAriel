using Eventos2.DTO;
using Eventos2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Eventos2.Clases
{
    public class ObtenerArchivoInfo : IObtenerArchivoInfo
    {
        private IValidarFechaEvento validarFecha;
        public ObtenerArchivoInfo(IValidarFechaEvento _validarFecha)
        {
            validarFecha = _validarFecha;
        }

        public List<Eventos> ObtenerDatosArchivo(StreamReader archivo)
        {
            List<Eventos> lstEventos = new List<Eventos>();
            string linea;
            int cont = 0;

            try
            {
                while ((linea = archivo.ReadLine()) != null)
                {
                    string cnombre = linea.Split(',')[0];
                    string fechatemp = linea.Split(',')[1];

                    DateTime dtFechaEvento = validarFecha.ValidaFechaEvento(fechatemp);

                    lstEventos.Add(new Eventos
                    {
                        cNombreEvento = cnombre,
                        dtFechaEvento = dtFechaEvento
                    });

                    cont++;
                }

                archivo.ReadLine();

                return lstEventos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
