using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Negocio.UnitTests.Certificados.Emitir;
using System;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class FechaDeEmision_Tests : EscenariosDeSolicitudes
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod()]
        public void FechaDeEmision_CasoUnico()
        {
            elResultadoEsperado = LaFechaActual();

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).FechaDeEmision;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}