using DS.Certificados;
using DS.Certificados.Emitir;
using Negocio.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    public class ProcesoDeEmision
    {
        private RegistroDeEmision elRegistro;

        public ProcesoDeEmision(SolicitudDeEmision laSolicitud)
        {
            elRegistro = new EmisionMapeable(laSolicitud).ComoRegistro();
        }

        public void Ejecute()
        {
            Repositorio.Agregue(elRegistro);
        }
    }
}