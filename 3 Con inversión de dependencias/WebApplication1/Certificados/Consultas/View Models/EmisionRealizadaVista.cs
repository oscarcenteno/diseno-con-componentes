using System.ComponentModel;
using BS.Certificados.Consultas;

namespace WebApplication1.ViewModels
{
    public class EmisionRealizadaVista
    {
        private int elID;

        public EmisionRealizadaVista(EmisionRealizada laEmision)
        {
            elID = laEmision.ID;
            Identificacion = laEmision.Identificacion;
        }

        public string ID
        {
            get
            {
                return elID.ToString();
            }
        }

        [DisplayName("Identificación")]
        public string Identificacion { get; private set; }
    }
}