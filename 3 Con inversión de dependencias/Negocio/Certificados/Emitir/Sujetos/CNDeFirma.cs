namespace Negocio.Certificados.Emitir.Sujetos
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
