using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using HtmlHelper.Models;

namespace HtmlHelper.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Save()
        {
            ViewBag.Department = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Save(Employe employe)
        {
            ViewBag.Department = GetDepartments();
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
	}
}