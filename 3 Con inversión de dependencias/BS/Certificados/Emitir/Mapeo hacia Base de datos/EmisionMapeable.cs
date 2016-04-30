using DS.Certificados;
using Negocio.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    internal class EmisionMapeable
    {
        private Emision laEmision;

        public EmisionMapeable(SolicitudDeEmision laSolicitud)
        {
            laEmision = new Emision(laSolicitud);
        }

        internal RegistroDeEmision ComoRegistro()
        {
            return RegistroDeEmisionMapeable.Mapee(laEmision);
        }
    }
}