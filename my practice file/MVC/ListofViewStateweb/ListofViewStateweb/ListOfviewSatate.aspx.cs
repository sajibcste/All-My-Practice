using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListofViewStateweb
{
    public partial class ListOfviewSatate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        
        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<string> nameList;
            string name = nameTextBox.Text;
            
            nameTextBox.Text=String.Empty;
            if (ViewState["names"] == null)
            {
                nameList=new List<string>();
               
            }
            else
            {
               nameList =(List<string>)ViewState["names"];
                nameList.Add(name);
                ViewState["names"] = nameList;
            }
            nameList.Add(name);
            ViewState["names"] = nameList;
  
            



        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();

            List<string> nameliList = (List<string>) ViewState["names"];
           
            foreach (string name in nameliList)
            {
                nameListBox.Items.Add(name);
            }
            countLabel.Text = "total count" + nameliList.Count.ToString();


        }
    }
}