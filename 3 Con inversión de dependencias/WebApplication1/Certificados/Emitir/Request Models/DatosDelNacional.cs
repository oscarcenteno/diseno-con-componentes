using BS.Certificados.Emitir.RequestModels;
using Sujetos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.RequestModels
{
    public class DatosDelNacional:DatosDelSolicitante
    {
        [Required(ErrorMessage = "La cédula es requerida.")]
        [DisplayName("Cédula")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Su primer apellido es requerido.")]
        [DisplayName("Primer apellido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "El segundo apellido es requerido.")]
        public string SegundoApellido { get; set; }

        public override Solicitante ComoSolicitante()
        {
            SolicitanteNacional elSolicitante = new SolicitanteNacional();
            elSolicitante.Nombre = Nombre;
            elSolicitante.PrimerApellido = PrimerApellido;
            elSolicitante.SegundoApellido = SegundoApellido;
            elSolicitante.Identificacion = Identificacion;

            return elSolicitante;
        }
    }
}