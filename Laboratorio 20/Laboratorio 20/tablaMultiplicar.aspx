<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tablaMultiplicar.aspx.cs" Inherits="Laboratorio_20.tablaMultiplicar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Introduzca un número para crear una tabla de multiplicar."></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TxtEntradaNumero" runat="server" ToolTip="Solo número enteros." OnTextChanged="TxtEntradaNumero_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnCrearTabla" runat="server" Text="Crear tabla" OnClick="BtnCrearTabla_Click" />
        </div>
        <div>
            <asp:PlaceHolder ID="PhTabla" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
