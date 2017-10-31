using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication2.DAL.Model;

namespace WebApplication2.DAL.Gatway
{
    public class StudentGatway
    {
        string connectionstring = "Server=PC-NET;Database=LastDatbase;Integrated Security=True";

     public int  StudentEntry(Student astudent)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "insert into Students  values('"+astudent.Name+"','"+astudent.Reg+"','"+astudent.Email+"','"+astudent.Contact+"')";
         SqlCommand command=new SqlCommand(query,connection);
         connection.Open();
         int rowAffec = command.ExecuteNonQuery();
         return rowAffec;
        }

        public bool isExit(string regNo)
        {
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = "select * from Students where Reg='"+regNo+"'";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            bool hasRows = false;

            if (reader.HasRows)
            {
                hasRows = true;
            }
            connection.Close();
            return hasRows;

        }
    }
}