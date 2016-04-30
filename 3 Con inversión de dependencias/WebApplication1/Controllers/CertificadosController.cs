using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using BS.Certificados.Consultas;
using BS.Certificados.Emitir;
using WebApplication1.RequestModels;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public class CertificadosController : Controller
    {
        // GET: Certificados
        public ActionResult Index()
        {
            List<EmisionRealizadaVista> lasEmisiones = ObtengaLasEmisionesParaMostrar();

            return View(lasEmisiones);
        }

        // TODO: Extraer 
        private static List<EmisionRealizadaVista> ObtengaLasEmisionesParaMostrar()
        {
            List<EmisionRealizada> lasEmisiones;
            lasEmisiones = new ServicioDeConsultas().ConsulteTodasLasEmisiones();

            List<EmisionRealizadaVista> lasVistas = new List<EmisionRealizadaVista>();
            foreach (EmisionRealizada laEmision in lasEmisiones)
            {
                lasVistas.Add(new EmisionRealizadaVista(laEmision));
            }

            return lasVistas;
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
            losCertificados = new ServicioDeConsultas().ConsulteLosCertificadosPorId(id);

            List<CertificadoEmitidoVista> lasVistas;
            lasVistas = new List<CertificadoEmitidoVista>();

            foreach (CertificadoEmitido elCertificado in losCertificados)
            {
                lasVistas.Add(new CertificadoEmitidoVista(elCertificado));
            }

            return lasVistas;
        }

        // GET: Certificados/EmitaANacional
        public ActionResult EmitaANacional()
        {
            return View();
        }

        // POST: Certificados/EmitaANacional
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmitaANacional([Bind(Include = "Identificacion,Nombre,PrimerApellido,SegundoApellido")] DatosDelNacional losDatos)
        {
            if (ModelState.IsValid)
            {
                new ServicioDeEmision(losDatos).Ejecute();

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }

        // GET: Certificados/EmitaAExtranjero
        public ActionResult EmitaAExtranjero()
        {
            return View();
        }

        // POST: Certificados/EmitaAExtranjero
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmitaAExtranjero([Bind(Include = "Identificacion,Nombre,PrimerApellido,SegundoApellido")] DatosDelExtranjero losDatos)
        {
            if (ModelState.IsValid)
            {
                new ServicioDeEmision(losDatos).Ejecute();

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }
    }
}