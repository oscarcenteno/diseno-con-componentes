using System.Collections.Generic;
using DS.Certificados;

namespace BS.Certificados.ConsultarLosCertificados
{
    public class ListaDeCertificadosEmitidos : List<CertificadoEmitido>
    {
        public ListaDeCertificadosEmitidos(List<RegistroDeCertificado> losRegistros)
        {
            foreach (var unRegistro in losRegistros)
            {
                CertificadoEmitido elModelo = Mapee(unRegistro);
                Add(elModelo);
            }
        }

        private static CertificadoEmitido Mapee(RegistroDeCertificado unRegistro)
        {
            return new CertificadoEmitido(unRegistro);
        }
    }
}