using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetosConPolimorfismo_Tests.SolicitanteExtranjero_Tests
{
    [TestClass()]
    public class SerialNumber_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void OU_CasoUnico() 
        {
            elResultadoEsperado = "SERIALNUMBER=NUP-114145540011";

            InicialiceUnExtranjero();
            elResultadoObtenido = elSolicitante.SerialNumber;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}