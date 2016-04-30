using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.Surname_Tests 
{
    [TestClass()]
    public class ComoTexto_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void ComoTexto_CasoUnico() 
        {
            elResultadoEsperado = "Surname=NAVARRO QUIROS";

            InicialiceUnNacional();
            elResultadoObtenido = new SurName(elSolicitante).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}