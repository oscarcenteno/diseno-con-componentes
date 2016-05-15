using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Negocio.UnitTests.Certificados.Emitir.SolicitudDeEmision_Tests
{
    [TestClass]
    public class SujetoDeFirma_Tests : EscenariosDeSolicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void SujetoDeFirma_CasoUnico()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = laSolicitud.SujetoDeAutenticacion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
