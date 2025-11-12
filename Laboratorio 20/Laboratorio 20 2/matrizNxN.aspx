<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="matrizNxN.aspx.cs" Inherits="Laboratorio_20_2.matrizNxN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Introduzca el tamaño de la matriz."></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="TxtTamaño" runat="server" OnTextChanged="TxtTamaño_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnCrearMatriz" runat="server" Text="Crear matriz" OnClick="BtnCrearMatriz_Click" />
        </div>
        <div>
            <asp:Table ID="TableMatriz" runat="server">
            </asp:Table>
        </div>
    </form>
</body>
</html>
