using DS.Certificados;
using Negocio.Certificados.Emitir;
using System.Collections.Generic;

namespace BS.Certificados.Emitir
{
    public static class RegistroDeEmisionMapeable
    {
        public static RegistroDeEmision Mapee(Emision laEmision)
        {
            RegistroDeEmision elRegistro = new RegistroDeEmision();
            elRegistro.Identificacion = laEmision.Identificacion;
            elRegistro.RegistrosDeCertificados = MapeeLosRegistrosDeCertificados(laEmision);

            return elRegistro;
        }

        private static List<RegistroDeCertificado> MapeeLosRegistrosDeCertificados(Emision laEmision)
        {
            return new ListaDeRegistrosDeCertificados(laEmision).ComoListaMapeada();
        }
    }
}