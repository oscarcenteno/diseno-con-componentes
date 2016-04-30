using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetosConPolimorfismo_Tests.SolicitanteExtranjero_Tests
{
    [TestClass()]
    public class OU_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void OU_CasoUnico() 
        {
            elResultadoEsperado = "OU=EXTRANJERO";

            InicialiceUnExtranjero();
            elResultadoObtenido = elSolicitante.OU;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}