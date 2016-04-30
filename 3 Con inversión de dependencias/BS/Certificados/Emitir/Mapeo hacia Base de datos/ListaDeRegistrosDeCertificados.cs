using DS.Certificados;
using System.Collections.Generic;
using Negocio.Certificados.Emitir;

namespace BS.Certificados.Emitir
{
    class ListaDeRegistrosDeCertificados
    {
        private List<Certificado> losCertificados;

        public ListaDeRegistrosDeCertificados(Emision laEmision)
        {
            losCertificados = laEmision.Certificados;
        }

        public List<RegistroDeCertificado> ComoListaMapeada()
        {
            return MapeoDeRegistrosDeCertificados.Mapee(losCertificados);
        }
    }
}