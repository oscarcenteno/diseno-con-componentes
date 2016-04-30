using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DS.Certificados
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
        public string Identificacion { get; set; }

        public List<RegistroDeCertificado> RegistrosDeCertificados { get; set; }
    }
}