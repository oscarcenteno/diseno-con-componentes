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
            SolicitudCompleta laSolicitud = ObtengaLaSolicitudCompleta(losDatos);

            // Negocio
            Emision laEmision = new Emision(laSolicitud);

            GuardeEnLaBaseDeDatos(laEmision);
        }

        private static SolicitudCompleta ObtengaLaSolicitudCompleta(DatosDelSolicitante losDatos)
        {
            return new DatosDeLaSolicitud(losDatos).Completa();
        }

        private static void GuardeEnLaBaseDeDatos(Emision laEmision)
        {
            RegistroDeEmision elRegistro = MapeoARegistroDeEmision.Mapee(laEmision);
            Repositorio.Agregue(elRegistro);
        }
    }
}