using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace Negocio.UnitTests.Certificados.Emitir.Emision_Tests
{
    [TestClass]
    public class Certificados_Tests : EscenariosDeCertificados
    {
        private ListaDeCertificados elResultadoEsperado;
        private ListaDeCertificados elResultadoObtenido;

        [TestInitialize]
        public void Inicialice()
        {
            InicialiceUnNacional();
        }

        [TestMethod]
        public void Certificados_CasoUnico_DosCertificados()
        {
            elResultadoEsperado = DosCertificadosParaUnNacional();

            elResultadoObtenido = new Emision(laSolicitud).Certificados;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
