using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests.CNDeAutenticacion_Tests
{
    [TestClass()]
    public class Formateado_Tests : DatosParaPruebasDeSujetos
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