using System.Linq;

namespace DS.Certificados.Emitir
{
    public class Repositorio
    {
        public static void Agregue(RegistroDeEmision elRegistroDeLaEmision)
        {
            EmisionDBContext db = new EmisionDBContext();
            var laTablaDeEmisiones = db.Emisiones;
            laTablaDeEmisiones.Add(elRegistroDeLaEmision);
            db.SaveChanges();
        }

        public static string ObtengaElCrl()
        {
            const string crl = "crl";
            return new EmisionDBContext().Parametros.Where(c => c.Nombre == crl).First().Valor;
        }
    }
}