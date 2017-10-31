using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GirdViewAndTemplateField.BLL;
using GirdViewAndTemplateField.DAL;

namespace GirdViewAndTemplateField.UI
{
    public partial class StudentUpdateUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void on(object sender, EventArgs e)
        {

        }
        StudentsManager manager=new StudentsManager();
        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = registationTextbox.Text;

            Students astudent = manager.searchstudent(regNo);

            if (astudent == null)
            {
                nameTextBox.Text=String.Empty;
                emailTextBox.Text=String.Empty;
                contactNoTextBox.Text=String.Empty;
                messageLabel.Text = "no student found";

            }
            else
            {
                messageLabel.Text=String.Empty;
                idHiddenField.Value = astudent.id.ToString();
                nameTextBox.Text = astudent.Name;
                emailTextBox.Text = astudent.Email;
                contactNoTextBox.Text = astudent.Contact;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {

            Students aStudents=new Students();
            aStudents.id = Convert.ToInt32(idHiddenField.Value);
            aStudents.Name = nameTextBox.Text;
            aStudents.Email = emailTextBox.Text;
            aStudents.Contact = contactNoTextBox.Text;
            string message = manager.updateStudent(aStudents);
            messageLabel.Text = message;

            // int id = Convert.ToInt16(idHiddenField.Value);

        }
    }
}