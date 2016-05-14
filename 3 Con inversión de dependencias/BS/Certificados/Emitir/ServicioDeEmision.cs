using Negocio.Certificados.Emitir;
using BS.Certificados.Emitir.MapeoHaciaDS;
using BS.Certificados.Emitir.RequestModels;
using DS.Certificados;
using DS.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    public static class ServicioDeEmision
    {
        public static void Ejecute(DatosDelSolicitante losDatos)
        {
            RegistroDeEmision elRegistro = ObtengaElRegistroDeEmision(losDatos);
            AgregueABaseDeDatos(elRegistro);
        }

        private static RegistroDeEmision ObtengaElRegistroDeEmision(DatosDelSolicitante losDatos)
        {
            Emision laEmision = ObtengaLaEmision(losDatos);
            return MapeeAUnRegistroDeEmision(laEmision);
        }

        private static Emision ObtengaLaEmision(DatosDelSolicitante losDatos)
        {
            SolicitudCompleta laSolicitud = CompleteLaSolicitud(losDatos);
            return GenereLaEmision(laSolicitud);
        }

        private static void AgregueABaseDeDatos(RegistroDeEmision elRegistro)
        {
            Repositorio.Agregue(elRegistro);
        }

        private static RegistroDeEmision MapeeAUnRegistroDeEmision(Emision laEmision)
        {
            return MapeoARegistroDeEmision.Mapee(laEmision);
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