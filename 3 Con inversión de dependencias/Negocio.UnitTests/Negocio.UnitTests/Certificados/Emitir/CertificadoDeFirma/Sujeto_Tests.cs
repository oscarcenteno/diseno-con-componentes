using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Negocio.UnitTests.Certificados.Emitir;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class Sujeto_Tests : EscenariosDeSolicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Sujeto_CasoUnico()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeFirmaParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}