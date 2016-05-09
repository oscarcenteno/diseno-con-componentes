using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sujetos;

namespace Sujetos_Tests
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