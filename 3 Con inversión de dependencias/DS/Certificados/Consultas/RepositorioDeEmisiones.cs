using System.Collections.Generic;
using System.Linq;

namespace DS.Certificados.Consultas
{
    public static class RepositorioDeEmisiones
    {
        public static List<RegistroDeEmision> ConsulteTodas()
        {
            return new EmisionDBContext().Emisiones.ToList();
        }
    }
}