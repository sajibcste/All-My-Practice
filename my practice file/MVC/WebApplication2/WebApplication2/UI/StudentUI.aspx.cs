using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.BLL;
using WebApplication2.DAL.Model;

namespace WebApplication2.UI
{
    public partial class StudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        StudentMnager aMnager=new StudentMnager();
        protected void SaveButton_Click(object sender, EventArgs e)
        {

            Student astudent=new Student();
            astudent.Name = nameTextBox.Text;
            astudent.Reg = regtextBox.Text;
            astudent.Email = EmailTextBox.Text;
            astudent.Contact = contactTextBox.Text;
            showLabel.Text = aMnager.Save(astudent);


        }
    }
}