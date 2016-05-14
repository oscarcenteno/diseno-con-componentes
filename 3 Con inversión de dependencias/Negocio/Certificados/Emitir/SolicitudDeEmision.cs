using Negocio.Certificados.Emitir.Sujetos;
using System;

namespace Negocio.Certificados.Emitir
{
    public abstract class SolicitudDeEmision
    {
        private Solicitante elSolicitante;

        public SolicitudDeEmision(Solicitante elSolicitante)
        {
            this.elSolicitante = elSolicitante;
        }

        public string Identificacion
        {
            get
            {
                return elSolicitante.Identificacion;
            }
        }

        public string SujetoDeFirma
        {
            get
            {
                return new SujetoDeFirma(elSolicitante).Formateado();
            }
        }
        public string SujetoDeAutenticacion
        {
            get
            {
                return new SujetoDeAutenticacion(elSolicitante).Formateado();
            }
        }

        public abstract DateTime FechaActual { get; }
        public abstract string Crl { get; }
    }
}