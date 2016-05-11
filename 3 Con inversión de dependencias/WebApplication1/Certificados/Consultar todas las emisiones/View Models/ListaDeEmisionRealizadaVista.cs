using System.Collections.Generic;
using BS.Certificados.ConsultarTodasLasEmisiones;

namespace WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels
{
    public class ListaDeEmisionesRealizadasVista : List<EmisionRealizadaVista>
    {
        public ListaDeEmisionesRealizadasVista(List<EmisionRealizada> lasEmisiones)
        {
            foreach (EmisionRealizada laEmision in lasEmisiones)
            {
                Add(new EmisionRealizadaVista(laEmision));
            }
        }
    }
}