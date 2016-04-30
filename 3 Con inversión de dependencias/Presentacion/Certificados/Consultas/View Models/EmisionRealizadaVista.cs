using System;
using System.ComponentModel;
using BS.Certificados.Consultas;

namespace Presentacion.Certificados.Consultas.ViewModels
{
    public class EmisionRealizadaVista
    {
        public EmisionRealizadaVista(EmisionRealizada laEmision1)
        {
            throw new NotImplementedException();
        }

        public string ID { get; set; }

        [DisplayName("Identificación")]
        public string Identificacion { get; set; }
    }
}