<%@ Page Title="" Language="C#" MasterPageFile="~/populationmaster.Master" AutoEventWireup="true" CodeBehind="CreateApplication.aspx.cs" Inherits="WebApplication1.CreateApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 129px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    
    <tr>
        <td class="auto-style7">Create Application</td>
        <td></td>
        <td></td>
        <td style="color: #FF0000">*Required Field</td>
    </tr>
    <tr>
          <td class="auto-style7">
              <asp:Label ID="Label1" runat="server" Text="*"></asp:Label>  First Name</td>  
        <td></td>
          <td><asp:Label ID="Label2" runat="server" Text="Middle Name"></asp:Label></td>
        <td></td>
          <td>
              <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label> Last Name</td>
        <td></td>
           <td><asp:Label ID="Label4" runat="server" Text="Suffix"></asp:Label></td>
       
    </tr>
    <tr>
        
            <td class="auto-style7"><asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox></td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtfirstname" ErrorMessage="Required" ValidationExpression="[A-Za-z@,']{0,32}"></asp:RegularExpressionValidator>
            </td>
            <td><asp:TextBox ID="txtmiddlename" runat="server"></asp:TextBox></td>
             <td></td>
            <td><asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>
        <td></td>
            <td><asp:DropDownList ID="ddlsuffix" runat="server">
                <asp:ListItem>mr</asp:ListItem>
                <asp:ListItem>mrs</asp:ListItem>
                <asp:ListItem>ms</asp:ListItem>
                </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label>
            Date Of Birth</td>
        <td></td>
        <td>
            <asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label>
            Gender</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:TextBox ID="txtdob" runat="server" TextMode="Date"></asp:TextBox>
        </td>
        <td>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtdob" ErrorMessage="required" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        </td>
        <td>
            <asp:RadioButton ID="rdbmale" runat="server" GroupName="gender" Text="Male" />
         </td>
        <td>
            <asp:RadioButton ID="rdbfemale" runat="server" GroupName="gender" Text="Female" />
        </td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td><asp:Button ID="Button1" runat="server" Text="Add Member" BackColor="Lime" ForeColor="#FFFFCC" OnClick="Button1_Click" /></td>
    </tr>
    <tr>
        <td> <asp:Button ID="Button2" runat="server" Text="Save and Exit" BackColor="Lime" ForeColor="#FFFFCC" OnClick="Button2_Click" CausesValidation="False" /></td>
    </tr>
</table>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
