using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sujetos_Tests.Solicitante_Tests
{
    [TestClass()]
    public class SerialNumber_Tests : DatosParaPruebasDeSujetos
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