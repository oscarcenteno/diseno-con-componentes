using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Negocio.UnitTests.Certificados.Emitir;
using System;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class FechaDeVencimiento_Tests : EscenariosDeSolicitudes
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod()]
        public void FechaDeVencimiento_CasoUnico()
        {
            elResultadoEsperado = LaFechaDeVencimiento();

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}