<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webForm1.aspx.cs" Inherits="Parcial_3_de_DSVI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Listas de los casos</h1>
        </div>
        <div class="row">
            <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
             allowSorting="true" AllowPaging="true"
             DataKeyNames="Id_caso"
             AutoGenerateEditButton="true"
             runat="server" />

         <asp:SqlDataSource ID="MyDataSource1" runat="server"
            ConnectionString="Data Source=localhost;Initial Catalog=JonathanLasso;Integrated Security=True;"
            ProviderName="System.Data.SqlClient"
            SelectCommand="SELECT Id_caso, Nombre, Descripcion, Tipo_caso FROM JL_CASOS"
            UpdateCommand="UPDATE JL_CASOS SET Nombre=@Nombre, Descripcion=@Descripcion, Tipo_caso=@Tipo_caso WHERE Id_caso=@Id_Caso">
        </asp:SqlDataSource>
        </div>
        <div>
            <h1>Formulario para agregar casos</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Nombre del caso"></asp:Label>
                <asp:TextBox ID="txbNombreCaso" runat="server" OnTextChanged="txbNombreCaso_TextChanged"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Descripción del caso"></asp:Label>
                <asp:TextBox ID="txbDescripcionCaso" runat="server" OnTextChanged="txbDescripcionCaso_TextChanged"></asp:TextBox>
            </div>
            <div>

                <asp:Label ID="Label3" runat="server" Text="Tipo de caso "></asp:Label>
                <asp:TextBox ID="txbTipoCaso" runat="server" OnTextChanged="txbTipoCaso_TextChanged"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btAgregarCaso" runat="server" Text="Agregar caso" OnClick="btAgregarCaso_Click" />
            </div>
        </div>
    </form>
</body>
</html>
