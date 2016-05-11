using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir.Sujetos;

namespace Sujetos_Tests.Solicitante_Tests
{
    [TestClass()]
    public class Apellidos_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private Solicitante elSolicitante;

        [TestMethod()]
        public void Apellidos_DosApellidos_ApellidosUnidos()
        {
            elResultadoEsperado = "Sánchez Navarro";

            elSolicitante = new SolicitanteNacional();
            elSolicitante.PrimerApellido = "Sánchez";
            elSolicitante.SegundoApellido = "Navarro";
            elResultadoObtenido = elSolicitante.Apellidos;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}