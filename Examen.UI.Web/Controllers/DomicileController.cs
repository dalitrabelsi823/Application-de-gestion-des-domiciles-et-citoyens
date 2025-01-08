using Castle.Core.Internal;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.UI.Web.Controllers
{
    [Route("Domicile")]
    public class DomicileController : Controller
    {
        readonly IServiceDomicile serviceDomicile;
        readonly IServiceCitoyen serviceCitoyen;
        public DomicileController(IServiceDomicile serviceDomicile,IServiceCitoyen serviceCitoyen)
        {
            this.serviceDomicile = serviceDomicile;
            this.serviceCitoyen = serviceCitoyen;
        }

        // GET: DomicileController
        
        [HttpGet("")]
        public ActionResult Index(string gouvernorat,string ville)
        {
            var domiciles = serviceDomicile.GetAll();
            if(!string.IsNullOrEmpty(gouvernorat))
            {
                return View(domiciles.Where(d=>d.MyBatiment.Gouvernorat.Equals(gouvernorat)));

            }
            if(!string.IsNullOrEmpty(ville))
            {
                return View(domiciles.Where(d => d.MyBatiment.ville.Equals(ville)));
            }
            return View(domiciles);
            
        }

        // GET: DomicileController/Details/5
        [HttpGet("Details/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DomicileController/Create
        [HttpGet("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: DomicileController/Create
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DomicileController/Edit/5
        [HttpGet("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DomicileController/Edit/5
        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DomicileController/Delete/5
        [HttpGet("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost("Delete/{id}")]

        // POST: DomicileController/Delete/5
        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet("Habitants/{id}")]
        
        public ActionResult Habitants(int id, IFormCollection collection)
        {
            return View(serviceCitoyen.CitoyensBatiment(id));
             
        }


    }
}
