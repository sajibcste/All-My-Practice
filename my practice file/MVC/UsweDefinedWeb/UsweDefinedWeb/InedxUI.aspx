<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InedxUI.aspx.cs" Inherits="UsweDefinedWeb.InedxUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="MiddleName"></asp:Label>
        <asp:TextBox ID="middleNmaeTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="svaeButton" runat="server" OnClick="svaeButton_Click" Text="Save" />
        <br />
        <asp:Button ID="SowAllButton" runat="server" OnClick="SowAllButton_Click" Text="ShowAllName" />
        <br />
        <asp:ListBox ID="showListBox" runat="server" Width="218px"></asp:ListBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
