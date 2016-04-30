using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests.CNDeAutenticacion_Tests
{
    [TestClass()]
    public class Formateado_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateado_CasoUnico() 
        {
            elResultadoEsperado = "CN=MARCELINO NAVARRO QUIROS (AUTENTICACION)";

            InicialiceUnNacional();
            elResultadoObtenido = new CNDeAutenticacion(elSolicitante).Formateado();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}