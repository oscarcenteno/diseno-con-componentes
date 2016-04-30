using System.Collections.Generic;
using System.Linq;

namespace DS.Certificados.Consultas
{
    public class RegistrosDeEmision
    {
        public List<RegistroDeEmision> ComoLista()
        {
            return new EmisionDBContext().Emisiones.ToList();
        }
    }
}