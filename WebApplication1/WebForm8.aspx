<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            margin-top: 8px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CssClass="auto-style7" OnPageIndexChanging="FormView1_PageIndexChanging">
        <ItemTemplate>
            <table class="auto-style6">
                <tr>
                    <td>orderid</td>
                    <td>orderdesc</td>
                    <td>total</td>
                    <td>totalcost</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("orderid") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("orderdesc") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("total") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server"  Text='<%# Eval("totalcost") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
   
    

    
</asp:Content>
