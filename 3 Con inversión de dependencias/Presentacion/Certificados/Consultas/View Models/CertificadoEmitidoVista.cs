using System;
using System.ComponentModel;
using BS.Certificados.Consultas;

namespace Presentacion.Certificados.Consultas.ViewModels
{
    public class CertificadoEmitidoVista
    {
        public CertificadoEmitidoVista(CertificadoEmitido elCertificado)
        {
            // Realiza el mapeo
            throw new NotImplementedException();
        }

        public string Sujeto { get; set; }

        [DisplayName("Fecha de emisión")]
        public string FechaDeEmision { get; set; }

        [DisplayName("Fecha de vencimiento")]
        public string FechaDeVencimiento { get; set; }
    }
}