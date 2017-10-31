
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="AccountUI.IndexUI" %>

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
            <asp:Label ID="Label1" runat="server" Text="CustomarName"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="AccountNo"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="createButton" runat="server" Text="Create" OnClick="createButton_Click" />
             </fieldset>
            <br/>
        <fieldset>
             <legend>Account</legend>
            <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
             <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br/>
            <br/>
            <asp:Button ID="DepositButton" runat="server" Text="Deposit" OnClick="DepositButton_Click" />  &nbsp;<asp:Button ID="WithdrawButton" runat="server" Text="withdraw" OnClick="WithdrawButton_Click" />
            
            
             <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="report" />
            
            
             <br />
             
             <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
             <br />
            
            
            </fieldset>

       
    
    </div>
    </form>
</body>
</html>
