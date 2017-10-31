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
    public partial class UpdateUI : System.Web.UI.Page
    {
        StudentManager aStudentManager=new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string reg = RegistatinTextBox.Text;
            Student aStudent = aStudentManager.Search(reg);

            if (aStudent== null)
            {
                RegistatinTextBox.Text=String.Empty;
                    NameTextBox.Text=String.Empty;
                ContactNoTextBox.Text=String.Empty;
            DepartmentTextBox.Text=String.Empty;
                Label6.Text = "Registation Number are not founf";

            }
            else
            {   Label6.Text=String.Empty;
                HiddenField1.Value = aStudent.id.ToString();
                RegistatinTextBox.Text = aStudent.Registation;
                NameTextBox.Text = aStudent.Name;
                EmailTextBox.Text = aStudent.Email;
                ContactNoTextBox.Text = aStudent.Contact;
                DepartmentTextBox.Text = aStudent.Department;
            }


        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.id =Convert.ToInt16(HiddenField1.Value);
            aStudent.Registation = RegistatinTextBox.Text;
            aStudent.Name = NameTextBox.Text;
            aStudent.Contact = ContactNoTextBox.Text;
            aStudent.Department = DepartmentTextBox.Text;
            String mss = aStudentManager.update(aStudent);
            Label6.Text = mss;
        }

        
    }
}