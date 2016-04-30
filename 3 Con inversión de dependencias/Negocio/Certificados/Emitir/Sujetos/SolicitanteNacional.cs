namespace ConObjetosConPolimorfismo
{
    public class SolicitanteNacional : Solicitante
    {
        public override string OU
        {
            get
            {
                return "OU=CIUDADANO";
            }
        }

        public override string SerialNumber
        {
            get
            {
                return $"SERIALNUMBER=CPF-{Identificacion}";
            }
        }
    }
}
