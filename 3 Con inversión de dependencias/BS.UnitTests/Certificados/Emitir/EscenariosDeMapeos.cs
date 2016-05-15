using System.Collections.Generic;
using DS.Certificados;
using Negocio.Certificados.Emitir;
using Negocio.UnitTests.Certificados.Emitir;

namespace BS.UnitTests.Certificados.Emitir
{
    public abstract class EscenariosDeMapeos: EscenariosDeCertificados
    {
        public Emision UnaEmision()
        {
            return new Emision(laSolicitud);
        }

        public RegistroDeEmision UnRegistroDeEmision()
        {
            RegistroDeEmision elRegistro = new RegistroDeEmision();
            elRegistro.Identificacion = UnaCedulaNacional();
            elRegistro.RegistrosDeCertificados = DosRegistrosDeCertificados();

            return elRegistro;
        }

        public List<RegistroDeCertificado> DosRegistrosDeCertificados()
        {
            List<RegistroDeCertificado> laLista = new List<RegistroDeCertificado>();

            RegistroDeCertificado unRegistro = new RegistroDeCertificado();
            unRegistro.SolicitanteID = UnaCedulaNacional();
            unRegistro.Sujeto = EscenariosDeSujetos.UnSujetoDeAutenticacionParaUnNacional();
            unRegistro.FechaDeEmision = LaFechaActual();
            unRegistro.FechaDeVencimiento = LaFechaDeVencimiento();
            unRegistro.Crl = UnCrl();
            laLista.Add(unRegistro);

            RegistroDeCertificado otroRegistro = new RegistroDeCertificado();
            otroRegistro.SolicitanteID = UnaCedulaNacional();
            otroRegistro.Sujeto = EscenariosDeSujetos.UnSujetoDeFirmaParaUnNacional();
            otroRegistro.FechaDeEmision = LaFechaActual();
            otroRegistro.FechaDeVencimiento = LaFechaDeVencimiento();
            otroRegistro.Crl = UnCrl();
            laLista.Add(otroRegistro);

            return laLista;
        }
    }
}