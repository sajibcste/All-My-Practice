using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webFirst.BLL;
using webFirst.DAL.MODEL;

namespace webFirst.UI
{
    public partial class UPforQueryStringUI : System.Web.UI.Page
    {
        StudentManager  aStudentManager=new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            Student student = aStudentManager.GetAllStudentsById(id);

            if (student!=null)
            {
                FormLoadAllGetValue(student);
            }



        }

        private void FormLoadAllGetValue(Student student)
        {
            //HiddenField1.Value = student.id.ToString();
            RegistatinTextBox.Text = student.Registation;
            NameTextBox.Text = student.Name;
            EmailTextBox.Text = student.Email;
            ContactNoTextBox.Text = student.Contact;
            DepartmentTextBox.Text = student.Department;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}