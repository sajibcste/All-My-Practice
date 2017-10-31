<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfviewSatate.aspx.cs" Inherits="ListofViewStateweb.ListOfviewSatate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    y</div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <br />
        
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" style="height: 26px" Text="show All" />
        <br />
        <br />
        <asp:ListBox ID="nameListBox" runat="server" Height="70px" Width="181px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="countLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
