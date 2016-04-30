namespace ConObjetosConPolimorfismo
{
    public abstract class Solicitante
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public string NombreEnMayusculas
        {
            get
            {
                return Nombre.ToUpper();
            }
        }

        public string Apellidos
        {
            get
            {
                return $"{PrimerApellido} {SegundoApellido}";
            }
        }

        public abstract string OU { get; }
        public abstract string SerialNumber { get; }
    }
}