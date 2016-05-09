using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sujetos_Tests.Solicitante_Tests
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