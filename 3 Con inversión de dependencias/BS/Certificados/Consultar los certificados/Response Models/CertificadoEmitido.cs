using System;
using DS.Certificados;

namespace BS.Certificados.ConsultarLosCertificados
{
    public class CertificadoEmitido
    {
        public CertificadoEmitido(RegistroDeCertificado unRegistro)
        {
            ID = unRegistro.ID;
            FechaDeEmision = unRegistro.FechaDeEmision;
            FechaDeVencimiento = unRegistro.FechaDeVencimiento;
            Sujeto = unRegistro.Sujeto;
            Crl = unRegistro.Crl;
        }

        public int ID { get; set; }
        public string Sujeto { get; set; }
        public DateTime FechaDeEmision { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public string Crl { get; set; }
    }
}