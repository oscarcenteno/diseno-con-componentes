using BS.Certificados.Emitir.RequestModels;
using Sujetos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.RequestModels
{
    public class DatosDelExtranjero: DatosDelSolicitante
    {
        [Required(ErrorMessage = "La identificación es requerida.")]
        [DisplayName("Identificación")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [DisplayName("Primer apellido")]
        public string PrimerApellido { get; set; }

        [DisplayName("Segundo apellido")]
        public string SegundoApellido { get; set; }

        public override Solicitante ComoSolicitante()
        {
            SolicitanteExtranjero elSolicitante = new SolicitanteExtranjero();
            elSolicitante.Nombre = Nombre;
            elSolicitante.PrimerApellido = PrimerApellido;
            elSolicitante.SegundoApellido = SegundoApellido;
            elSolicitante.Identificacion = Identificacion;

            return elSolicitante;
        }
    }
}