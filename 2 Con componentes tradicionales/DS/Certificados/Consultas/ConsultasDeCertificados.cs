using DS;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace BS
{
    public class ConsultasDeCertificados
    {
        private EmisionDBContext db = new EmisionDBContext();

        public List<Emision> ConsulteTodasLasEmisiones()
        {
            return db.Emisiones.ToList();
        }

        public List<Certificado> ConsulteLosCertificadosDeUnaEmision(string id)
        {
            return db.Certificados.Where(c => c.EmisionID == id).ToList();
        }

    }
}