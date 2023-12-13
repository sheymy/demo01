<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DemoWeb01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> 
           
            <label id="Label2" for="HTML"> Label</label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="Text2" type="text" runat="server" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:GridView ID="GridCategorias" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridCategorias_RowDeleting" OnSelectedIndexChanged="GridCategorias_SelectedIndexChanged" OnRowCancelingEdit="GridCategorias_RowCancelingEdit" OnRowEditing="GridCategorias_RowEditing" OnRowUpdated="GridCategorias_RowUpdated" OnRowUpdating="GridCategorias_RowUpdating">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="Codigo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Descrip" HeaderText="Descripcion" SortExpression="Descrip" />
                <asp:CommandField ButtonType="Button" DeleteText="Eliminar" ShowDeleteButton="True" ShowHeader="True" />
                <asp:CommandField ButtonType="Button" EditText="Editar" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
