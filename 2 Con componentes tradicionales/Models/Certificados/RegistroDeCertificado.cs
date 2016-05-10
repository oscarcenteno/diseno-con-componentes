using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Certificados
{
    public class RegistroDeCertificado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string SolicitanteID { get; set; }

        [Required]
        public string Sujeto { get; set; }

        [Required]
        [DisplayName("Fecha de emisión")]
        public DateTime FechaDeEmision { get; set; }

        [Required]
        [DisplayName("Fecha de vencimiento")]
        public DateTime FechaDeVencimiento { get; set; }

        [Required]
        public string Crl { get; set; }
    }
}