using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using introMVC.Manager;
using introMVC.Models;
using Microsoft.Owin.Security.Provider;

namespace introMVC.Controllers
{
    public class iteamController : Controller
    {
        ////
        //// GET: /iteam/
        //public ActionResult Index()
        //{
        //    return View();
        //}
      
//        public ActionResult Save()
//{
//    return View();

//}
        iteamManager manager=new iteamManager();
       CatagprieIteamManager aManager=new CatagprieIteamManager();
        public ActionResult Save()

        {

            List<iteam> iteams = manager.GetAllIteams();
            //ViewBag.iteam=aiteam;
            return View(iteams);
        }
            [HttpGet]
        public ActionResult Index()
            {
                List<Catagorie> catagories = aManager.GetACatagories();
                ViewBag.catagories = catagories;
          return  View();

        }
        [HttpPost]
        public ActionResult Index(iteam a)
        {
            List<Catagorie> catagories = aManager.GetACatagories();
            ViewBag.catagories = catagories;
            ViewBag.Message = manager.save(a);
            return View();

        }
          
        //public ActionResult SaveIteam()
        //{
        //    ViewBag.Message = manager.save(a);
        //    return View();
            
        //}
        
        //public ActionResult SaveIteam(iteam a)
        //{
            
        //}
    }

    
}