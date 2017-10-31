using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.Gatway;
using MVC.Models;

namespace MVC.Manager
{
    public class ItemManager
    {
        ItemGatway gatway=new ItemGatway();
        public string Save(Iteam item)
        {
            int rowAffeted = gatway.Save(item);
            if (rowAffeted > 0)
            {
                return "item save";
            }
            return "save failed";
        }

        public List<Iteam> GetAllStudent()
        {
            return gatway.GetAllStudent();
        }
    }
}