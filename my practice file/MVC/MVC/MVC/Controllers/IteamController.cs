using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using MVC.Manager;
using MVC.Models;

namespace MVC.Controllers
{
    public class IteamController : Controller
    {
        //
        // GET: /Iteam/
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public ActionResult SaveResult()
        //{
        //    Iteam iteam=new Iteam()
        //    {
        //        Id=1,
        //    Name="sajib",
        //    Price=150
        //    };
        //    //ViewBag.iteam = iteam;

        //    return View(iteam);
        //}

        ItemManager manager=new ItemManager();
        CatagorieManager catagorieManager=new CatagorieManager();
        //public string Save(Iteam item)
        //{
        //    return manager.Save(item);
           
        //    }

        [HttpGet]
        public ActionResult Save()
        {
            List<Catagories> catagorieses = catagorieManager.GettAllCatagorieses();
            ViewBag.catagories = catagorieses;
            return View();
        }
        [HttpPost]
        public ActionResult Save(Iteam item)
        {
            List<Catagories> catagorieses = catagorieManager.GettAllCatagorieses();
            ViewBag.catagories = catagorieses;
            ViewBag.message = manager.Save(item);
            return View();
        }

        public ActionResult Index()
        {
            List<Iteam> item = manager.GetAllStudent();
            return View(item);
        }
        
	}
}