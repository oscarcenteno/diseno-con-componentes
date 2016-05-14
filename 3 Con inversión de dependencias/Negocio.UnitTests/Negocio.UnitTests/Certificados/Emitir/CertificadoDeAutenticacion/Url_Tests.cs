using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Emitir.CertificadoDeAutenticacion_Tests
{
    [TestClass()]
    public class Url_Tests : Solicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Url_CasoUnico()
        {
            elResultadoEsperado = "http://pruebas.crl";
             
            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(laSolicitud).Crl;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}