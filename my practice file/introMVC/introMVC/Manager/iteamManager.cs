using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using introMVC.Gatway;
using introMVC.Models;

namespace introMVC.Manager
{
    public class iteamManager
    {


        iteamGatway gatway=new iteamGatway();
        public List<iteam> GetAllIteams()
        {
            return gatway.GetAllIteams();
        }

        public string save(iteam a)
        {
            int rowAffected = gatway.save(a);

            if (rowAffected > 0)
            {
                return "data saved";
            }
            return "data not saved";

        }
    }
}