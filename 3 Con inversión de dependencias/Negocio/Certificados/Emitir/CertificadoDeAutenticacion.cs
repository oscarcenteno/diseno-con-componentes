namespace Negocio.Certificados.Emitir
{
    public class CertificadoDeAutenticacion : Certificado
    {
        public CertificadoDeAutenticacion(SolicitudDeEmision laSolicitud) : base(laSolicitud)
        {
            Sujeto = laSolicitud.SujetoDeAutenticacion; 
        }
    }
}