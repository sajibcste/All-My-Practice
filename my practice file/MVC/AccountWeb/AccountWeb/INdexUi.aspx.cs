using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountWeb
{
    public partial class INdexUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {
            Account account=new Account();
            account.AccountName = AccountnameTextBox.Text;
            account.AccountNumber = AccountNumberTextBOx.Text;
            ViewState["Account"] = account;
            CreateButton.Enabled = false;
        }

        protected void DeposetButton_Click(object sender, EventArgs e)
        {
            Account account = (Account)ViewState["Account"];
            decimal amount = Convert.ToDecimal(AmountTextBox.Text);
            string message = account.Deposited(amount);
            ReportLabel.Text = message;
        }

        protected void withdrowButton_Click(object sender, EventArgs e)
        {
            Account account = (Account) ViewState["Account"];
            decimal amount = Convert.ToDecimal(AmountTextBox.Text);
            string message = account.withdrow(amount);
            ReportLabel.Text = message;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
             Account account = (Account) ViewState["Account"];
            ReportLabel.Text = account.reportshow();
           
        }

    }
}