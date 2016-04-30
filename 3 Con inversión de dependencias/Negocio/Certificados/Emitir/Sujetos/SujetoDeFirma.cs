namespace ConObjetosConPolimorfismo
{
    public class SujetoDeFirma : Sujeto
    {
        public SujetoDeFirma(Solicitante elSolicitante) : base(elSolicitante)
        {
        }

        protected override string ObtengaElCN(Solicitante elSolicitante)
        {
            return new CNDeFirma(elSolicitante).Formateado();
        }
    }
}