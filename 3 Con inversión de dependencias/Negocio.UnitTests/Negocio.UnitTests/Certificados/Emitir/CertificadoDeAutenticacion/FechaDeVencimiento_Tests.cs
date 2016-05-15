using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Negocio.UnitTests.Certificados.Emitir;
using System;

namespace Emitir.CertificadoDeAutenticacion_Tests
{
    [TestClass()]
    public class FechaDeVencimiento_Tests : EscenariosDeSolicitudes
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod()]
        public void FechaDeVencimiento_CasoUnico()
        {
            elResultadoEsperado = new DateTime(2020, 11, 3);

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(laSolicitud).FechaDeVencimiento;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}