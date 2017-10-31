using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MVC.Models;

namespace MVC.Gatway
{
    public class ItemGatway
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["ItemDBConnString"].ConnectionString;

        public int Save(Iteam item)
        {
            //string connectionstring = WebConfigurationManager.ConnectionStrings["ItemDBConnString"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "insert into Items values ('" + item.Name + "','" + item.Price + "','"+item.CatagoriesId+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowaffected = command.ExecuteNonQuery();
            connection.Close();
            return rowaffected;


        }

        public List<Iteam> GetAllStudent()
        {
            SqlConnection connection=new SqlConnection(connectionstring);

            string query = "select * from Items ";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
           List<Iteam> items= new List<Iteam>();
            while (reader.Read())
            {
                Iteam iteam=new Iteam()
                {
                    Id = (int)reader["id"],
                    Name=reader["name"].ToString(),
                    Price=Convert.ToDecimal(reader["price"]),
                    CatagoriesId = (int)reader["catagorieId"]
 
                };
                items.Add(iteam);

            }
             reader.Close();
            connection.Close();
            return items;
        }
    }
}