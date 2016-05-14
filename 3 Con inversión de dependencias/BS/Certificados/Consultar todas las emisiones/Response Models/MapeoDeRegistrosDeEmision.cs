using System.Collections.Generic;
using DS.Certificados;
using Mapeable;

namespace BS.Certificados.ConsultarTodasLasEmisiones
{
    public class MapeoDeRegistrosDeEmision
    {
        public static List<EmisionRealizada> Mapee(List<RegistroDeEmision> losRegistros)
        {
            return new MapeoDeColecciones<RegistroDeEmision, EmisionRealizada>().Mapee(losRegistros);
        }
    }
}
