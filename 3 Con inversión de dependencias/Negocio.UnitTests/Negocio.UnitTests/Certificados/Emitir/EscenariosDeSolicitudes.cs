using Negocio.Certificados.Emitir.Sujetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using NSubstitute;
using System;

namespace Negocio.UnitTests.Certificados.Emitir
{
    [TestClass()]
    public abstract class EscenariosDeSolicitudes
    {
        protected Solicitante elSolicitante;
        protected SolicitudDeEmision laSolicitud;

        protected string UnaCedulaNacional()
        {
            return "01-0078-5935";
        }

        protected void InicialiceUnNacional()
        {
            AsigneUnaIdentificacionNacional();
            AsigneUnNombreNacional();
            laSolicitud = Substitute.For<SolicitudDeEmision>(elSolicitante);
            laSolicitud.Crl.Returns(UnCrl());
            laSolicitud.FechaActual.Returns(LaFechaActual());
        }

        protected DateTime LaFechaActual()
        {
            return new DateTime(2016, 11, 3);
        }

        protected DateTime LaFechaDeVencimiento()
        {
            return new DateTime(2020, 11, 3);
        }

        protected string UnCrl()
        {
            return "http://pruebas.crl";
        }

        private void AsigneUnaIdentificacionNacional()
        {
            elSolicitante = new SolicitanteNacional();
            elSolicitante.Identificacion = UnaCedulaNacional();
        }

        private void AsigneUnNombreNacional()
        {
            elSolicitante.Nombre = "Marcelino";
            elSolicitante.PrimerApellido = "Navarro";
            elSolicitante.SegundoApellido = "Quiros";
        }
    }
}