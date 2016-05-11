using Negocio.Certificados.Emitir.Sujetos;
using System;

namespace Negocio.Certificados.Emitir
{
    public abstract class SolicitudDeEmision
    {
        public SolicitudDeEmision(Solicitante elSolicitante)
        {
            Identificacion = elSolicitante.Identificacion;
            SujetoDeFirma = new SujetoDeFirma(elSolicitante).Formateado();
            SujetoDeAutenticacion = new SujetoDeAutenticacion(elSolicitante).Formateado();
        }

        public string Identificacion { get; private set; }
        public string SujetoDeFirma { get; private set; }
        public string SujetoDeAutenticacion { get; private set; }

        public abstract DateTime FechaActual { get; }
        public abstract string Crl { get; }
    }
}