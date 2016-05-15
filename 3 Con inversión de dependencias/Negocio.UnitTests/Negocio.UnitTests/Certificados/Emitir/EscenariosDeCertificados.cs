using Negocio.Certificados.Emitir;

namespace Negocio.UnitTests.Certificados.Emitir
{
    public abstract class EscenariosDeCertificados: EscenariosDeSolicitudes
    {
        protected ListaDeCertificados DosCertificadosParaUnNacional()
        {
            ListaDeCertificados laLista = new ListaDeCertificados();
            laLista.Add(new CertificadoDeAutenticacion(laSolicitud));
            laLista.Add(new CertificadoDeFirma(laSolicitud));

            return laLista;
        }
    }
}
