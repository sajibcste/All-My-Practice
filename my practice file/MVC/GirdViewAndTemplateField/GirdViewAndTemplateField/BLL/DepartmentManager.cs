using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GirdViewAndTemplateField.DAL;

namespace GirdViewAndTemplateField.BLL
{
    public class DepartmentManager
    {
        DepartmentGatway departmentGatway=new DepartmentGatway();
        public List<Department> GetAllDepartments()
        {
            return departmentGatway.GetAllDepartments();
        }
    }
}