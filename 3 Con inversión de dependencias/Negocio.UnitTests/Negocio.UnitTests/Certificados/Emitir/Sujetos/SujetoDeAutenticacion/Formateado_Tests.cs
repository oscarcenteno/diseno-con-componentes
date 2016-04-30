using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.SujetoDeAutenticacion_Tests
{
    [TestClass()]
    public class Formateado_Tests: EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnNacional()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjero()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeAutenticacionParaUnExtranjero();

            InicialiceUnExtranjero();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = Sujetos.UnSujetoDeAutenticacionParaUnExtranjeroConUnSoloApellido();

            InicialiceUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}