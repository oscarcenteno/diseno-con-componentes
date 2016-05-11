using System.Collections.Generic;
using BS.Certificados.ConsultarLosCertificados;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public class ListaDeCertificadosEmitidosVista : List<CertificadoEmitidoVista>
    {
        public ListaDeCertificadosEmitidosVista(List<CertificadoEmitido> losCertificados)
        {
            foreach (CertificadoEmitido elCertificado in losCertificados)
            {
                Add(new CertificadoEmitidoVista(elCertificado));
            }
        }
    }
}