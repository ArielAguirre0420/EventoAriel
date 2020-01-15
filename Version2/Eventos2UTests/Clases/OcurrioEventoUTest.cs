using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eventos2.Clases.Tests
{
    [TestClass()]
    public class OcurrioEventoUTest
    {
        [TestMethod()]
        public void MensajeEventoOcurrio_ObtenerMensajeCorrecto_ValoresPositivos()
        {
            //Arrange
            string ResultadoEsperado = "ocurrirá dentro de";
            var SUT = new OcurrioEvento();

            //Act
            var cResultado = SUT.MensajeEventoOcurrio(1);

            //Assert
            Assert.AreEqual(ResultadoEsperado, cResultado);
        }

        [TestMethod]
        public void MensajeEventoOcurrio_ObtenerMensajeCorrecto_ValoresNegativos()
        {
            //Arrange
            string ResultadoEsperado = "ocurrió hace";
            var SUT = new OcurrioEvento();

            //Act
            var cResultado = SUT.MensajeEventoOcurrio(-1);

            //Assert
            Assert.AreEqual(ResultadoEsperado, cResultado);
        }

        [TestMethod]
        public void MensajeEventoOcurrio_ObtenerMensajeCorrecto_ValorenCero()
        {
            //Arrange
            string ResultadoEsperado = "es ahora";
            var SUT = new OcurrioEvento();
            //Act
            var cResultado = SUT.MensajeEventoOcurrio(0);
            //Assert
            Assert.AreEqual(ResultadoEsperado, cResultado);
        }
    }
}