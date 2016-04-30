using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConObjetosConPolimorfismo;

namespace ConObjetosConPolimorfismo_Tests
{
    [TestClass()]
    public abstract class EscenarioBase_Tests
    {
        protected string elResultadoEsperado;
        protected string elResultadoObtenido;
        protected Solicitante elSolicitante;

        protected void InicialiceUnNacional()
        {
            AsigneUnaIdentificacionNacional();
            AsigneUnNombreNacional();
        }

        private void AsigneUnaIdentificacionNacional()
        {
            elSolicitante = new SolicitanteNacional();
            elSolicitante.Identificacion = "01-0078-5935";
        }

        private void AsigneUnNombreNacional()
        {
            elSolicitante.Nombre = "Marcelino";
            elSolicitante.PrimerApellido = "Navarro";
            elSolicitante.SegundoApellido = "Quiros";
        }

        protected void InicialiceUnExtranjero()
        {
            AsigneUnaIdentificacionExtranjera();
            AsigneUnNombreExtranjero();
        }

        private void AsigneUnaIdentificacionExtranjera()
        {
            elSolicitante = new SolicitanteExtranjero();
            elSolicitante.Identificacion = "114145540011";
        }

        private void AsigneUnNombreExtranjero()
        {
            elSolicitante.Nombre = "Jose Miguel";
            elSolicitante.PrimerApellido = "Suarez";
            elSolicitante.SegundoApellido = "Godinez";
        }

        protected void InicialiceUnExtranjeroConUnSoloApellido()
        {
            AsigneUnaIdentificacionExtranjera();
            AsigneUnNombreExtranjeroConUnSoloApellido();
        }

        private void AsigneUnNombreExtranjeroConUnSoloApellido()
        {
            elSolicitante.Nombre = "John";
            elSolicitante.PrimerApellido = "Smith";
            elSolicitante.SegundoApellido = "";
        }
    }
}