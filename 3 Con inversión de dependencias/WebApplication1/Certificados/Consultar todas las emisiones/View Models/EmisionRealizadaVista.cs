using BS.Certificados.ConsultarTodasLasEmisiones;
using System.ComponentModel;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public class EmisionRealizadaVista
    {
        private int elID;

        public EmisionRealizadaVista(EmisionRealizada laEmision)
        {
            elID = ObtengaElID(laEmision);
            Identificacion = ObtengaLaIdentificacion(laEmision);
        }

        private int ObtengaElID(EmisionRealizada laEmision)
        {
            return laEmision.ID;
        }

        private string ObtengaLaIdentificacion(EmisionRealizada laEmision)
        {
            return laEmision.Identificacion;
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