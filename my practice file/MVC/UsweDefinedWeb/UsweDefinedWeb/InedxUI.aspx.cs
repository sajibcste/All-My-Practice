using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsweDefinedWeb
{
    public partial class InedxUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void svaeButton_Click(object sender, EventArgs e)
        {
            List<pesrson> persons;
            pesrson aperson = new pesrson();
            aperson.FirstName = nameTextBox.Text;
            aperson.MiddleName = middleNmaeTextBox.Text;
            aperson.LastName = lastNameTextBox.Text;
            if (ViewState["person"] == null)
            {
                persons = new List<pesrson>();
            }


            else
            {
                persons = (List<pesrson>) ViewState["person"];
            }
            persons.Add(aperson);
            ViewState["person"] = persons;
        }


        protected void SowAllButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            List<pesrson> persons = (List<pesrson>) ViewState["person"];

            foreach (pesrson aperson in persons)
            {
                string fullName = aperson.FirstName + " " + aperson.MiddleName + " " + aperson.LastName;
                showListBox.Items.Add(fullName);
            }
        }
    }
}
   
