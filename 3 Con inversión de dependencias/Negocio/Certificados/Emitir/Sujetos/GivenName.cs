namespace ConObjetosConPolimorfismo
{
    public class GivenName
    {
        private string elNombreEnMayusculas;

        public GivenName(Solicitante elSolicitante)
        {
            elNombreEnMayusculas = elSolicitante.NombreEnMayusculas;
        }

        public string ComoTexto()
        {
            return "GivenName=" + elNombreEnMayusculas;
        }
    }
}