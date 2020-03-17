<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="WebApplication1.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td  >UserId</td>
            <td  >
                <asp:TextBox ID="txtUsername" runat="server" ClientIDMode="Static"   ></asp:TextBox></td>
            <td >
                <asp:RequiredFieldValidator ControlToValidate="txtUsername"  ID  ="RequiredFieldValidator1" runat="server" ErrorMessage="Username cannot be blank" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td >Password</td>
            <td >
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ClientIDMode="Static" ></asp:TextBox></td>
        <td >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Cannot be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            </tr>
        <tr>
            <td >
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

            </td>

        </tr>
        <tr>
            <td ></td>
            <td >
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="58px" OnClick="btnLogin_Click"  />
            </td>
        </tr>
        </table>
</asp:Content>
