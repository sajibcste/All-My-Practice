using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using webFirst.BLL;
using webFirst.DAL.MODEL;

namespace webFirst.UI
{
    public partial class stRegistation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.Registation = RegistatinTextBox.Text;
            aStudent.Name = NameTextBox.Text;
            aStudent.Email = EmailTextBox.Text;
            aStudent.Contact = ContactNoTextBox.Text;
            aStudent.Department = DepartmentTextBox.Text;
            StudentManager aStudentManager=new StudentManager();
             Label6.Text = aStudentManager.Add(aStudent);
            

        }

       
    }
}