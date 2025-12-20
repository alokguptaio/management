<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="HomeFrom.aspx.cs" Inherits="tblemployee.HomeFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>WELCOME <asp:Label ID="lblname1" runat="server"></asp:Label></h1>
    <table>
        <tr>
           <td>User Name:</td>
           <td><asp:Label ID="lblname" runat="server"></asp:Label></td>
       </tr>
       <tr>
           <td>User Gender:</td>
           <td><asp:Label ID="lblgender" runat="server"></asp:Label></td>
       </tr>
        <tr>
           <td>Data of Birth:</td>
           <td><asp:Label ID="lbldob" runat="server"></asp:Label></td>
       </tr>
        <tr>
            <td>User Course:</td>
            <td><asp:Label ID="lblcourse" runat="server"></asp:Label></td>
        </tr>
        <tr>
           <td>Email Id:</td>
           <td><asp:Label ID="lblemail" runat="server"></asp:Label></td>
       </tr>
       <tr>
           <td>Password:</td>
           <td><asp:Label ID="lblpassword" runat="server"></asp:Label></td>
       </tr>
       <tr>
           
           <td><asp:Button ID="lbledit" runat="server" Text="Edit" OnClick="lbledit_Click" /></td>
           <td><asp:Button ID="lbldelete" runat="server" Text="Delete" OnClick="lbldelete_Click" /></td>
       </tr>  
        <tr>
            <td>           
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>      
        </tr>
    </table>
</asp:Content>
