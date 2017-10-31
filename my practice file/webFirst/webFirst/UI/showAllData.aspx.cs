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
    public partial class showAllData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetviewValue();
        }

        protected void deletelikButton_click(object sender, EventArgs e)
        {
            
            LinkButton deleButton=sender as LinkButton;
            DataControlFieldCell cell=deleButton.Parent as DataControlFieldCell;
            GridViewRow selecGridViewRow=cell.Parent as GridViewRow;
            HiddenField selectedid = selecGridViewRow.FindControl("idhiddenField") as HiddenField;
            int id = Convert.ToInt16(selectedid.Value);
            StudentManager aStudentManager=new StudentManager();
            string mss = aStudentManager.Delete(id);
            Response.Write(mss);
        }

        protected void updatelikButton_click(object sender, EventArgs e)
        {

            LinkButton update = sender as LinkButton;
            DataControlFieldCell cell = update.Parent as DataControlFieldCell;
            GridViewRow selecGridViewRow = cell.Parent as GridViewRow;
            HiddenField selectedid = selecGridViewRow.FindControl("idhiddenField") as HiddenField;
            int id = Convert.ToInt16(selectedid.Value);
            Response.Redirect("UPforQueryStringUI.aspx?id="+id);
        }
        private void GetviewValue()
        {
            StudentManager aStudentManager = new StudentManager();

            List<Student> student = aStudentManager.GetAllStudents();
            GridView1.DataSource = student;
            GridView1.DataBind();
        }
    }
}