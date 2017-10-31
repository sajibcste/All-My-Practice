using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using introMVC.Models;

namespace introMVC.Gatway
{
    public class CatagoriesGatway
    {

       public  List<Catagorie> GetAllCatagories()
        {
           string connectionstring = WebConfigurationManager.ConnectionStrings["MVC"].ConnectionString;
           SqlConnection connection=new SqlConnection(connectionstring);
           string query = "select * from catagories";
            connection.Open();
            SqlCommand command=new SqlCommand(query,connection);
         SqlDataReader reader= command.ExecuteReader();
            List<Catagorie> catagories=new List<Catagorie>();
            while (reader.Read())
            {
               Catagorie aCatagorie=new Catagorie()
                {
                        id=(int)reader["id"],
                    name = reader["name"].ToString()
                };

                catagories.Add(aCatagorie);
            }
           reader.Close();
            connection.Close();
          
            return catagories;



            
        }
    }
}