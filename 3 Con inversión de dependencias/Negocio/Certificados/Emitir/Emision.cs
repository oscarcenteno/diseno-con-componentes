using System.Collections.Generic;

namespace Negocio.Certificados.Emitir
{
    public class Emision
    {
        private string laIdentificacion;
        private List<Certificado> losCertificados;

        public Emision(SolicitudDeEmision laSolicitud)
        {
            laIdentificacion = ObtengaLaIdentificacion(laSolicitud);
            losCertificados = ObtengaLosCertificados(laSolicitud);
        }

        private string ObtengaLaIdentificacion(SolicitudDeEmision laSolicitud)
        {
            return laSolicitud.Identificacion;
        }

        private List<Certificado> ObtengaLosCertificados(SolicitudDeEmision laSolicitud)
        {
            return new ListaDeCertificados(laSolicitud);
        }

        public List<Certificado> Certificados
        {
            get
            {
                return losCertificados;
            }
        }

        public string Identificacion
        {
            get
            {
                return laIdentificacion;
            }
        }
    }
}