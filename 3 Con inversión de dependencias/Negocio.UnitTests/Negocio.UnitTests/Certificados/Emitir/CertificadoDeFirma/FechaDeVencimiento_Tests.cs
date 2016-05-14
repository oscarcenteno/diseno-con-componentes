using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using System;

namespace Emitir.CertificadoDeFirma_Tests
{
    [TestClass()]
    public class FechaDeVencimiento_Tests : Solicitudes
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod()]
        public void FechaDeVencimiento_CasoUnico()
        {
            elResultadoEsperado = new DateTime(2020, 11, 3);

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeFirma(laSolicitud).FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}