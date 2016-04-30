using Models;
using System.Collections.Generic;

namespace DS
{
    public class RepositorioDeCertificados
    {
        public void Agregue(Emision laEmision)
        {
            EmisionDBContext db = new EmisionDBContext();
            db.Emisiones.Add(laEmision);
            db.SaveChanges();
        }

        public void Agregue(List<Certificado> losCertificados)
        {
            EmisionDBContext db = new EmisionDBContext();
            db.Certificados.AddRange(losCertificados);
            db.SaveChanges();
        }
    }
}