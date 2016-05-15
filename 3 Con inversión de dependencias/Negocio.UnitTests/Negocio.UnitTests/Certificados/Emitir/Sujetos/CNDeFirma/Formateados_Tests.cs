using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests.CNDeFirma_Tests
{
    [TestClass()]
    public class Formateado_Tests : DatosParaPruebasDeSujetos
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