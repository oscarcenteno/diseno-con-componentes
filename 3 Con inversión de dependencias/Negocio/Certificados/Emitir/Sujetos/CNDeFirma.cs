namespace ConObjetosConPolimorfismo
{
    public class CNDeFirma : CN
    {
        public CNDeFirma(Solicitante elSolicitante) : base(elSolicitante)
        {
        }

        protected override string DetermineElProposito()
        {
            return "FIRMA";
        }
    }
}
