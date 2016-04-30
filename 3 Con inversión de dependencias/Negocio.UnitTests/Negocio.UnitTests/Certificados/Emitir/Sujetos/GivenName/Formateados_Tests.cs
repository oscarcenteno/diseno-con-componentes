using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.GivenName_Tests
{
    [TestClass()]
    public class ComoTexto_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void ComoTexto_CasoUnico() 
        {
            elResultadoEsperado = "GivenName=MARCELINO";

            InicialiceUnNacional();
            elResultadoObtenido = new GivenName(elSolicitante).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}