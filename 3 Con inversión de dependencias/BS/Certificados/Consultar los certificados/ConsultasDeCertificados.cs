using BS.Certificados.ConsultarLosCertificados.ResponseModels;
using DS.Certificados;
using DS.Certificados.Consultas;
using System.Collections.Generic;

namespace BS.Certificados.ConsultarLosCertificados
{
    public static class ConsultasDeCertificados
    {
        public static List<CertificadoEmitido> ConsultePorId(string id)
        {
            List<RegistroDeCertificado> losRegistros;
            losRegistros = RepositorioDeCertificados.ConsultePorEmision(id);

            return Mapee(losRegistros);
        }

        private static List<CertificadoEmitido> Mapee(List<RegistroDeCertificado> losRegistros)
        {
            return MapeoACertificadosEmitidos.Mapee(losRegistros);
        }
    }
}
