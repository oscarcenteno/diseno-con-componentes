namespace Negocio.Certificados.Emitir
{
    public class CertificadoDeFirma: Certificado
    {
        public CertificadoDeFirma(SolicitudDeEmision laSolicitud): base(laSolicitud)
        {
            Sujeto = laSolicitud.SujetoDeFirma; 
        }
    }
}