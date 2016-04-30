using System;

namespace Negocio.Certificados.Emitir
{
    public abstract class Certificado
    {
        public Certificado(SolicitudDeEmision laSolicitud)
        {
            SolicitanteID = laSolicitud.Identificacion;
            FechaDeEmision = laSolicitud.FechaActual;
            Crl = laSolicitud.Crl;
        }

        public string SolicitanteID { get; private set; }

        public DateTime FechaDeEmision { get; private set; }

        public DateTime FechaDeVencimiento
        {
            get
            {
                return FechaDeEmision.AddYears(4);
            }
        }

        public string Sujeto { get; protected set; }

        public string Crl { get; protected set; }
    }
}