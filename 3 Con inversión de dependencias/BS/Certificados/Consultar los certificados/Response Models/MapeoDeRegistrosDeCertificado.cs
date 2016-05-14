using System.Collections.Generic;
using DS.Certificados;
using Mapeable;

namespace BS.Certificados.ConsultarLosCertificados
{
    public class MapeoDeRegistrosDeCertificado
    {
        public static List<CertificadoEmitido> Mapee(List<RegistroDeCertificado> losRegistros)
        {
            return new MapeoDeColecciones<RegistroDeCertificado, CertificadoEmitido>().Mapee(losRegistros);
        }
    }
}
