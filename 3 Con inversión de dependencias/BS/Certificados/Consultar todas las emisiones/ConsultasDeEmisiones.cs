using System.Collections.Generic;
using DS.Certificados.Consultas;
using DS.Certificados;

namespace BS.Certificados.ConsultarTodasLasEmisiones
{
    public static class ConsultasDeEmisiones
    {
        public static List<EmisionRealizada> ConsulteTodas()
        {
            List<RegistroDeEmision> losRegistros;
            losRegistros = RepositorioDeEmisiones.ConsulteTodas();

            return Mapee(losRegistros);
        }

        private static List<EmisionRealizada> Mapee(List<RegistroDeEmision> losRegistros)
        {
            return MapeoAEmisionesRealizadas.Mapee(losRegistros);
        }
    }
}