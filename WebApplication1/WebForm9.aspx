<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="WebApplication1.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                empno
            </td>
            <td>
                <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="cannot be blank" ControlToValidate="txtempno" ForeColor="#FF0066" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                ename
            </td>
            <td>
                <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="cannot be blank" ControlToValidate="txtename" ForeColor="#FF0066" Display="None"></asp:RequiredFieldValidator>
            </td>
        </tr>
       
        <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>
                conform password
            </td>
            <td>
                <asp:TextBox ID="txtconform" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password does not match" ControlToCompare="txtpassword" ControlToValidate="txtconform" Display="None"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                salary
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="salary between 10000 to 200000" ControlToValidate="txtsal" ForeColor="Fuchsia" MaximumValue="200000" MinimumValue="10000" Type="Double" Display="None"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                pancard
            </td>
            <td>
                <asp:TextBox ID="txtpan" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid pancard" ControlToValidate="txtpan" ForeColor="#339933" ValidationExpression="^[A-Z]{5}[0-9]{4}[A-Z]$" Display="None"></asp:RegularExpressionValidator>
            </td>
        </tr>
         
        <tr>
            <td>
                date of birth
            </td>
            <td>
                <asp:TextBox ID="txtdob" TextMode="Date" runat="server"></asp:TextBox>

            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="age must be between 21 to 58" ControlToValidate="txtdob" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="txtbutton" runat="server" Text="Button" OnClick="txtbutton_Click" />
            </td>
        </tr>

    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
