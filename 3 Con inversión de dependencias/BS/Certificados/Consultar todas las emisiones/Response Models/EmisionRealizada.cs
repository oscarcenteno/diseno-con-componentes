using DS.Certificados;

namespace BS.Certificados.ConsultarTodasLasEmisiones
{
    public class EmisionRealizada
    {
        public EmisionRealizada(RegistroDeEmision unRegistro)
        {
            ID = unRegistro.ID;
            Identificacion = unRegistro.Identificacion;
        }

        public int ID { get; set; }
        public string Identificacion { get; set; }
    }
}