using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

using WebApplication1.Certificados.Emitir.RequestModels;
using BS.Certificados.Emitir;

using WebApplication1.Certificados.ConsultarLosCertificados.ViewModels;
using BS.Certificados.ConsultarLosCertificados;

using WebApplication1.Certificados.ConsultarTodasLasEmisiones.ViewModels;
using BS.Certificados.ConsultarTodasLasEmisiones;

namespace WebApplication1.Controllers
{
    public class CertificadosController : Controller
    {
        // GET: Certificados
        public ActionResult Index()
        {
            List<EmisionRealizadaVista> lasEmisiones = ObtengaLasEmisionesParaMostrar();
            return View(lasEmisiones);
        }

        private static List<EmisionRealizadaVista> ObtengaLasEmisionesParaMostrar()
        {
            List<EmisionRealizada> lasEmisiones = ConsulteTodasLasEmisiones();

            return MapeeALaVista(lasEmisiones);
        }

        private static List<EmisionRealizadaVista> MapeeALaVista(List<EmisionRealizada> lasEmisiones)
        {
            return MapeoDeEmisionesRealizadas.Mapee(lasEmisiones);
        }

        private static List<EmisionRealizada> ConsulteTodasLasEmisiones()
        {
            return ConsultasDeEmisiones.ConsulteTodas();
        }

        // GET: Certificados/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<CertificadoEmitidoVista> losCertificados;
            losCertificados = ObtengaLosCertificados(id);

            return View(losCertificados);
        }

        private static List<CertificadoEmitidoVista> ObtengaLosCertificados(string id)
        {
            List<CertificadoEmitido> losCertificados;
            losCertificados = ConsulteLosCertificados(id);

            return MapeeALaVista(losCertificados);
        }

        private static List<CertificadoEmitido> ConsulteLosCertificados(string id)
        {
            return ConsultasDeCertificados.ConsultePorId(id);
        }

        private static List<CertificadoEmitidoVista> MapeeALaVista(List<CertificadoEmitido> losCertificados)
        {
            return MapeoDeCertificadosEmitidos.Mapee(losCertificados);
        }

        // GET: Certificados/EmitaANacional
        public ActionResult EmitaANacional()
        {
            return View();
        }

        // POST: Certificados/EmitaANacional
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmitaANacional(DatosDelNacional losDatos)
        {
            if (ModelState.IsValid)
            {
                ServicioDeEmision.Ejecute(losDatos);

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }

        // GET: Certificados/EmitaAExtranjero
        public ActionResult EmitaAExtranjero()
        {
            return View();
        }

        // POST: Certificados/EmitaAExatranjero
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmitaAExtranjero(DatosDelExtranjero losDatos)
        {
            if (ModelState.IsValid)
            {
                ServicioDeEmision.Ejecute(losDatos);
                return RedirectToAction("Index");
            }

            return View(losDatos);
        }
    }
}