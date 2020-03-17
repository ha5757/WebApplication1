<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>one</asp:ListItem>
        <asp:ListItem>two</asp:ListItem>
    </asp:RadioButtonList>
            </td>
       
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> and
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
        </table>
</asp:Content>
