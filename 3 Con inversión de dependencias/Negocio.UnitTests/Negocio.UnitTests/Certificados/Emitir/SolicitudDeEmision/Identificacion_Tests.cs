using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Negocio.UnitTests.Certificados.Emitir.SolicitudDeEmision_Tests
{
    [TestClass]
    public class Identificacion_Tests : EscenariosDeSolicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Identificacion_CasoUnico()
        {
            elResultadoEsperado = UnaCedulaNacional();

            InicialiceUnNacional();
            elResultadoObtenido = laSolicitud.Identificacion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
