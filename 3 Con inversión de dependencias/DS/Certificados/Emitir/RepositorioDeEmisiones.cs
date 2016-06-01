namespace DS.Certificados.Emitir
{
    public static class RepositorioDeEmisiones 
    {
        public static void Agregue(RegistroDeEmision elRegistroDeLaEmision)
        {
            EmisionDBContext db = new EmisionDBContext();
            var laTablaDeEmisiones = db.Emisiones;
            laTablaDeEmisiones.Add(elRegistroDeLaEmision);
            db.SaveChanges();
        }
    }
}