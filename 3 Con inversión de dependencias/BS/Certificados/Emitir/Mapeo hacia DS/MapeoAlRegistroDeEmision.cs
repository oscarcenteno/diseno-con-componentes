using DS.Certificados;
using Negocio.Certificados.Emitir;
using System.Collections.Generic;
using System;

namespace BS.Certificados.Emitir.MapeoHaciaDS
{
    public static class MapeoARegistroDeEmision
    {
        public static RegistroDeEmision Mapee(Emision laEmision)
        {
            RegistroDeEmision elRegistro = new RegistroDeEmision();
            elRegistro.Identificacion = ObtengaLaIdentificacion(laEmision);
            elRegistro.RegistrosDeCertificados = MapeeLosRegistrosDeCertificados(laEmision);
            return elRegistro;
        }

        private static string ObtengaLaIdentificacion(Emision laEmision)
        {
            return laEmision.Identificacion;
        }

        private static List<RegistroDeCertificado> MapeeLosRegistrosDeCertificados(Emision laEmision)
        {
            return new MapeoARegistrosDeCertificados(laEmision).ComoListaMapeada();
        }
    }
}