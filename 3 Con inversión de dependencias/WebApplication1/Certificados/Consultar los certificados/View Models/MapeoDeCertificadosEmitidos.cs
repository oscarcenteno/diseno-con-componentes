using BS.Certificados.ConsultarLosCertificados;
using Mapeable;
using System.Collections.Generic;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public static class MapeoDeCertificadosEmitidos
    {
        public static List<CertificadoEmitidoVista> Mapee(List<CertificadoEmitido> losCertificados)
        {
            return new MapeoDeColecciones<CertificadoEmitido, CertificadoEmitidoVista>().Mapee(losCertificados);
        }
    }
}