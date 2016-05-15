using BS.Certificados.Emitir.Mapeos;
using BS.Certificados.Emitir.RequestModels;
using Negocio.Certificados.Emitir;
using DS.Certificados;
using DS.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    public static class ServicioDeEmision
    {
        public static void Ejecute(DatosDelSolicitante losDatos)
        {
            SolicitudCompleta laSolicitud = CompleteLaSolicitud(losDatos);
            Emision laEmision = GenereLaEmision(laSolicitud);
            RegistroDeEmision elRegistro = MapeeAUnRegistroDeEmision(laEmision);
            AgregueABaseDeDatos(elRegistro);
        }

        private static void AgregueABaseDeDatos(RegistroDeEmision elRegistro)
        {
            Repositorio.Agregue(elRegistro);
        }

        private static RegistroDeEmision MapeeAUnRegistroDeEmision(Emision laEmision)
        {
            return MapeoDeEmisionARegistroDeEmision.Mapee(laEmision);
        }

        private static Emision GenereLaEmision(SolicitudCompleta laSolicitud)
        {
            return new Emision(laSolicitud);
        }

        private static SolicitudCompleta CompleteLaSolicitud(DatosDelSolicitante losDatos)
        {
            return new DatosDeLaSolicitud(losDatos).Completa();
        }
    }
}