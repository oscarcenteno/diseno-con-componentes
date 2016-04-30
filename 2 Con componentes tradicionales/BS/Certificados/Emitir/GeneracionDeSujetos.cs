using Models;

namespace BS
{
    public static class GeneracionDeSujetos
    {
        public static string GenereElSujeto(string laIdentificacion,
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