using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Moq;
using Capacitacion_SOLID.Interfaces;

namespace Capacitacion_SOLID.Clases.Tests
{
    [TestClass()]
    public class ObtenerArchivoInfoUTests
    {
        [TestMethod()]
        public void LeerArchivoTest()
        {
            //Arrange 
            List<Evento> lstEventos = GenerarEventosPrueba(5);
            var DOCIConvertidorAEvento = new Mock<IArchivos>();
           // DOCIConvertidorAEvento.Setup(l => l.LeerArchivo(It.IsAny<List<string>>())).Returns(lstEventos);


            //Act

            //Assert
            Assert.Fail();
        }

        private List<Evento> GenerarEventosPrueba(int v)
        {
            throw new NotImplementedException();
        }
    }
}