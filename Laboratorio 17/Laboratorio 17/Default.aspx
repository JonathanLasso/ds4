<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


     <div class="row">
         <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
             allowSorting="true" AllowPaging="true"
             DataKeyNames="ProductID"
             AutoGenerateEditButton="true"
             runat="server" />

         <asp:SqlDataSource ID="MyDataSource1" runat="server"
            ConnectionString="Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True;"
            ProviderName="System.Data.SqlClient"
            SelectCommand="SELECT ProductId, ProductName, UnitPrice FROM Products"
            UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice WHERE ProductID=@ProductID">
        </asp:SqlDataSource>

         
     </div>
 
</asp:Content>
