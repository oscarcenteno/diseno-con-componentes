namespace ConObjetosConPolimorfismo
{
    public abstract class CN
    {
        private string elNombre;
        private string losApellidosFormateados;
        private string elProposito;

        public CN(Solicitante elSolicitante)
        {
            elNombre = ObtengaElNombreEnMayuscula(elSolicitante);
            losApellidosFormateados = ObtengaLosApellidosFormateados(elSolicitante);
            elProposito = DetermineElProposito();
        }

        private string ObtengaLosApellidosFormateados(Solicitante elSolicitante)
        {
            return new ApellidosFormateados(elSolicitante).SinEspaciosAlFinal();
        }

        private string ObtengaElNombreEnMayuscula(Solicitante elSolicitante)
        {
            return elSolicitante.NombreEnMayusculas;
        }

        protected abstract string DetermineElProposito();

        public string Formateado()
        {
            return $"CN={elNombre} {losApellidosFormateados} ({elProposito})";
        }
    }
}