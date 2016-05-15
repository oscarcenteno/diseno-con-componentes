using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DS.Certificados;
using Mapeable.ComparacionesParaPruebasUnitarias;
using BS.Certificados.ConsultarTodasLasEmisiones.ResponseModels;

namespace BS.UnitTests.Certificados.ConsultarTodasLasEmisione.ResponseModels.MapeoAEmisionesRealizadas_Tests
{
    [TestClass]
    public class Mapee_Tests
    {
        private List<EmisionRealizada> elResultadoEsperado;
        private List<EmisionRealizada> elResultadoObtenido;
        private List<RegistroDeEmision> losRegistros;

        [TestMethod]
        public void Mapee_CasoUnico_ListaMapeada()
        {
            elResultadoEsperado = DosEmisionesRealizadas();

            losRegistros = DosRegistrosDeEmision();
            elResultadoObtenido = MapeoAEmisionesRealizadas.Mapee(losRegistros);

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        private List<RegistroDeEmision> DosRegistrosDeEmision()
        {
            List<RegistroDeEmision> laLista = new List<RegistroDeEmision>();
            RegistroDeEmision unRegistro = new RegistroDeEmision();
            unRegistro.ID = 1;
            unRegistro.Identificacion = "111111111";
            laLista.Add(unRegistro);

            RegistroDeEmision otroRegistro = new RegistroDeEmision();
            otroRegistro.ID = 2;
            otroRegistro.Identificacion = "2222222222";
            laLista.Add(otroRegistro);

            return laLista;
        }

        private List<EmisionRealizada> DosEmisionesRealizadas()
        {
            List<EmisionRealizada> laLista = new List<EmisionRealizada>();
            EmisionRealizada unaEmision = new EmisionRealizada();
            unaEmision.ID = 1;
            unaEmision.Identificacion = "111111111";
            laLista.Add(unaEmision);

            EmisionRealizada otraEmision = new EmisionRealizada();
            otraEmision.ID = 2;
            otraEmision.Identificacion = "2222222222";
            laLista.Add(otraEmision);

            return laLista;
        }
    }
}
