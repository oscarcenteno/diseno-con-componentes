using DS;
using Models.Certificados;
using System.Collections.Generic;
using System.Linq;

namespace BS
{
    public class ConsultasDeCertificados
    {
        private EmisionDBContext db = new EmisionDBContext();

        public List<RegistroDeEmision> ConsulteTodasLasEmisiones()
        {
            return db.Emisiones.ToList();
        }

        public List<RegistroDeCertificado> ConsulteLosCertificadosDeUnaEmision(string id)
        {
            return db.Certificados.Where(c => c.SolicitanteID == id).ToList();
        }

    }
}