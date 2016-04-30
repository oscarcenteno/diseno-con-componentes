using DS.Certificados;
using Negocio.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    public static class RegistroDeCertificadoMapeable
    {
        public static RegistroDeCertificado Mapee(Certificado elCertificado)
        {
            RegistroDeCertificado elRegistro = new RegistroDeCertificado();
            elRegistro.SolicitanteID = elCertificado.SolicitanteID;
            elRegistro.FechaDeEmision = elCertificado.FechaDeEmision;
            elRegistro.FechaDeVencimiento = elCertificado.FechaDeVencimiento;
            elRegistro.Sujeto = elCertificado.Sujeto;
            elRegistro.Crl = elCertificado.Crl;

            return elRegistro;
        }
    }
}