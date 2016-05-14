using DS.Certificados;
using System.Collections.Generic;
using Negocio.Certificados.Emitir;
using Mapeable;

namespace BS.Certificados.Emitir.MapeoHaciaDS
{
    public class MapeoARegistrosDeCertificados
    {
        private List<Certificado> losCertificados;

        public MapeoARegistrosDeCertificados(Emision laEmision)
        {
            losCertificados = laEmision.Certificados;
        }

        public List<RegistroDeCertificado> ComoListaMapeada()
        {
            return new MapeoDeColecciones<Certificado, RegistroDeCertificado>().Mapee(losCertificados);
        }
    }
}