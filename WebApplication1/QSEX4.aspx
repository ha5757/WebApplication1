<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QSEX4.aspx.cs" Inherits="WebApplication1.QSEX4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script lang="JavaScript" type="text/javascript">
          function func1() {
             
              window.open("QSEX5.aspx?A=10&B=20");
          }

</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
