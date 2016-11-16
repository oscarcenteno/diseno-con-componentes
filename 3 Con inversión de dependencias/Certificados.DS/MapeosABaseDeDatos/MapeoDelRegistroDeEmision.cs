using Certificados.Negocio.GenerarEmision.ConInversionDeDependencias;

namespace Certificados.DS.MapeosABaseDeDatos
{
    public static class MapeoDelRegistroDeEmision
    {
        public static RegistroDeEmision Mapee(DatosDeLaEmision losDatos)
        {
            Emision laEmision = new Emision(losDatos);
            return new RegistroDeEmision(laEmision);
        }
    }
}