using System.Linq;

namespace DS.Certificados.Emitir
{
    public static class ConsultasDeParametros
    {
        public static string ObtengaElCrl()
        {
            const string crl = "crl";
            return new EmisionDBContext().Parametros.Where(c => c.Nombre == crl).First().Valor;
        }
    }
}