using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["Name"] = nameTextBox.Text;

             nameTextBox.Text=String.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = ViewState["Name"].ToString();

        }
    }
}