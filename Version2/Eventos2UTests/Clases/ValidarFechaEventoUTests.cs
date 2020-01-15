using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eventos2.Clases.Test
{
    [TestClass()]
    public class ValidarFechaEventoUTests
    {
        [TestMethod()]
        public void ValidarFechaEvento_ValidarFecha_FechaIncorrecta()
        {
            //Arrange
            ValidarFechaEvento validarFecha = new ValidarFechaEvento();
            var SUT = new ValidarFechaEvento();

            //ACT
            var resultado = SUT.ValidaFechaEvento("26/12/2020");

            //ASSERT
            Assert.IsNotNull(resultado);
        }
    }
}