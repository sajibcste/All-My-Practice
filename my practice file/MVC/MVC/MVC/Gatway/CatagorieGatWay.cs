using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MVC.Models;

namespace MVC.Gatway
{
    public class CatagorieGatWay
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["ItemDBConnString"].ConnectionString;

      public   List<Catagories> GetAllCatagorie()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from catgorie";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Catagories> catagorieses=new List<Catagories>();
            while (reader.Read())
            {
                Catagories catagories=new Catagories()
                {
                    Id=(int)reader["id"],
                    Name = reader["name"].ToString()
                };
                catagorieses.Add(catagories);

            }
            reader.Close();
            connection.Close();
            return catagorieses;

        }
    }
}