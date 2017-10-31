using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class salary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             Salary aSalary=new Salary();
            aSalary.basicAmount = Convert.ToDecimal(TextBox1.Text);
            aSalary.medicalPercenatge = Convert.ToDecimal(TextBox2.Text);
            aSalary.convencePercenytage =Convert.ToDecimal(TextBox3.Text);
            ViewState["salary"] = aSalary;

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Salary aSalary = (Salary)ViewState["salary"];
            Label4.Text=aSalary.GetFullAmount().ToString();



        }

    }
}