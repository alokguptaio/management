<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="LoginFrom.aspx.cs" Inherits="tblemployee.LoginFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
     <tr>
         <td>Email Id:</td>
         <td><asp:TextBox ID="tbemail" runat="server"></asp:TextBox></td>
     </tr>
    <tr>
          <td>Password:</td>
         <td><asp:TextBox ID="tbpassword" runat="server"></asp:TextBox></td>
     </tr> 
    <tr>
        <td></td>
        <td><asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" /></td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Label ID="lblmsg" runat="server"></asp:Label></td>
    </tr>

</table>
</asp:Content>
