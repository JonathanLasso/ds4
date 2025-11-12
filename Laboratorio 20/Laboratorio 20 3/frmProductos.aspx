<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="Laboratorio_20_3.InventarioProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style>
    #campos-id-nombre{
        display: grid;
        grid-template-columns: 90px 300px;
        grid-template-rows: 1fr 1fr;
        gap:10px;
    }
    #campos-precio-stock{
        display: grid;
        grid-template-columns: 120px 120px;
        grid-template-rows: 1fr 1fr;
        gap:10px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="tsbNuevo" runat="server" Height="25px" ImageUrl="~/iconos/nuevo.png" OnClick="tsbNuevo_Click" ToolTip="Añadir" />
            <asp:ImageButton ID="tsbGuardar" runat="server" Height="25px" ImageUrl="~/iconos/guardar.png" OnClick="tsbGuardar_Click" ToolTip="Guardar" />
            <asp:ImageButton ID="tsbCancelar" runat="server" Height="25px" ImageUrl="~/iconos/cancelar.png" OnClick="tsbCancelar_Click" ToolTip="Cancelar" />
            <asp:ImageButton ID="tsbEliminar" runat="server" Height="25px" ImageUrl="~/iconos/eliminar.png" OnClick="tsbEliminar_Click" ToolTip="Eliminar" />
            <asp:Label ID="Label1" runat="server" Text="Buscar por id:"></asp:Label>
            <asp:TextBox ID="tstId" runat="server"></asp:TextBox>
            <asp:ImageButton ID="tsbBuscar" runat="server" Height="25px" ImageUrl="~/iconos/buscar.png" OnClick="tsbBuscar_Click" ToolTip="Buscar" />
        </div>
        <br />
        <br />
        <div id="campos-id-nombre">
            <asp:Label ID="Label2" runat="server" Text="Id"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div id="campos-precio-stock">
            <asp:Label ID="Label4" runat="server" Text="Precio"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClientClick="return window.close();" />
        </div>
    </form>
</body>
</html>
