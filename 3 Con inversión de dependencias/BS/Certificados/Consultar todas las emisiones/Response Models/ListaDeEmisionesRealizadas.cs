using System.Collections.Generic;
using DS.Certificados;

namespace BS.Certificados.ConsultarTodasLasEmisiones
{
    internal class ListaDeEmisionesRealizadas : List<EmisionRealizada>
    {
        public ListaDeEmisionesRealizadas(List<RegistroDeEmision> losRegistros)
        {
            foreach (RegistroDeEmision elRegistro in losRegistros)
            {
                EmisionRealizada elModelo = Mapee(elRegistro);
                Add(elModelo);
            }
        }

        private static EmisionRealizada Mapee(RegistroDeEmision elRegistro)
        {
            return new EmisionRealizada(elRegistro);
        }
    }
}