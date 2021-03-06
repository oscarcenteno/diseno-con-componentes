﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Certificados.DS.MapeosABaseDeDatos;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;
using Certificados.DS.UnitTests.MapeosABaseDeDatos;

namespace Certificados.DS.UnitTests.MapeosABaseDeDatos_Tests.RegistroDeEmision_Tests
{
    [TestClass]
    public class CertificadoDeAutenticacion_Tests : EscenariosDeLaEmision
    {
        private RegistroDeCertificado elResultadoEsperado;
        private RegistroDeCertificado elResultadoObtenido;
        private Emision laEmision;

        [TestMethod]
        public void CertificadoDeAutenticacion_UnaEmision_RegistroDelCertificadoDeAutenticacion()
        {
            elResultadoEsperado = ObtengaUnRegistroDeCertificadoNacionalDeAutenticacion();

            laEmision = ObtengaUnaEmisionNacional();
            elResultadoObtenido = new RegistroDeEmision(laEmision).CertificadoDeAutenticacion;

            Verificacion.SonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}