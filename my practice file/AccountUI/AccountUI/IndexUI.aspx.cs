using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountUI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Account aAccount;
        protected void createButton_Click(object sender, EventArgs e)
        {
             aAccount=new Account();
            aAccount.customerName = TextBox1.Text;
            aAccount.AccountNo = TextBox2.Text;
            ViewState["account"] = aAccount;


        }

        protected void DepositButton_Click(object sender, EventArgs e)
        {
            Account aAccount = (Account)ViewState["account"];
            Decimal Amount =Convert.ToDecimal(TextBox3.Text);
            string message = aAccount.DepositAmount(Amount);
            Label4.Text = message;

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void WithdrawButton_Click(object sender, EventArgs e)
        {
            Account aAccount = (Account)ViewState["account"];
            Decimal Amount = Convert.ToDecimal(TextBox3.Text);
            string message = aAccount.withdraw(Amount);
            Label4.Text = message;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Account aAccount = (Account)ViewState["account"];
            string fullinfo = aAccount.GetInfo();
            Label4.Text = fullinfo;
        }

 
        
    }
}