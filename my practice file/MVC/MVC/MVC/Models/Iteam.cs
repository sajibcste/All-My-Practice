using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Iteam
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CatagoriesId { get; set; }
    }
}