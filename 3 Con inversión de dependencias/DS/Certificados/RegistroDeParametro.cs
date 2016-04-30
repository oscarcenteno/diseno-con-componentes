using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DS.Certificados
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
        public DateTime FechaDeEmision { get; set; }

        [Required]
        public DateTime FechaDeVencimiento { get; set; }

        [Required]
        public string Crl { get; set; }
    }
}