using DS.Certificados.Emitir;
using Models.Certificados;
using System;
using System.Collections.Generic;

namespace BS
{
    public class EmisorDeCertificados
    {
        public void EmitaLosCertificados(DatosDelSolicitante losDatos)
        {
            RepositorioDeCertificados elRepositorio;
            elRepositorio = new RepositorioDeCertificados();

            List<RegistroDeCertificado> losCertificados;
            losCertificados = GenereLosCertificados(losDatos);

            RegistroDeEmision laEmision = new RegistroDeEmision();
            laEmision.Identificacion = losDatos.Identificacion;
            laEmision.RegistrosDeCertificados = losCertificados;

            elRepositorio.Agregue(laEmision);
        }

        private List<RegistroDeCertificado> GenereLosCertificados(DatosDelSolicitante losDatos)
        {
            DateTime laFechaActual = DateTime.Now;
            DateTime laFechaDeVencimiento = laFechaActual.AddYears(4);

            List<RegistroDeCertificado> losCertificados = new List<RegistroDeCertificado>();

            RegistroDeCertificado elDeFirma = new RegistroDeCertificado();
            elDeFirma.SolicitanteID = losDatos.Identificacion;
            elDeFirma.Sujeto = GenereElSujeto(losDatos.Identificacion,
                losDatos.Nombre,
                losDatos.PrimerApellido,
                losDatos.SegundoApellido,
                losDatos.TipoDeIdentificacion,
                TipoDeCertificado.DeFirma);
            elDeFirma.FechaDeEmision = laFechaActual;
            elDeFirma.FechaDeVencimiento = laFechaDeVencimiento;

            RepositorioDeCertificados elRepositorio = new RepositorioDeCertificados();
            elDeFirma.Crl = elRepositorio.ObtengaElCrl();

            RegistroDeCertificado elDeAutenticacion = new RegistroDeCertificado();
            elDeAutenticacion.SolicitanteID = losDatos.Identificacion;
            elDeAutenticacion.Sujeto = GenereElSujeto(losDatos.Identificacion,
                losDatos.Nombre,
                losDatos.PrimerApellido,
                losDatos.SegundoApellido,
                losDatos.TipoDeIdentificacion,
                TipoDeCertificado.DeAutenticacion);
            elDeAutenticacion.FechaDeEmision = laFechaActual;
            elDeAutenticacion.FechaDeVencimiento = laFechaDeVencimiento;
            elDeAutenticacion.Crl = elRepositorio.ObtengaElCrl();

            losCertificados.Add(elDeFirma);
            losCertificados.Add(elDeAutenticacion);

            return losCertificados;
        }

        private static string GenereElSujeto(string laIdentificacion,
            string elNombre,
            string elPrimerApellido,
            string elSegundoApellido,
            TipoDeIdentificacion elTipoDeIdentificacion,
            TipoDeCertificado elTipo)
        {
            string elNombreEnMayuscula;
            elNombreEnMayuscula = elNombre.ToUpper();

            string elPrimerApellidoEnMayuscula;
            elPrimerApellidoEnMayuscula = elPrimerApellido.ToUpper();

            string elSegundoApellidoEnMayuscula;
            if (string.IsNullOrEmpty(elSegundoApellido))
                elSegundoApellidoEnMayuscula = string.Empty;
            else
                elSegundoApellidoEnMayuscula = elSegundoApellido.ToUpper();

            string losApellidosUnidos;
            losApellidosUnidos = $"{elPrimerApellidoEnMayuscula} {elSegundoApellidoEnMayuscula}";

            string losApellidosFormateados;
            losApellidosFormateados = losApellidosUnidos.TrimEnd();

            string elProposito;
            if (elTipo == TipoDeCertificado.DeFirma)
                elProposito = "FIRMA";
            else
                elProposito = "AUTENTICACION";

            string elCN;
            elCN = $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";

            string elOU;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elOU = "OU=CIUDADANO";
            else
                elOU = "OU=EXTRANJERO";

            string elO;
            elO = "O=PERSONA FISICA";

            string elC;
            elC = "C=CR";

            string elGivenName;
            elGivenName = "GivenName=" + elNombreEnMayuscula;

            string elSurname;
            elSurname = $"Surname={losApellidosFormateados}";

            string elSerialNumber;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elSerialNumber = $"SERIALNUMBER=CPF-{laIdentificacion}";
            else
                elSerialNumber = $"SERIALNUMBER=NUP-{laIdentificacion}";

            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }
    }
}