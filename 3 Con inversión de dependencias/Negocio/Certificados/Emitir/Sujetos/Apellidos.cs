namespace Negocio.Certificados.Emitir.Sujetos
{
    public class Apellidos
    {
        private string losApellidos;

        public Apellidos(Solicitante elSolicitante)
        {
            losApellidos = elSolicitante.Apellidos;
        }

        public string Formateados()
        {
            return losApellidos.ToUpper();
        }
    }
}