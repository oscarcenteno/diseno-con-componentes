using System.Collections.Generic;
using DS.Certificados;
using Negocio.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    public class MapeoDeRegistrosDeCertificados
    {
        public static List<RegistroDeCertificado> Mapee(List<Certificado> losCertificados)
        {
            List<RegistroDeCertificado> losRegistros = new List<RegistroDeCertificado>();

            foreach (Certificado elCertificado in losCertificados)
            {
                RegistroDeCertificado elRegistro = Mapee(elCertificado);
                losRegistros.Add(elRegistro);
            }

            return losRegistros;
        }

        public static RegistroDeCertificado Mapee(Certificado elCertificado)
        {
            return RegistroDeCertificadoMapeable.Mapee(elCertificado);
        }
    }
}