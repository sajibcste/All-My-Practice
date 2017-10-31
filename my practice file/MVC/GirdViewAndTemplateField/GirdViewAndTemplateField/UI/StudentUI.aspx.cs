using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GirdViewAndTemplateField.BLL;
using GirdViewAndTemplateField.DAL;

namespace GirdViewAndTemplateField
{
    public partial class StudentUI : System.Web.UI.Page
    {
        StudentsManager manager = new StudentsManager();
        DepartmentManager departmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = departmentManager.GetAllDepartments();
                DropDownList1.DataSource = departments;
                DropDownList1.DataTextField = "code";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }

        }

        

        protected void SaveButton_Click(object sender, EventArgs e)
        {
         
            Students  student=new Students();
            student.Name = NameTextBox.Text;
            student.Reg = RegTextBox.Text;
            student.Email = ContactTextBox.Text;
            student.Contact = EmailTextBox.Text;
            student.DepartmentId = Convert.ToInt16(DropDownList1.SelectedValue);
            MessageLabel.Text = manager.saveStudent(student);

        }
    }
}