using System.Collections.Generic;
using DS.Certificados.Consultas;
using DS.Certificados;

namespace BS.Certificados.ConsultarTodasLasEmisiones
{
    // TODO: Pendiente de Refactoring a Objetos
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
            return new ListaDeEmisionesRealizadas(losRegistros);
        }
    }
}