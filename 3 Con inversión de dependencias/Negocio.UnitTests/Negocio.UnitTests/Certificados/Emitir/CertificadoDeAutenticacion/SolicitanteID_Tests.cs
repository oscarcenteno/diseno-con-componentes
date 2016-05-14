using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Emitir.CertificadoDeAutenticacion_Tests
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
            elResultadoObtenido = new CertificadoDeAutenticacion(laSolicitud).SolicitanteID;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}