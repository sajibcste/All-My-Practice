<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="GirdViewAndTemplateField.UI.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="EntryHyperLink" runat="server" NavigateUrl="StudentUI.aspx">Entry</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="ViewHyperLink" runat="server" NavigateUrl="ShowAllStudentUI.aspx">ViewAllStudent</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="UpdateHyperLink" runat="server" NavigateUrl="StudentUpdateUI.aspx">UpdateStudent</asp:HyperLink>
    </div>
    </form>
</body>
</html>
