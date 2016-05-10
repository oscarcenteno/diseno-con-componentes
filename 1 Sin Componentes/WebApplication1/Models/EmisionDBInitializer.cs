using System;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class EmisionDBInitializer : DropCreateDatabaseIfModelChanges<EmisionDBContext>
    {
        protected override void Seed(EmisionDBContext contexto)
        {
            RegistroDeParametro elParametro;
            elParametro = new RegistroDeParametro()
            {
                Nombre = "crl",
                Valor = "http://firma.cr/revocacion.crl",
                FechaDeRegistro = DateTime.Now
            };
            contexto.Parametros.Add(elParametro);

            base.Seed(contexto);
        }
    }
}