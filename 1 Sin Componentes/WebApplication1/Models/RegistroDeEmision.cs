using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class RegistroDeEmision
    {
        public RegistroDeEmision()
        {
            RegistrosDeCertificados = new List<RegistroDeCertificado>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DisplayName("Identificación")]
        public string Identificacion { get; set; }

        public List<RegistroDeCertificado> RegistrosDeCertificados { get; set; }
    }
}