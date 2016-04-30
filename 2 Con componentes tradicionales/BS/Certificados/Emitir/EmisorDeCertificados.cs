using DS;
using Models;
using System;
using System.Collections.Generic;

namespace BS
{
    public class EmisorDeCertificados
    {
        public void EmitaLosCertificados(Emision laEmision)
        {
            RepositorioDeCertificados elRepositorio;
            elRepositorio = new RepositorioDeCertificados();

            List<Certificado> losCertificados;
            losCertificados = GenereLosCertificados(laEmision);

            elRepositorio.Agregue(losCertificados);
            elRepositorio.Agregue(laEmision);
        }

        private List<Certificado> GenereLosCertificados(Emision laEmision)
        {
            DateTime laFechaActual = DateTime.Now;
            DateTime laFechaDeVencimiento = laFechaActual.AddYears(4);

            List<Certificado> losCertificados = new List<Certificado>();

            Certificado elDeFirma = new Certificado();
            elDeFirma.EmisionID = laEmision.ID;
            elDeFirma.Sujeto = GeneracionDeSujetos.GenereElSujeto(laEmision.Identificacion,
                laEmision.Nombre,
                laEmision.PrimerApellido,
                laEmision.SegundoApellido,
                laEmision.TipoDeIdentificacion,
                TipoDeCertificado.DeFirma);
            elDeFirma.FechaDeEmision = laFechaActual;
            elDeFirma.FechaDeVencimiento = laFechaDeVencimiento;

            losCertificados.Add(elDeFirma);

            Certificado elDeAutenticacion = new Certificado();
            elDeAutenticacion.EmisionID = laEmision.ID;
            elDeAutenticacion.Sujeto = GeneracionDeSujetos.GenereElSujeto(laEmision.Identificacion,
                laEmision.Nombre,
                laEmision.PrimerApellido,
                laEmision.SegundoApellido,
                laEmision.TipoDeIdentificacion,
                TipoDeCertificado.DeAutenticacion);
            elDeAutenticacion.FechaDeEmision = laFechaActual;
            elDeAutenticacion.FechaDeVencimiento = laFechaDeVencimiento;

            losCertificados.Add(elDeAutenticacion);

            return losCertificados;
        }

       
    }
}