using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GirdViewAndTemplateField.DAL
{
    public class DepartmentGatway:MainGatway
    {


        public List<Department> GetAllDepartments()
        {

            query = "select * from Department";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Department> departments=new List<Department>();

            while (reader.Read())
            {
                Department department=new Department();
                department.id = Convert.ToInt16(reader["id"]);
                department.code = reader["Code"].ToString();
                department.Name = reader["Name"].ToString();
                departments.Add(department);
            }
            reader.Close();
            connection.Close();
            return departments;
        }
    }
}