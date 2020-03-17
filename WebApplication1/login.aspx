<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="scripts/LoginValidations.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="border-spacing:55px">
        <tr>
            <td>
                username

            </td>
            <td>
                <asp:TextBox ID="txtusername" runat="server"  ClientIDMode="Static"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" ClientIDMode="Static" OnTextChanged="txtpassword_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text="" ClientIDMode="Static"></asp:Label>
            </td>
        </tr>
         
        <tr>
            <td>
                <asp:Button ID="txtbutton" runat="server" Text="login" OnClick="txtbutton_Click" OnClientClick="return Validate()"/>
            </td>
        </tr>

    </table>
</asp:Content>
