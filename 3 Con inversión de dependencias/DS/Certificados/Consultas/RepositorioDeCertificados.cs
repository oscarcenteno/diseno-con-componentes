using System.Collections.Generic;
using System.Linq;

namespace DS.Certificados.Consultas
{
    public static class RepositorioDeCertificados
    {
        public static List<RegistroDeCertificado> ConsultePorEmision(string id)
        {
            return new EmisionDBContext().Certificados.Where(c => c.SolicitanteID == id).ToList();
        }
    }
}