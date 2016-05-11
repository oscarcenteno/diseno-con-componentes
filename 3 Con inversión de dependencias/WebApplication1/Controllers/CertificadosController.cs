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
            List<EmisionRealizada> lasEmisiones;
            lasEmisiones = ConsultasDeEmisiones.ConsulteTodas();

            return new ListaDeEmisionesRealizadasVista(lasEmisiones);
        }

        // GET: Certificados/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            List<CertificadoEmitidoVista> losCertificados;
            losCertificados = ObtengaLosCertificadosParaMostrar(id);

            return View(losCertificados);
        }

        private static List<CertificadoEmitidoVista> ObtengaLosCertificadosParaMostrar(string id)
        {
            List<CertificadoEmitido> losCertificados;
            losCertificados = ConsultasDeCertificados.ConsultePorId(id);

            return new ListaDeCertificadosEmitidosVista(losCertificados);
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