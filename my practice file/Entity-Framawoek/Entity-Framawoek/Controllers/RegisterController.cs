using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity_Framawoek.Models;

namespace Entity_Framawoek.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        public ActionResult Index()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employe employee)
        {
            ViewBag.Departments = GetDepartments();
            return View();
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

        public ActionResult Save()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Save(Employe employee)
        {
            if (ModelState.IsValid)
            {
                string s = "";
            }
            ViewBag.Departments = GetDepartments();
            return View();
        }
    }
}