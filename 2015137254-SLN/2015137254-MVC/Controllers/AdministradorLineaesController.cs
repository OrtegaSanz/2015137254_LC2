using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2015137254_ENT.Entities;
using _2015137254_PER;
using _2015137254_PER.Repository;

namespace _2015137254_MVC.Controllers
{
    public class AdministradorLineaesController : Controller
    {
        //private _2015137254DbContext db = new _2015137254DbContext();
        private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: AdministradorEquipoes
        public ActionResult Index()
        {
            //return View(db.AdministradorEquipos.ToList());
            return View(unityOfWork.AdministradorLineaes.GetAll());
        }

        // GET: AdministradorEquipoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //AdministradorEquipo administradorEquipo = db.AdministradorEquipos.Find(id);
            AdministradorLinea AdministradorLineas = unityOfWork.AdministradorLineaes.Get(id.Value);
            if (AdministradorLineas == null)
            {
                return HttpNotFound();
            }
            return View(AdministradorLineas);
        }

        // GET: AdministradorEquipoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorEquipoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorLineaId")] AdministradorLinea administradorLineas)
        {
            if (ModelState.IsValid)
            {
                //db.AdministradorEquipos.Add(administradorEquipo);
                unityOfWork.AdministradorLineaes.Add(administradorLineas);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorLineas);
        }

        // GET: AdministradorEquipoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorLinea administradorLineas = unityOfWork.AdministradorLineaes.Get(id.Value);
            if (administradorLineas == null)
            {
                return HttpNotFound();
            }
            return View(administradorLineas);
        }

        // POST: AdministradorEquipoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorLineasId")] AdministradorLinea administradorLineas)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(administradorEquipo).State = EntityState.Modified;
                unityOfWork.StateModified(administradorLineas);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorLineas);
        }

        // GET: AdministradorEquipoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //AdministradorEquipo administradorEquipo = db.AdministradorEquipos.Find(id);
            AdministradorLinea administradorLineas = unityOfWork.AdministradorLineaes.Get(id.Value);
            if (administradorLineas == null)
            {
                return HttpNotFound();
            }
            return View(administradorLineas);
        }

        // POST: AdministradorEquipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //AdministradorEquipo administradorEquipo = db.AdministradorEquipos.Find(id);
            AdministradorLinea administradorLineas = unityOfWork.AdministradorLineaes.Get(id);
            unityOfWork.AdministradorLineaes.Delete(administradorLineas);
            //db.SaveChanges();
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
