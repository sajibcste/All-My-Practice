﻿using System.Web;
using System.Web.Mvc;

namespace Entity_Framawoek
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
