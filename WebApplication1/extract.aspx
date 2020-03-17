<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="extract.aspx.cs" Inherits="WebApplication1.extract" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            margin-top: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
    enter the deptno:<asp:DropDownList ID="ddlDeptno" runat="server" OnSelectedIndexChanged="ddlDeptno_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
            <asp:ListItem Value="-1">select</asp:ListItem>
        </asp:DropDownList>
        <asp:GridView ID="gvData" runat="server" CssClass="auto-style6"></asp:GridView>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </h2>
</asp:Content>
