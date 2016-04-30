namespace ConObjetosConPolimorfismo
{
    public class CNDeAutenticacion : CN
    {
        public CNDeAutenticacion(Solicitante elSolicitante) : base(elSolicitante)
        {
        }

        protected override string DetermineElProposito()
        {
            return "AUTENTICACION";
        }
    }
}
