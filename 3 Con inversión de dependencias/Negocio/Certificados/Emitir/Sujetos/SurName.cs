namespace Sujetos
{
    public class SurName
    {
        private string losApellidosFormateados;

        public SurName(Solicitante elSolicitante)
        {
            losApellidosFormateados = new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();
        }

        public string ComoTexto()
        {
            return $"Surname={losApellidosFormateados}";
        }
    }
}