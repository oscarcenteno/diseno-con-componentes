using System.Collections.Generic;

namespace Negocio.Certificados.Emitir
{
    public class Emision
    {
        private SolicitudDeEmision laSolicitud;

        public Emision(SolicitudDeEmision laSolicitud)
        {
            this.laSolicitud = laSolicitud;
        }

        public List<Certificado> Certificados
        {
            get
            {
            return new ListaDeCertificados(laSolicitud);
            }
        }

        public string Identificacion
        {
            get
            {
                return laSolicitud.Identificacion;
            }
        }
    }
}