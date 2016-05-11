using System;
using Negocio.Certificados.Emitir;
using Negocio.Certificados.Emitir.Sujetos;
using DS.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    public class SolicitudCompleta : SolicitudDeEmision
    {
        public SolicitudCompleta(Solicitante elSolicitante) : base(elSolicitante) { }

        public override string Crl
        {
            get
            {
                return Repositorio.ObtengaElCrl();
            }
        }

        public override DateTime FechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}