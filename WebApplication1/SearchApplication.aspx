<%@ Page Title="" Language="C#" MasterPageFile="~/populationmaster.Master" AutoEventWireup="true" CodeBehind="SearchApplication.aspx.cs" Inherits="WebApplication1.SearchApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>User Search</td>
            <td></td>
        </tr>
        <tr>
            <td>
                Use any combination of fields below to search all customers
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>First Name</td>
            <td>Last Name</td>
        </tr>
        <tr>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        </tr>
        <tr><td>DOB</td></tr>
        <tr><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
        <tr><td>Application Id</td>
            
        </tr>
        <tr>
            <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
           
        </tr>
        <tr>
           <td><asp:Button ID="Button1" runat="server" Text="Search" BackColor="Lime" ForeColor="#FFFFCC" OnClick="Button1_Click" style="height: 26px" /></td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
</asp:Content>
