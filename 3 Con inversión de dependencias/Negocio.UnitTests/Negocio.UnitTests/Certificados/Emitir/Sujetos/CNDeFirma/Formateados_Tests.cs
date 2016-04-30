using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.CNDeFirma_Tests
{
    [TestClass()]
    public class Formateado_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateado_CasoUnico() 
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (FIRMA)";

            InicialiceUnNacional();
            elResultadoObtenido = new CNDeFirma(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}