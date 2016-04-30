using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class Sujeto_Tests : Solicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Sujeto_CasoUnico()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeFirmaParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}