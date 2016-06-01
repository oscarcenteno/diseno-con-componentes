using Negocio.Certificados.Emitir;

namespace DS.Certificados.Emitir
{
    public class EmisionPersistente
    {
        RegistroDeEmision elRegistro;

        public EmisionPersistente(Emision laEmision)
        {
            elRegistro = MapeoDeEmisionARegistroDeEmision.Mapee(laEmision);

        }

        public static void Agregue(RegistroDeEmision elRegistroDeLaEmision)
        {
            EmisionDBContext db = new EmisionDBContext();
            db.Emisiones.Add(elRegistroDeLaEmision);
            db.SaveChanges();
        }
    }
}