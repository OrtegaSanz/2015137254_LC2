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
using _2015137254_ENT.IRepositories;

namespace _2015137254_MVC.Controllers
{
    public class AdministradorEquipoesController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;

        public AdministradorEquipoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public AdministradorEquipoesController()
        {

        }

        //private _2015137254DbContext db = new _2015137254DbContext();
        //private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: AdministradorEquipoes
        public ActionResult Index()
        {
            //return View(db.AdministradorEquipos.ToList());
            return View(_UnityOfWork.AdministradorEquipoes.GetAll());
        }

        // GET: AdministradorEquipoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //AdministradorEquipo administradorEquipo = db.AdministradorEquipos.Find(id);
            AdministradorEquipo AdministradorEquipos = _UnityOfWork.AdministradorEquipoes.Get(id.Value);
            if (AdministradorEquipos == null)
            {
                return HttpNotFound();
            }
            return View(AdministradorEquipos);
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
        public ActionResult Create([Bind(Include = "AdministradorEquipoId,Descripcion")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                //db.AdministradorEquipos.Add(administradorEquipo);
                _UnityOfWork.AdministradorEquipoes.Add(administradorEquipo);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipoes.Get(id.Value);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorEquipoId,Descripcion")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(administradorEquipo).State = EntityState.Modified;
                _UnityOfWork.StateModified(administradorEquipo);
                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //AdministradorEquipo administradorEquipo = db.AdministradorEquipos.Find(id);
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipoes.Get(id.Value);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //AdministradorEquipo administradorEquipo = db.AdministradorEquipos.Find(id);
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipoes.Get(id);
            _UnityOfWork.AdministradorEquipoes.Delete(administradorEquipo);
            //db.SaveChanges();
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
