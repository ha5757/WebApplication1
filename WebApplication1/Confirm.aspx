<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="WebApplication1.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Empno</td>
           <td><asp:Label ID="lblEmpno" runat="server" Text="Label"></asp:Label></td>
        </tr>
         <tr>
            <td>Ename</td>
           <td><asp:Label ID="lblEname" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Job</td>
           <td><asp:Label ID="lblJob" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>mgr</td>
           <td><asp:Label ID="lblMgr" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Hiredate</td>
           <td><asp:Label ID="lblHiredate" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>salary</td>
           <td><asp:Label ID="lblSalary" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>Commission</td>
           <td><asp:Label ID="lblCommission" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td>detno</td>
           <td><asp:Label ID="lblDeptno" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            
           <td>
               <asp:Button ID="btnConfirm" runat="server" Text="Button" /></td>
        </tr>
    </table>
</asp:Content>
