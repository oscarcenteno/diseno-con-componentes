using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests.SujetoDeFirma_Tests
{
    [TestClass()]
    public class Formateado_Tests: DatosParaPruebasDeSujetos
    {
        [TestMethod()]
        public void Formateado_DeFirmaParaUnNacional()
        {
            elResultadoEsperado = global::EscenariosDeSujetos.UnSujetoDeFirmaParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new SujetoDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnExtranjero()
        {
            elResultadoEsperado = global::EscenariosDeSujetos.UnSujetoDeFirmaParaUnExtranjero();

            InicialiceUnExtranjero();
            elResultadoObtenido = new SujetoDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = global::EscenariosDeSujetos.UnSujetoDeFirmaParaUnExtranjeroConUnSoloApellido();

            InicialiceUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new SujetoDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}