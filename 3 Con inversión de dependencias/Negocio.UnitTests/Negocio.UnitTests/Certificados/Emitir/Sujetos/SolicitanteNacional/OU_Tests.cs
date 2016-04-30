using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetosConPolimorfismo_Tests.SolicitanteNacional_Tests
{
    [TestClass()]
    public class OU_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void OU_CasoUnico() 
        {
            elResultadoEsperado = "OU=CIUDADANO";

            InicialiceUnNacional();
            elResultadoObtenido = elSolicitante.OU;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}