<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPFinalNivel3_DuarteJurczyszyn.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row d-flex align-items-center">
        <div class="col-3 mx-auto">
            <label for="txtUsuario" class="form-label">Usuario: </label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtUsuario" />
        </div>
    </div>
    <div class="row d-flex align-items-center">
        <div class="col-3 mx-auto">
            <label for="txtContraseña" class="form-label">Contraseña: </label>
            <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="txtContraseña" />
        </div>
    </div>

    <div class="row text-center mt-4">
        <div class="col-1 mx-auto">
            <asp:Button runat="server" Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnIngresar_Click" />
        </div>
    </div>

</asp:Content>
