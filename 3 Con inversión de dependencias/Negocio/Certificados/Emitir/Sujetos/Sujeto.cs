namespace ConObjetosConPolimorfismo
{
    public abstract class Sujeto
    {
        string elCN;
        string elOU;
        string elO;
        string elC;
        string elSurname;
        string elGivenName;
        string elSerialNumber;

        public Sujeto(Solicitante elSolicitante)
        {
            elCN = ObtengaElCN(elSolicitante);
            elOU = ObtengaElOU(elSolicitante);
            elO = ObtengaElO();
            elC = ObtengaElC();
            elSurname = ObtengaElSurname(elSolicitante);
            elGivenName = ObtengaElGivenName(elSolicitante);
            elSerialNumber = ObtengaElSerialNumber(elSolicitante);
        }

        protected abstract string ObtengaElCN(Solicitante elSolicitante);

        private static string ObtengaElOU(Solicitante elSolicitante)
        {
            return elSolicitante.OU;
        }

        private string ObtengaElO()
        {
            return "O=PERSONA FISICA";
        }

        private string ObtengaElC()
        {
            return "C=CR";
        }

        private string ObtengaElSurname(Solicitante elSolicitante)
        {
            return new SurName(elSolicitante).ComoTexto();
        }

        private string ObtengaElGivenName(Solicitante elSolicitante)
        {
            return new GivenName(elSolicitante).ComoTexto();
        }

        private string ObtengaElSerialNumber(Solicitante elSolicitante)
        {
            return elSolicitante.SerialNumber;
        }

        public string Formateado()
        {
            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }
    }
}