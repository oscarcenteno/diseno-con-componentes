using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests
{
    [TestClass()]
    public class Formateados_Tests : DatosParaPruebasDeSujetos
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