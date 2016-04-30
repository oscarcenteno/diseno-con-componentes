namespace ConObjetosConPolimorfismo
{
    public class ApellidosFormateados
    {
        private string losApellidosFormateados;

        public ApellidosFormateados(Solicitante elSolicitante)
        {
            losApellidosFormateados = new Apellidos(elSolicitante).Formateados();
        }

        public string SinEspaciosAlFinal()
        {
            return losApellidosFormateados.TrimEnd();
        }
    }
}