<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="RegistrationFrom.aspx.cs" Inherits="tblemployee.RegistrationFrom" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td>User Name:</td>
            <td><asp:TextBox ID="tbname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>User Gender:</td>
            <td><asp:RadioButtonList ID="rblgender" runat="server" RepeatColumns="3">
                <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                <asp:ListItem Text="Transgender" Value="3"></asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td>Data of Birth:</td>
            <td><asp:TextBox ID="txtdob" runat="server"></asp:TextBox></td>
            <ajax:CalendarExtender ID="caldob" runat="server" PopupButtonID="txtdob" PopupPosition="TopRight" TargetControlID="txtdob" />
         </tr>
         <tr>
                <td>User Cuorse:</td>
                <asp:DropDownList ID="ddlcourse" runat="server">
                    <asp:ListItem Text="--SELECTE--" Value="1"></asp:ListItem>
                    <asp:ListItem Text="M.Tech" Value="2"></asp:ListItem>
                    <asp:ListItem Text="B.Tech" Value="3"></asp:ListItem>
                    <asp:ListItem Text="MCA" Value="4"></asp:ListItem>
                    <asp:ListItem Text="BCA" Value="5"></asp:ListItem>
                </asp:DropDownList>
            </tr>
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
                    <td><asp:Button ID="btnregistration" runat="server" Text="Register" OnClick="btnregistration_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Label ID="lblmsg" runat="server"></asp:Label></td>
                </tr>

    </table>
</asp:Content>
