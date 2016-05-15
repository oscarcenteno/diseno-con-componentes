using BS.Certificados.ConsultarLosCertificados.ResponseModels;
using Mapeable;
using System.Collections.Generic;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public static class MapeoACertificadosEmitidosVista
    {
        public static List<CertificadoEmitidoVista> Mapee(List<CertificadoEmitido> losCertificados)
        {
            return new MapeoDeColecciones<CertificadoEmitido, CertificadoEmitidoVista>().Mapee(losCertificados);
        }
    }
}