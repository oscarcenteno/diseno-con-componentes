using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests.Solicitante_Tests
{
    [TestClass()]
    public class NombreEnMayusculas_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private Solicitante elSolicitante;

        [TestMethod()]
        public void NombreEnMayusculas_ConMinusculas_TodoEnMayusculas()
        {
            elResultadoEsperado = "DAVID";

            elSolicitante = new SolicitanteNacional();
            elSolicitante.Nombre = "David";
            elResultadoObtenido = elSolicitante.NombreEnMayusculas;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}