using Certificados.DS.MapeosABaseDeDatos;
using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;

namespace Certificados.BS.RegistrarEmision.ConObjetos
{
    public static class ProcesoDeEmision
    {
        public static void Procese(DatosDeLaEmision losDatos)
        {
            RegistroDeEmision elRegistro = MapeoDelRegistroDeEmision.Mapee(losDatos);
            new RepositorioDeEmisiones().Guarde(elRegistro);
        }
    }
}