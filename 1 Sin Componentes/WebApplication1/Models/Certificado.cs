using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Certificado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string EmisionID { get; set; }
        public string Sujeto { get; set; }
        public DateTime FechaDeEmision { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
    }
}