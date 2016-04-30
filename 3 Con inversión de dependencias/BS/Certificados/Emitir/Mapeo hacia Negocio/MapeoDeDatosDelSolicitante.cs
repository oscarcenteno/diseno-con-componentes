using BS.Certificados.Emitir.RequestModels;
using ConObjetosConPolimorfismo;

namespace BS.Certificados.Emitir
{
    public class MapeoDeDatosDelSolicitante
    {
        private Solicitante elSolicitante;

        public MapeoDeDatosDelSolicitante(DatosDelSolicitante losDatos)
        {
            elSolicitante = losDatos.ComoSolicitante();
        }

        public SolicitudCompleta HaciaSolicitud()
        {
            return new SolicitudCompleta(elSolicitante);
        }
    }
}