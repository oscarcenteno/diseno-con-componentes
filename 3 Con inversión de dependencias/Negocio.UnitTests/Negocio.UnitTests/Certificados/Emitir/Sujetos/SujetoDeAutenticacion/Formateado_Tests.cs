using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests.SujetoDeAutenticacion_Tests
{
    [TestClass()]
    public class Formateado_Tests: EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnNacional()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnNacional();

            InicialiceUnNacional();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjero()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnExtranjero();

            InicialiceUnExtranjero();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void Formateado_DeAutenticacionParaUnExtranjeroConUnSoloApellido()
        {
            elResultadoEsperado = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnExtranjeroConUnSoloApellido();

            InicialiceUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new SujetoDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}