using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using introMVC.Models;

namespace introMVC.Gatway
{
    public class iteamGatway
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["MVC"].ConnectionString;
        private int Id;
        private decimal Price;

        public List<iteam> GetAllIteams()
        {
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = "select * from mvc_table";
            connection.Open();
            SqlCommand command=new SqlCommand(query,connection);
         SqlDataReader reader= command.ExecuteReader();
            List<iteam> item=new List<iteam>();
            while (reader.Read())
            {
                iteam aitem=new iteam()
                {
                    id = (int) reader["id"],
                    Name = reader["name"].ToString(),
                    price = Convert.ToDecimal(reader["price"]),
                    //Catagori = (int)reader["catagori"]
                };


                item.Add(aitem);
            }
            reader.Close();
            connection.Close();
          
            return item;




        }


       public int save(iteam a)
        {
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = "insert into mvc_table (name,price,catagori) values('" + a.Name + "','" + a.price + "','" +a.Catagori + "')";
           connection.Open();
           SqlCommand command=new SqlCommand(query,connection);
           int row = command.ExecuteNonQuery();
           connection.Close();
           return row;


        }

      
    }
}