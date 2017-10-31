using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Gatway;
using MVC.Models;

namespace MVC.Manager
{
    public class CatagorieManager
    {
        CatagorieGatWay catagorieGatWay=new CatagorieGatWay();
       public  List<Catagories> GettAllCatagorieses()
        {
            return catagorieGatWay.GetAllCatagorie();
        }
    }
}