<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <td>
        <asp:RadioButton ID="rdbhiredate" runat="server" GroupName="G1" OnCheckedChanged="rdbhiredate_CheckedChanged" Text="Joining Date" AutoPostBack="True" />
        </td>
        <td>
            <asp:TextBox ID="txtstart" runat="server" TextMode="Date" ></asp:TextBox>
            and
            <asp:TextBox ID="txtend" runat="server" TextMode="Date"></asp:TextBox>
        </td></tr>
    <tr><td>
        <asp:RadioButton ID="rdbdeptno" runat="server" GroupName="G1" Text="Deptno" OnCheckedChanged="rdbdeptno_CheckedChanged" AutoPostBack="True"/>
        </td><td>
            <asp:DropDownList ID="ddldeptno" runat="server" AutoPostBack="True" >
                <asp:ListItem Value="-1">select</asp:ListItem>
            </asp:DropDownList>
        </td></tr>

       

</table>
     <asp:GridView ID="gvdata" runat="server"></asp:GridView>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</asp:Content>
