using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetosConPolimorfismo_Tests.SolicitanteNacional_Tests
{
    [TestClass()]
    public class SerialNumber_Tests : EscenarioBase_Tests
    {
        [TestMethod()]
        public void OU_CasoUnico() 
        {
            elResultadoEsperado = "SERIALNUMBER=CPF-01-0078-5935";

            InicialiceUnNacional();
            elResultadoObtenido = elSolicitante.SerialNumber;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}