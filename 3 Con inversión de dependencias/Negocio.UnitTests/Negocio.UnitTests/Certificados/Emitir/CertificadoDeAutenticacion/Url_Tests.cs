using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Negocio.UnitTests.Certificados.Emitir;

namespace Emitir.CertificadoDeAutenticacion_Tests
{
    [TestClass()]
    public class Url_Tests : EscenariosDeSolicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Url_CasoUnico()
        {
            elResultadoEsperado = UnCrl();
             
            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(laSolicitud).Crl;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}