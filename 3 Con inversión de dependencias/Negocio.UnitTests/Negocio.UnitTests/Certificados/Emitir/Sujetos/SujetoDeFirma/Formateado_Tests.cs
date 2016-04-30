using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.SujetoDeFirma_Tests
{
    [TestClass()]
    public class Formateado_Tests: EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateado_DeFirmaParaUnNacional()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeFirmaParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new SujetoDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnExtranjero()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeFirmaParaUnExtranjero();

            InicialiceUnExtranjero();
            elResultadoObtenido = new SujetoDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeFirmaParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeFirmaParaUnExtranjeroConUnSoloApellido();

            InicialiceUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new SujetoDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}