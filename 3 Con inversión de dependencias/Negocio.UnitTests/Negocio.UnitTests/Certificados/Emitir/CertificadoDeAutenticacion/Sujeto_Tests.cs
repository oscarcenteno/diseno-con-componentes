using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;

namespace Emitir.CertificadoDeAutenticacion_Tests
{
    [TestClass()]
    public class Sujeto_Tests : Solicitudes
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void Sujeto_CasoUnico()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new CertificadoDeAutenticacion(laSolicitud).Sujeto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}