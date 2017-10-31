﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUpdateUI.aspx.cs" Inherits="GirdViewAndTemplateField.UI.StudentUpdateUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label ID="label1" runat="server" Text="RegistationNo"></asp:Label></td>
                <td><asp:TextBox ID="registationTextbox" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
            <td></td>
            <td>
                <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" /></td>
        </tr> 
            
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
            <td>
                <asp:HiddenField ID="idHiddenField" runat="server" />
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label></td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Contact Number"></asp:Label></td>
            <td>
                <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox></td>
        </tr>
            <tr>
            <td></td>
            <td>
                <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />

            </td>
        </tr>
            <tr>
            <td colspan="2">
                <asp:Label ID="messageLabel" runat="server"></asp:Label>
            </td>
        </tr>
        </table>
        <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="HomeUI.aspx">Home</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
