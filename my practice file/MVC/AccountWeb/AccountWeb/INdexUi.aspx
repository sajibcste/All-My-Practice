<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="INdexUi.aspx.cs" Inherits="AccountWeb.INdexUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <fieldset>
           <legend>Account</legend>
           

           <asp:Label ID="Label1" runat="server" Text="AccountName"></asp:Label>
           <asp:TextBox ID="AccountnameTextBox" runat="server"></asp:TextBox>
           <br />
           <asp:Label ID="Label2" runat="server" Text="AccountNumber"></asp:Label>
           <asp:TextBox ID="AccountNumberTextBOx" runat="server"></asp:TextBox>
           <br />
           <asp:Button ID="CreateButton" runat="server" Text="Create" OnClick="CreateButton_Click" />
           <br />
           <br />
           

       </fieldset>
        <fieldset>
            <legend>Transaction</legend>

            <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
            <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="DeposetButton" runat="server" OnClick="DeposetButton_Click" Text="Deposet" />
&nbsp;
            <asp:Button ID="withdrowButton" runat="server" OnClick="withdrowButton_Click" Text="Withdrow" />
            <br />
            <asp:Button ID="ReportButon" runat="server" OnClick="Button4_Click" Text="Report" />
            <br />
            <asp:Label ID="ReportLabel" runat="server" Text="Label"></asp:Label>
            <br />

        </fieldset>
    
    </div>
    </form>
</body>
</html>
