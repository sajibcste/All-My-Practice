using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Entity_Framawoek.Models;

namespace Entity_Framawoek.Context
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Employe> Employes { get; set; }
    }
}