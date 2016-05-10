using Models.Certificados;
using System.Linq;

namespace DS.Certificados.Emitir
{
    public class RepositorioDeCertificados
    {
        public void Agregue(RegistroDeEmision laEmision)
        {
            EmisionDBContext db = new EmisionDBContext();
            db.Emisiones.Add(laEmision);
            db.SaveChanges();
        }

        public string ObtengaElCrl()
        {
            const string crl = "crl";
            EmisionDBContext db = new EmisionDBContext();
            return db.Parametros.Where(c => c.Nombre == crl).First().Valor;
        }
    }
}