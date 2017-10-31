<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stRegistation.aspx.cs" Inherits="webFirst.UI.stRegistation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 233px;
        }
        .auto-style1 {
            height: 39px;
        }
    </style>
</head>
<body style="height: 223px">
    <form id="form1" runat="server">
    <div>
      <table style="height: 205px; width: 287px">
          <tr>
              <td class="auto-style1"> <asp:Label ID="Label1" runat="server" Text="RegistationNo"></asp:Label>

              </td>
              <td class="auto-style1">
                  <asp:TextBox ID="RegistatinTextBox" runat="server"></asp:TextBox> </td>
              </tr>
         
              <tr>
              <td>
                  <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                  </td>
                  <td>
                  <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox> 

                  </td>

             
              
          </tr>
          <tr>
              <td> <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>

              </td>
              <td>
                  <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox> </td>
              </tr>
              <tr>
              <td>
                  <asp:Label ID="Label4" runat="server" Text="ContactNo"></asp:Label>
                  </td>
                   <td>
                  <asp:TextBox ID="ContactNoTextBox" runat="server"></asp:TextBox> </td>

             
              
          </tr>
          <tr>
              <td><asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
                  </td>
                  <td>
                  <asp:TextBox ID="DepartmentTextBox" runat="server"></asp:TextBox> 
                      </td>
              </tr>
              <tr>
              <td>

                      <br/>
                   
&nbsp; </td>

              <td>
                   
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
                  <br />
                  <br />
                  <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                  </td>

             
              
          </tr>
          
      </table>
    
    </div>
       
    </form>
</body>
</html>
