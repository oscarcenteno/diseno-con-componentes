using System.Collections.Generic;

namespace Negocio.Certificados.Emitir
{
    public class ListaDeCertificados : List<Certificado>
    {
        public ListaDeCertificados(SolicitudDeEmision laSolicitud)
        {
            Add(new CertificadoDeFirma(laSolicitud));
            Add(new CertificadoDeAutenticacion(laSolicitud));
        }
    }
}