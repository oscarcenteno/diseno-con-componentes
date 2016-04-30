using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using System;

namespace Emitir.CertificadoDeAutenticacion_Tests
{
    [TestClass()]
    public class FechaDeEmision_Tests : Solicitudes
    {
        private DateTime elResultadoEsperado;
        private DateTime elResultadoObtenido;

        [TestMethod()]
        public void FechaDeEmision_CasoUnico()
        {
            elResultadoEsperado = new DateTime(2016, 11, 3);

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(laSolicitud).FechaDeEmision;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}