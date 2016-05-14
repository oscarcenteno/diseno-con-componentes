using Negocio.Certificados.Emitir.Sujetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.Certificados.Emitir;
using NSubstitute;
using System;

[TestClass()]
public abstract class Solicitudes
{
    protected Solicitante elSolicitante;

    protected SolicitudDeEmision laSolicitud;

    protected void InicialiceUnNacional()
    {
        AsigneUnaIdentificacionNacional();
        AsigneUnNombreNacional();
        laSolicitud = Substitute.For<SolicitudDeEmision>(elSolicitante);
        laSolicitud.Crl.Returns("http://pruebas.crl");
        laSolicitud.FechaActual.Returns(new DateTime(2016,11,3));
    }

    private void AsigneUnaIdentificacionNacional()
    {
        elSolicitante = new SolicitanteNacional();
        elSolicitante.Identificacion = "01-0078-5935";
    }

    private void AsigneUnNombreNacional()
    {
        elSolicitante.Nombre = "Marcelino";
        elSolicitante.PrimerApellido = "Navarro";
        elSolicitante.SegundoApellido = "Quiros";
    }
}