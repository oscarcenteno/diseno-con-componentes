using System.Collections.Generic;
using DS.Certificados.Consultas;
using DS.Certificados;

namespace BS.Certificados.Consultas
{
    // TODO: Pendiente de Refactoring a Objetos
    public class ServicioDeConsultas
    {
        public List<CertificadoEmitido> ConsulteLosCertificadosPorId(string id)
        {
            List<RegistroDeCertificado> losRegistros;
            losRegistros = RegistrosDeCertificados.PorEmision(id);

            return Mapee(losRegistros);
        }

        private static List<CertificadoEmitido> Mapee(List<RegistroDeCertificado> losRegistros)
        {
            List<CertificadoEmitido> losModelos = new List<CertificadoEmitido>();

            foreach (var unRegistro in losRegistros)
            {
                CertificadoEmitido elModelo = Mapee(unRegistro);
                losModelos.Add(elModelo);
            }

            return losModelos;
        }

        private static CertificadoEmitido Mapee(RegistroDeCertificado unRegistro)
        {
            CertificadoEmitido elModelo = new CertificadoEmitido();
            elModelo.ID = unRegistro.ID;
            elModelo.FechaDeEmision = unRegistro.FechaDeEmision;
            elModelo.FechaDeVencimiento = unRegistro.FechaDeVencimiento;
            elModelo.Sujeto = unRegistro.Sujeto;
            elModelo.Crl = unRegistro.Crl;

            return elModelo;
        }

        public List<EmisionRealizada> ConsulteTodasLasEmisiones()
        {
            List<RegistroDeEmision> losRegistros;
            losRegistros = new RegistrosDeEmision().ComoLista();

            return Mapee(losRegistros);
        }

        private static List<EmisionRealizada> Mapee(List<RegistroDeEmision> losRegistros)
        {
            List<EmisionRealizada> losModelos = new List<EmisionRealizada>();

            foreach (var unRegistro in losRegistros)
            {
                EmisionRealizada elModelo = Mapee(unRegistro);
                losModelos.Add(elModelo);
            }

            return losModelos;
        }

        private static EmisionRealizada Mapee(RegistroDeEmision unRegistro)
        {
            EmisionRealizada elModelo = new EmisionRealizada();
            elModelo.ID = unRegistro.ID;
            elModelo.Identificacion = unRegistro.Identificacion;

            return elModelo;
        }
    }
}