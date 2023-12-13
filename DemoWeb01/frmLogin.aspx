<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="DemoWeb01.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 63%;
            height: 53px;
        }
        .auto-style2 {
            width: 77px;
        }
        .auto-style3 {
            width: 244px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
    <table class="auto-style1" border ="1">
        <tr>
            <td class="auto-style2">Usuario:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Clave:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <div>
        </div>
        <input id="DataOculta" name="DataOculta" runat="server" type="hidden" />
    </form>
    <p>
        
    </p>
</body>
</html>
