namespace ConObjetosConPolimorfismo
{
    public class SolicitanteExtranjero : Solicitante
    {
        public override string OU
        {
            get
            {
                return "OU=EXTRANJERO";
            }
        }

        public override string SerialNumber
        {
            get
            {
                return $"SERIALNUMBER=NUP-{Identificacion}";
            }
        }
    }
}
