using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CertificadosController : Controller
    {
        // GET: Certificados
        public ActionResult Index()
        {
            EmisionDBContext db = new EmisionDBContext();
            return View(db.Emisiones.ToList());
        }

        // GET: Certificados/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmisionDBContext db = new EmisionDBContext();
            List<RegistroDeCertificado> certificados = db.Certificados.Where(c => c.SolicitanteID == id).ToList();
            if (certificados.Count == 0)
            {
                return HttpNotFound();
            }
            return View(certificados);
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
                AgregueLaEmision(losDatos);

                return RedirectToAction("Index");
            }

            return View(losDatos);
        }

        private void AgregueLaEmision(DatosDelSolicitante losDatos)
        {
            DateTime laFechaActual = DateTime.Now;
            DateTime laFechaDeVencimiento = laFechaActual.AddYears(4);

            EmisionDBContext db = new EmisionDBContext();
            const string crl = "crl";
            string elCrl = db.Parametros.Where(c => c.Nombre == crl).First().Valor;

            List<RegistroDeCertificado> losCertificados = new List<RegistroDeCertificado>();

            RegistroDeCertificado elDeFirma = new RegistroDeCertificado();
            elDeFirma.SolicitanteID = losDatos.Identificacion;
            elDeFirma.Sujeto = GenereElSujeto(losDatos.Identificacion, losDatos.Nombre, losDatos.PrimerApellido, losDatos.SegundoApellido, losDatos.TipoDeIdentificacion, TipoDeCertificado.DeFirma);
            elDeFirma.FechaDeEmision = DateTime.Now;
            elDeFirma.FechaDeVencimiento = laFechaDeVencimiento;
            elDeFirma.Crl = elCrl;
            losCertificados.Add(elDeFirma);

            RegistroDeCertificado elDeAutenticacion = new RegistroDeCertificado();
            elDeAutenticacion.SolicitanteID = losDatos.Identificacion;
            elDeAutenticacion.Sujeto = GenereElSujeto(losDatos.Identificacion, losDatos.Nombre, losDatos.PrimerApellido, losDatos.SegundoApellido, losDatos.TipoDeIdentificacion, TipoDeCertificado.DeAutenticacion);
            elDeAutenticacion.FechaDeEmision = DateTime.Now;
            elDeAutenticacion.FechaDeVencimiento = laFechaDeVencimiento;
            elDeAutenticacion.Crl = elCrl;
            losCertificados.Add(elDeAutenticacion);

            RegistroDeEmision elRegistroDeEmision = new RegistroDeEmision();
            elRegistroDeEmision.Identificacion = losDatos.Identificacion;
            elRegistroDeEmision.RegistrosDeCertificados = losCertificados;

            db.Emisiones.Add(elRegistroDeEmision);
            db.SaveChanges();
        }

        private string GenereElSujeto(string laIdentificacion, string elNombre, string elPrimerApellido, string elSegundoApellido, TipoDeIdentificacion elTipoDeIdentificacion, TipoDeCertificado elTipo)
        {
            string elNombreEnMayuscula;
            elNombreEnMayuscula = elNombre.ToUpper();

            string elPrimerApellidoEnMayuscula;
            elPrimerApellidoEnMayuscula = elPrimerApellido.ToUpper();

            string elSegundoApellidoEnMayuscula;
            if (string.IsNullOrEmpty(elSegundoApellido))
                elSegundoApellidoEnMayuscula = string.Empty;
            else
                elSegundoApellidoEnMayuscula = elSegundoApellido.ToUpper();

            string losApellidosUnidos;
            losApellidosUnidos = $"{elPrimerApellidoEnMayuscula} {elSegundoApellidoEnMayuscula}";

            string losApellidosFormateados;
            losApellidosFormateados = losApellidosUnidos.TrimEnd();

            string elProposito;
            if (elTipo == TipoDeCertificado.DeFirma)
                elProposito = "FIRMA";
            else
                elProposito = "AUTENTICACION";

            string elCN;
            elCN = $"CN={elNombreEnMayuscula} {losApellidosFormateados} ({elProposito})";

            string elOU;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elOU = "OU=CIUDADANO";
            else
                elOU = "OU=EXTRANJERO";

            string elO;
            elO = "O=PERSONA FISICA";

            string elC;
            elC = "C=CR";

            string elGivenName;
            elGivenName = "GivenName=" + elNombreEnMayuscula;

            string elSurname;
            elSurname = $"Surname={losApellidosFormateados}";

            string elSerialNumber;
            if (elTipoDeIdentificacion == TipoDeIdentificacion.Cedula)
                elSerialNumber = $"SERIALNUMBER=CPF-{laIdentificacion}";
            else
                elSerialNumber = $"SERIALNUMBER=NUP-{laIdentificacion}";

            return $"{elCN}, {elOU}, {elO}, {elC}, {elGivenName}, {elSurname}, {elSerialNumber}";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                EmisionDBContext db = new EmisionDBContext();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}