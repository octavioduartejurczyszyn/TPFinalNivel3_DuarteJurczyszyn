<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarArticulo.aspx.cs" Inherits="TPFinalNivel3_DuarteJurczyszyn.ModificarArticulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Administrador</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Tato's shop</a>
            <a class="navbar-brand" href="#">Modificar Artículo</a>
            <a class="navbar-brand" href="Login.aspx">Salir</a>

            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container">
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
                    <label for="ddlMarca" class="form-label">Marca: </label>
                    <asp:DropDownList ID="ddlMarca" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
                <div>
                    <label for="ddlCategoria" class="form-label">Categoría: </label>
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-select"></asp:DropDownList>
                </div>
                <div>
                    <label for="txtPrecio" class="form-label">Precio: </label>
                    <asp:TextBox runat="server" class="form-control" ID="txtPrecio" />
                </div>
                <div>
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="btnModificar_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
