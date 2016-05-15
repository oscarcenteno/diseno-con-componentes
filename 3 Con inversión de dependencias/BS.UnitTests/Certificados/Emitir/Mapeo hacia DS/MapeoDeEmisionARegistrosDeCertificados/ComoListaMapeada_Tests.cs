using BS.Certificados.Emitir.MapeoHaciaDS;
using DS.Certificados;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using System.Collections.Generic;

namespace BS.UnitTests.Certificados.Emitir.RequestModels.MapeoDeEmisionARegistrosDeCertificados_Tests
{
    [TestClass]
    public class ComoListaMapeada_Tests : EscenariosDeMapeos
    {
        private List<RegistroDeCertificado> elResultadoEsperado;
        private List<RegistroDeCertificado> elResultadoObtenido;
        private Emision laEmision;

        [TestMethod]
        public void ComoListaMapeada_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = DosRegistrosDeCertificados();

            InicialiceUnNacional();
            laEmision = new Emision(laSolicitud);
            elResultadoObtenido = new MapeoDeEmisionARegistrosDeCertificados(laEmision).ComoListaMapeada();

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}