using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class SolicitanteID_Tests : Solicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void SolicitanteID_CasoUnico()
        {
            elResultadoEsperado = "01-0078-5935";

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).SolicitanteID;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}