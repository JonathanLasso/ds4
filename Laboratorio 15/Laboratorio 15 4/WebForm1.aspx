<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <div>

                <asp:Label ID="Label1" runat="server" Text="Introduzca dos numeros enteros."></asp:Label>

            </div>
            <br />
            <div>

                <asp:Label ID="Label2" runat="server" Text="Primer número"></asp:Label>

            </div>
            <div>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </div>
            <br />
            <div>

                <asp:Label ID="Label3" runat="server" Text="Segundo número"></asp:Label>

            </div>
            <div>

                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>

            </div>
            <br />
            <div>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />

            </div>
            <br />
            <div>

                <asp:Label ID="Label4" runat="server" Text="Resultado:"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
