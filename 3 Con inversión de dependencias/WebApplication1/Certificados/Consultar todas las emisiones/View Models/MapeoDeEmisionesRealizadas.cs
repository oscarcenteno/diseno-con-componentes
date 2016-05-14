using BS.Certificados.ConsultarTodasLasEmisiones;
using Mapeable;
using System.Collections.Generic;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public static class MapeoDeEmisionesRealizadas
    {
        public static List<EmisionRealizadaVista> Mapee(List<EmisionRealizada> lasEmisiones)
        {
            return new MapeoDeColecciones<EmisionRealizada, EmisionRealizadaVista>().Mapee(lasEmisiones);
        }
    }
}