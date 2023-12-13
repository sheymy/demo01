<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPrincipalOld.aspx.cs" Inherits="DemoWeb01.MenuPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblUsuario" runat="server" Text="[Usuario]"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblFechaHora" runat="server" Text="[FechayHora]"></asp:Label>
            <br />
        </p>
        <p>
            &nbsp;</p>
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
