<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script lang="Javascript" type="text/javascript">
        function Validate()
        {
            var eno = document.getElementById("txtemployeeno").value;
            var ename = document.getElementById("txtemployeename").value;
            var job = document.getElementById("txtjob").value;
            var mgr = document.getElementById("txtmanagerid").value;
            var hd = document.getElementById("txthiredate").value;
            var sal = document.getElementById("txtsal").value;
            var comm= document.getElementById("txtcommission").value;
            var deptno = document.getElementById("txtdeptno").value;
            if (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && deptno.length != 0)
                return true;
            else
            {
                alert("enter element details");
                return false;
            }
            
           
        }
    </script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 789px;
        }
        .auto-style3 {
            width: 412px;
        }
        .auto-style6 {
            width: 789px;
            height: 23px;
        }
        .auto-style8 {
            width: 732px;
            height: 23px;
        }
        .auto-style9 {
            width: 732px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style3" >
                <tr>
                    <td class="auto-style8">Employee No</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtemployeeno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Employee Name</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtemployeename" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Job</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtjob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Manager Id</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtmanagerid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Hiredate</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txthiredate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Sal</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Commission</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtcommission" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Deptno</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtdeptno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="btnsubmit" runat="server" Text="Button" OnClientClick="return Validate();" OnClick="btnsubmit_Click"/>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
