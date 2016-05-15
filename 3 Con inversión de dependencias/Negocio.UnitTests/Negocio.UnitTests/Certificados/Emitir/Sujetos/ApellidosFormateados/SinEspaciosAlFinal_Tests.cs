using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests
{
    [TestClass()]
    public class SinEspaciosAlFinal_Tests : DatosParaPruebasDeSujetos
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