<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="webFirst.UI.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 <asp:HyperLink ID="entryHyperLink" runat="server" NavigateUrl="stRegistation.aspx">Entry</asp:HyperLink>
        <br/>
 <asp:HyperLink ID="showHyperLink" runat="server" NavigateUrl="showAllData.aspx">ShowAlldata</asp:HyperLink>
        <br/>
 <asp:HyperLink ID="UpdateHyperLink" runat="server" NavigateUrl="UpdateUI.aspx">update</asp:HyperLink>

       
    </div>
    </form>
</body>
</html>
