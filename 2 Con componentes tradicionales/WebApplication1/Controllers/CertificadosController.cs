using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Models.Certificados;

namespace WebApplication1.Controllers
{
    public class CertificadosController : Controller
    {
        // GET: Certificados
        public ActionResult Index()
        {
            BS.ConsultasDeCertificados elConsultante = new BS.ConsultasDeCertificados();

            List<RegistroDeEmision> lasEmisiones;
            lasEmisiones = elConsultante.ConsulteTodasLasEmisiones();

            return View(lasEmisiones);
        }

        // GET: Certificados/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BS.ConsultasDeCertificados elConsultante = new BS.ConsultasDeCertificados();
            List<RegistroDeCertificado> losCertificados;
            losCertificados = elConsultante.ConsulteLosCertificadosDeUnaEmision(id);

            return View(losCertificados);
        }

        // GET: Certificados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Certificados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificacion,TipoDeIdentificacion,Nombre,PrimerApellido,SegundoApellido")] DatosDelSolicitante losDatos)
        {
            if (ModelState.IsValid)
            {
                BS.EmisorDeCertificados elEmisor = new BS.EmisorDeCertificados();
                elEmisor.EmitaLosCertificados(losDatos);

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }
    }
}
