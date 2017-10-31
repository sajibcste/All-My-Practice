using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entity_Framawoek.Models;
using Entity_Framawoek.Context;

namespace Entity_Framawoek.Controllers
{
    public class EmployeController : Controller
    {
        private ProjectDbContext db = new ProjectDbContext();

        // GET: /Employe/
        public ActionResult Index()
        {
            return View(db.Employes.ToList());
        }

        // GET: /Employe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = db.Employes.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        // GET: /Employe/Create
        public ActionResult Create()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        // POST: /Employe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Employe employe)
        {
            if (ModelState.IsValid)
            {
                db.Employes.Add(employe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = GetDepartments();

            return View(employe);
        }

        // GET: /Employe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = db.Employes.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        // POST: /Employe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Email,Gender,Department,Address,Password")] Employe employe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employe);
        }

        // GET: /Employe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employe employe = db.Employes.Find(id);
            if (employe == null)
            {
                return HttpNotFound();
            }
            return View(employe);
        }

        // POST: /Employe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employe employe = db.Employes.Find(id);
            db.Employes.Remove(employe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private List<SelectListItem> GetDepartments()
        {
            List<SelectListItem> items = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "", Text = "Select..."},
                new SelectListItem() {Value = "HR", Text = "Human Resource"},
                new SelectListItem() {Value = "SD", Text = "Software Development"},
                new SelectListItem() {Value = "SI", Text = "Software Implement"}
            };
            return items;
        }
    }
}
