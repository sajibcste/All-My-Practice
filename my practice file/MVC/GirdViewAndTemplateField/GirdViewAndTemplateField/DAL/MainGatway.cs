using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;

namespace GirdViewAndTemplateField.DAL
{
    public class MainGatway
    {
        private string connectionstring = WebConfigurationManager.ConnectionStrings["newdatabase"].ConnectionString;

        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }
        public SqlDataReader reader { get; set; }
        public string query { get; set; }



        public MainGatway()
        {
            connection = new SqlConnection(connectionstring);
            command = new SqlCommand();

        }
    }
}