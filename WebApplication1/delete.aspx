<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="WebApplication1.delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
<table>
    <tr>
        <td>
            employeeno
        </td>
        <td>
            <asp:TextBox ID="txtempno" runat="server"  ClientIDMode="Static" AutoPostBack="True" OnTextChanged="txtempno_TextChanged"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td>
            ename

        </td>
        <td>
            <asp:TextBox ID="txtename" runat="server" ClientIDMode="Static"></asp:TextBox>

        </td>

    </tr>
    <tr>
        <td>
          job
        </td>
        <td>
            <asp:TextBox ID="txtjob" runat="server" ClientIDMode="Static"></asp:TextBox>

        </td>
    </tr>
    
    <tr>
        <td>
            hire_date
        </td>
        <td>
            <asp:TextBox ID="txthiredate" runat="server" ClientIDMode="Static"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td>
            mgr
        </td>
        <td>
            <asp:TextBox ID="txtmgr" runat="server" ClientIDMode="Static"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            salary
        </td>
        <td>
            <asp:TextBox ID="txtsal" runat="server" ClientIDMode="Static"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            commission
        </td>
        <td>
            <asp:TextBox ID="txtcomm" runat="server" ClientIDMode="Static"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td>
            deptno
        </td>
        <td>
            <asp:TextBox ID="txtdeptno" runat="server" ClientIDMode="Static"></asp:TextBox>

        </td>
    </tr>
    <tr>
       
        <td>
            <asp:Button ID="txtbutton" runat="server" Text="insert" OnClick="txtbutton_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMessage" runat="server" Text="" ClientIDMode="Static"></asp:Label>
        </td>
    </tr>

</table>


</asp:Content>
