using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Models;

namespace WebApplication1.Controllers
{
    public class EmisionesController : Controller
    {
        // GET: Emisiones
        public ActionResult Index()
        {
            BS.ConsultasDeCertificados elConsultante = new BS.ConsultasDeCertificados();

            List<Emision> lasEmisiones;
            lasEmisiones = elConsultante.ConsulteTodasLasEmisiones();

            return View(lasEmisiones);
        }

        // GET: Emisiones/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BS.ConsultasDeCertificados elConsultante = new BS.ConsultasDeCertificados();
            List<Certificado> losCertificados;
            losCertificados = elConsultante.ConsulteLosCertificadosDeUnaEmision(id);

            return View(losCertificados);
        }

        // GET: Emisiones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emisiones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Identificacion,TipoDeIdentificacion,Nombre,PrimerApellido,SegundoApellido")] Emision laEmision)
        {
            if (ModelState.IsValid)
            {
                BS.EmisorDeCertificados elEmisor = new BS.EmisorDeCertificados();
                elEmisor.EmitaLosCertificados(laEmision);

                return RedirectToAction("Index");
            }

            return View(laEmision);
        }
    }
}
