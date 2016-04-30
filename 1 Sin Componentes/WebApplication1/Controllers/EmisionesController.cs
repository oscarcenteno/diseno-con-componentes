using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmisionesController : Controller
    {
        private EmisionDBContext db = new EmisionDBContext();

        // GET: Emisiones
        public ActionResult Index()
        {
            return View(db.Emisiones.ToList());
        }

        // GET: Emisiones/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Certificado> certificados = db.Certificados.Where(c => c.EmisionID == id).ToList();
            if (certificados.Count == 0)
            {
                return HttpNotFound();
            }
            return View(certificados);
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

                db.Certificados.AddRange(losCertificados);
                db.SaveChanges();

                db.Emisiones.Add(laEmision);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(laEmision);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
