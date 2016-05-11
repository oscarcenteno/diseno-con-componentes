using System.Collections.Generic;
using DS.Certificados;
using Negocio.Certificados.Emitir;

namespace BS.Certificados.Emitir.MapeoHaciaDS
{
    public class ListaDeRegistrosDeCertificados : List<RegistroDeCertificado>
    {
        public ListaDeRegistrosDeCertificados(List<Certificado> losCertificados)
        {
            foreach (Certificado elCertificado in losCertificados)
            {
                RegistroDeCertificado elRegistro = Mapee(elCertificado);
                Add(elRegistro);
            }
        }

        public static RegistroDeCertificado Mapee(Certificado elCertificado)
        {
            return MapeoARegistroDeCertificado.Mapee(elCertificado);
        }
    }
}