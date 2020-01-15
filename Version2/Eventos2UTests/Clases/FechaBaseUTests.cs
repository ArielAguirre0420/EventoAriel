using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Eventos2.Clases.Tests
{
    [TestClass()]
    public class FechaBaseUTests
    {

        [TestMethod]
        public void ObtenerFechaBase_ObtenerFecha_FechaDiferenteHoy()
        {
            //ARRANGE
            string fecha = "30/08/1997 01:23:21 a. m.";
            var SUT = new FechaBase();

            //ACT
            DateTime resultado = SUT.RecuperaFechaBase(fecha);

            //ASSERT
            Assert.AreEqual(fecha, resultado.ToString());
        }

        [TestMethod]
        public void ObtenerFechaBase_ObtenerFecha_FechaHoy()
        {
            //ARRANGE
            string fecha = "15/01/2020";
            var SUT = new FechaBase();

            //ACT
            DateTime resultado = SUT.RecuperaFechaBase("");

            //ASSERT
            Assert.AreEqual(fecha, resultado.ToString("dd/MM/yyyy"));
        }
    }
}