using DS.Certificados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;
using BS.Certificados.Emitir.Mapeos;
using Negocio.Certificados.Emitir;

namespace BS.UnitTests.Certificados.Emitir.RequestModels.MapeoDeEmisionARegistroDeEmision_Tests
{
    [TestClass]
    public class Mapee_Tests: EscenariosDeMapeos
    {
        private RegistroDeEmision elResultadoEsperado;
        private RegistroDeEmision elResultadoObtenido;
        private Emision laEmision;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = UnRegistroDeEmision();

            InicialiceUnNacional();
            laEmision = UnaEmision();
            elResultadoObtenido = MapeoDeEmisionARegistroDeEmision.Mapee(laEmision);

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}