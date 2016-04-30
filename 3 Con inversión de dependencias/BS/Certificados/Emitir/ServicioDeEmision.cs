using BS.Certificados.Emitir.RequestModels;

namespace BS.Certificados.Emitir
{
    public class ServicioDeEmision
    {
        private SolicitudCompleta laSolicitud;

        public ServicioDeEmision(DatosDelSolicitante losDatos)
        {
            laSolicitud = new MapeoDeDatosDelSolicitante(losDatos).HaciaSolicitud();
        }

        public void Ejecute()
        {
            new ProcesoDeEmision(laSolicitud).Ejecute();
        }
    }
}