<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllStudentUI.aspx.cs" Inherits="GirdViewAndTemplateField.UI.ShowAllStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="margin-right: 116px" Width="390px">
                <Columns>
                    <asp:TemplateField  HeaderText="id">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                        
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nmae">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                          </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                        </ItemTemplate>
                        
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    
    </div>
    <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="HomeUI.aspx">Home</asp:HyperLink>

    </form>
</body>
</html>
