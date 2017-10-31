using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataHandler.Serializer;

namespace introMVC.Models
{
    public class iteam
    {


        public int id { get; set; }
        public string Name { get; set; }
        public decimal price { get;set; }

        public int Catagori { get; set; }
    }
}