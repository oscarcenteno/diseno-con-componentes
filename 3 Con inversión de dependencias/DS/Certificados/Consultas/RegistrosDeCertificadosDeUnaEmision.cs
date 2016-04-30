using System.Collections.Generic;
using System.Linq;

namespace DS.Certificados.Consultas
{
    public static class RegistrosDeCertificados
    {
        public static List<RegistroDeCertificado> PorEmision(string id)
        {
            return new EmisionDBContext().Certificados.Where(c => c.SolicitanteID == id).ToList();
        }
    }
}