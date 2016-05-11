using System;
using BS.Certificados.Emitir.RequestModels;
using Negocio.Certificados.Emitir.Sujetos;

namespace BS.Certificados.Emitir
{
    public class DatosDeLaSolicitud
    {
        private Solicitante elSolicitante;

        public DatosDeLaSolicitud(DatosDelSolicitante losDatos)
        {
            elSolicitante = losDatos.ComoSolicitante();
        }

        internal SolicitudCompleta Completa()
        {
            return new SolicitudCompleta(elSolicitante);
        }
    }
}