using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests
{
    [TestClass()]
    public class SinEspaciosAlFinal_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void SinEspaciosAlFinal_CasoUnico()
        {
            elResultadoEsperado = "SMITH";

            InicialiceUnExtranjeroConUnSoloApellido();
            elResultadoObtenido = new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}