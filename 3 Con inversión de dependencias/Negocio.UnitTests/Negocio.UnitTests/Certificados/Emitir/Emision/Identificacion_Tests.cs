using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Negocio.UnitTests.Certificados.Emitir.Emision_Tests
{
    [TestClass]
    public class Identificacion_Tests : EscenariosDeCertificados
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestInitialize]
        public void Inicialice()
        {
            InicialiceUnNacional();
        }

        [TestMethod]
        public void Identificacion_CasoUnico()
        {
            elResultadoEsperado = UnaCedulaNacional();

            elResultadoObtenido = new Emision(laSolicitud).Identificacion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}