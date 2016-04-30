namespace ConObjetosConPolimorfismo
{
    public class SujetoDeAutenticacion : Sujeto
    {
        public SujetoDeAutenticacion(Solicitante elSolicitante) : base(elSolicitante)
        {
        }

        protected override string ObtengaElCN(Solicitante elSolicitante)
        {
            return new CNDeAutenticacion(elSolicitante).Formateado();
        }
    }
}