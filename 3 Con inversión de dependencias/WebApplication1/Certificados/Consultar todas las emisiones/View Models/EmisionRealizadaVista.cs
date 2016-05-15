using System.ComponentModel;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public class EmisionRealizadaVista
    {
        public int ID { get;  set; }

        public string IDComoTexto
        {
            get
            {
                return ID.ToString();
            }
        }

        [DisplayName("Identificación")]
        public string Identificacion { get; set; }
    }
}