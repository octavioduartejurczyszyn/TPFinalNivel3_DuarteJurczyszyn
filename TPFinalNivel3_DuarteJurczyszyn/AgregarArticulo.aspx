<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdministrador.Master" AutoEventWireup="true" CodeBehind="AgregarArticulo.aspx.cs" Inherits="TPFinalNivel3_DuarteJurczyszyn.AgregarArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mb-3">
        <div>
            <label for="txtCodigo" class="form-label">Código: </label>
            <asp:TextBox runat="server" class="form-control" ID="txtCodigo" />
        </div>
        <div>
            <label for="txtNombre" class="form-label">Nombre: </label>
            <asp:TextBox runat="server" class="form-control" ID="txtNombre" />
        </div>
        <div>
            <label for="txtDescripcion" class="form-label">Descripción: </label>
            <asp:TextBox runat="server" class="form-control" ID="txtDescripcion" />
        </div>
        <div>
            <label for="txtMarca" class="form-label">Marca: </label>
            <asp:TextBox runat="server" class="form-control" ID="txtMarca" />
        </div>
        <div>
            <label for="txtCategoria" class="form-label">Categoría: </label>
            <asp:TextBox runat="server" class="form-control" ID="txtCategoria" />
        </div>
        <div>
            <label for="txtPrecio" class="form-label">Precio: </label>
            <asp:TextBox runat="server" class="form-control" ID="txtPrecio" />
        </div>
    </div>

</asp:Content>
