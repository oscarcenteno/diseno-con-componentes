using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace Negocio.UnitTests.Certificados.Emitir.ListaDeCertificados_Tests
{
    [TestClass]
    public class ListaDeCertificados_Tests: EscenariosDeCertificados
    {
        private ListaDeCertificados elResultadoEsperado;
        private ListaDeCertificados elResultadoObtenido;

        [TestInitialize]
        public void Inicialice()
        {
            InicialiceUnNacional();
        }

        [TestMethod]
        public void ListaDeCertificados_Constructor_DosCertificados()
        {
            elResultadoEsperado = DosCertificadosParaUnNacional();

            elResultadoObtenido = new ListaDeCertificados(laSolicitud);

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
