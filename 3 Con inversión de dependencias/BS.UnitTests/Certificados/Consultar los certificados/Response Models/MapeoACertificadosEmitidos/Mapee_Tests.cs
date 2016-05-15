using Microsoft.VisualStudio.TestTools.UnitTesting;
using BS.Certificados.ConsultarLosCertificados;
using System.Collections.Generic;
using DS.Certificados;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace BS.UnitTests.Certificados.ConsultarLosCertificados.ResponseModels.MapeoACertificadosEmitidos_Tests
{
    [TestClass]
    public class Mapee_Tests
    {
        private List<CertificadoEmitido> elResultadoEsperado;
        private List<CertificadoEmitido> elResultadoObtenido;
        private List<RegistroDeCertificado> losRegistros;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = DosCertificadosEmitidos();

            losRegistros = DosRegistrosDeCertificado();
            elResultadoObtenido = MapeoACertificadosEmitidos.Mapee(losRegistros);

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private List<RegistroDeCertificado> DosRegistrosDeCertificado()
        {
            List<RegistroDeCertificado> laLista = new List<RegistroDeCertificado>();
            RegistroDeCertificado unRegistro = new RegistroDeCertificado();
            unRegistro.ID = 1;
            unRegistro.Crl = "El Crl";
            unRegistro.FechaDeEmision = new System.DateTime(2014, 12, 31);
            unRegistro.FechaDeVencimiento = new System.DateTime(2018, 12, 31);
            unRegistro.Sujeto = "El Sujeto";
            laLista.Add(unRegistro);

            RegistroDeCertificado otroRegistro = new RegistroDeCertificado();
            otroRegistro.ID = 2;
            otroRegistro.Crl = "Otro Crl";
            otroRegistro.FechaDeEmision = new System.DateTime(2015, 11, 30);
            otroRegistro.FechaDeVencimiento = new System.DateTime(2019, 11, 30);
            otroRegistro.Sujeto = "Otro Sujeto";
            laLista.Add(otroRegistro);

            return laLista;
        }

        private List<CertificadoEmitido> DosCertificadosEmitidos()
        {
            List<CertificadoEmitido> laLista = new List<CertificadoEmitido>();
            CertificadoEmitido unaEmision = new CertificadoEmitido();
            unaEmision.ID = 1;
            unaEmision.Crl = "El Crl";
            unaEmision.FechaDeEmision = new System.DateTime(2014, 12, 31);
            unaEmision.FechaDeVencimiento = new System.DateTime(2018, 12, 31);
            unaEmision.Sujeto = "El Sujeto";
            laLista.Add(unaEmision);

            CertificadoEmitido otraEmision = new CertificadoEmitido();
            otraEmision.ID = 2;
            otraEmision.Crl = "Otro Crl";
            otraEmision.FechaDeEmision = new System.DateTime(2015, 11, 30);
            otraEmision.FechaDeVencimiento = new System.DateTime(2019, 11, 30);
            otraEmision.Sujeto = "Otro Sujeto";
            laLista.Add(otraEmision);

            return laLista;
        }
    }
}
