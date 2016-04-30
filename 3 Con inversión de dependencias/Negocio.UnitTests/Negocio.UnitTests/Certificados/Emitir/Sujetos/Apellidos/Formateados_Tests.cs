using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests
{
    [TestClass()]
    public class Formateados_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void Formateados_CasoUnico()
        {
            elResultadoEsperado = "NAVARRO QUIROS";

            InicialiceUnNacional();
            elResultadoObtenido = new Apellidos(elSolicitante).Formateados();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}