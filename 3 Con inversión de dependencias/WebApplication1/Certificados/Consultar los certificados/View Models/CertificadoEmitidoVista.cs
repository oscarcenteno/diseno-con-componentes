using System;
using System.ComponentModel;
using System.Threading;
using System.Globalization;
using BS.Certificados.ConsultarLosCertificados;

namespace WebApplication1.Certificados.ConsultarLosCertificados.ViewModels
{
    public class CertificadoEmitidoVista
    {
        public DateTime FechaDeEmision { get; private set; }
        public DateTime FechaDeVencimiento { get; private set; }

        public string Sujeto { get; private set; }

        [DisplayName("Fecha de emisión")]
        public string FechaDeEmisionFormateada
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                return FechaDeEmision.ToLongDateString();
            }
        }

        [DisplayName("Fecha de vencimiento")]
        public string FechaDeVencimientoFormateada
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                return FechaDeEmision.ToLongDateString();
            }
        }

        public string Crl { get; private set; }
    }
}