using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using introMVC.Gatway;
using introMVC.Models;

namespace introMVC.Manager
{
    public class CatagprieIteamManager
    {
        CatagoriesGatway aCatagoriesGatway=new CatagoriesGatway();

        public List<Catagorie> GetACatagories()
        {
            return aCatagoriesGatway.GetAllCatagories();

        }


    }
}