<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showAllData.aspx.cs" Inherits="webFirst.UI.showAllData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
         <Columns>
             <asp:TemplateField>
                 <ItemTemplate>
                     <asp:HiddenField runat="server" id="idhiddenField"  Value='<%#Eval("id") %>'/>
                     <asp:Label runat="server" Text='<%#Eval("Registation") %>'></asp:Label>
               </ItemTemplate>

             </asp:TemplateField>
              <asp:TemplateField>
                 <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>
               </ItemTemplate>

             </asp:TemplateField>
              <asp:TemplateField>
                 <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Email") %>'> </asp:Label>
               </ItemTemplate>

             </asp:TemplateField>
              <asp:TemplateField>
                 <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Contact") %>'> </asp:Label>
               </ItemTemplate>

             </asp:TemplateField>
              <asp:TemplateField>
                 <ItemTemplate>
                     <asp:Label runat="server" Text='<%#Eval("Department") %>'> </asp:Label>
               </ItemTemplate>

             </asp:TemplateField>
            
              <asp:TemplateField>
                 <ItemTemplate>
        <asp:LinkButton runat="server" ID="updatelinkButton" Text="update" OnClick="updatelikButton_click">
            </asp:LinkButton>
        <asp:LinkButton runat="server" ID="deletelinkButton" Text="delete" OnClick="deletelikButton_click">
    </asp:LinkButton>
                 </ItemTemplate>
             </asp:TemplateField>
          </Columns>
         </asp:GridView>
       
    </div>
    </form>
</body>
</html>
