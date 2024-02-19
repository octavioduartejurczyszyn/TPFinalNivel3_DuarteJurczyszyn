<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdministrador.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="TPFinalNivel3_DuarteJurczyszyn.Administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function confirmarEliminar() {
            return confirm("¿Estás seguro de que deseas eliminar?");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater runat="server" ID="repRepetidor">
            <ItemTemplate>
                <div class="col">
                    <div class="card">
                        <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" style="width: 150px; height: auto;">
                        <div class="card-body">
                            <p class="card-text">Código: <%#Eval("Codigo") %></p>
                            <p class="card-text">Nombre: <%#Eval("Nombre") %></p>
                            <p class="card-text">Descripción: <%#Eval("Descripcion") %></p>
                            <p class="card-text">Marca: <%#Eval("Marca") %></p>
                            <p class="card-text">Categoría: <%#Eval("Categoria") %></p>
                            <p class="card-text">Precio: <%#Eval("Precio") %></p>
                            <asp:Button Text="Modificar" CssClass="btn btn-primary" runat="server" ID="btnModificar" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" OnClick="btnModificar_Click" />
                            <asp:Button Text="Eliminar" CssClass="btn btn-primary" runat="server" ID="btnEliminar" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" OnClientClick="return confirmarEliminar();" OnClick="btnEliminar_Click" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
