using BS.Certificados.ConsultarTodasLasEmisiones;
using BS.Certificados.ConsultarTodasLasEmisiones.ResponseModels;
using Mapeable;
using System.Collections.Generic;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public static class MapeoAEmisionesRealizadasVista
    {
        public static List<EmisionRealizadaVista> Mapee(List<EmisionRealizada> lasEmisiones)
        {
            return new MapeoDeColecciones<EmisionRealizada, EmisionRealizadaVista>().Mapee(lasEmisiones);
        }
    }
}