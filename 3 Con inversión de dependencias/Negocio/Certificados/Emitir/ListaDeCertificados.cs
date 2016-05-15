using System.Collections.Generic;

namespace Negocio.Certificados.Emitir
{
    public class ListaDeCertificados : List<Certificado>
    {
        public ListaDeCertificados() { }

        public ListaDeCertificados(SolicitudDeEmision laSolicitud)
        {
            Add(new CertificadoDeAutenticacion(laSolicitud));
            Add(new CertificadoDeFirma(laSolicitud));
        }
    }
}