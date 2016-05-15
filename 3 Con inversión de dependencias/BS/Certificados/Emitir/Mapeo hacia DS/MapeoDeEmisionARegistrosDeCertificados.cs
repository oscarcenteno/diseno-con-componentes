using DS.Certificados;
using System.Collections.Generic;
using Negocio.Certificados.Emitir;
using Mapeable;

namespace BS.Certificados.Emitir.MapeoHaciaDS
{
    public class MapeoDeEmisionARegistrosDeCertificados
    {
        private List<Certificado> losCertificados;

        public MapeoDeEmisionARegistrosDeCertificados(Emision laEmision)
        {
            losCertificados = laEmision.Certificados;
        }

        public List<RegistroDeCertificado> ComoListaMapeada()
        {
            return new MapeoDeColecciones<Certificado, RegistroDeCertificado>().Mapee(losCertificados);
        }
    }
}