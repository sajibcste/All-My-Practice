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
    public partial class ShowAllStudentUI : System.Web.UI.Page
    {
        StudentsManager manager = new StudentsManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            populateGetView();

        }
        private void populateGetView()
        {
            List<Students> students = manager.GetAlStudentses();

            GridView1.DataSource = students;
            GridView1.DataBind();
        }
    }
}