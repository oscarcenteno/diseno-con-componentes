using System;
using DS.Certificados;

namespace BS.Certificados.ConsultarLosCertificados
{
    public class CertificadoEmitido
    {
        public int ID { get; set; }
        public string Sujeto { get; set; }
        public DateTime FechaDeEmision { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public string Crl { get; set; }
    }
}