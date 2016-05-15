using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Negocio.UnitTests.Certificados.Emitir.SolicitudDeEmision_Tests
{
    [TestClass]
    public class SujetoDeAutenticacion_Tests : EscenariosDeSolicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void SujetoDeAutenticacion_CasoUnico()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = laSolicitud.SujetoDeAutenticacion;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
