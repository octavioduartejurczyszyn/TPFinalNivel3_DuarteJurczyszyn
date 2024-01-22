<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPFinalNivel3_DuarteJurczyszyn.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Row">
        <div class="Col">

            <asp:GridView ID="dgvArticulos" runat="server" DataKeyNames= "Id"  OnSelectedIndexChanged="dgvArticulos_OnSelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion"/>
                    <asp:BoundField HeaderText="Marca" DataField="Marca"/>
                    <asp:BoundField HeaderText="Categoría" DataField="Categoria"/>
                    <asp:BoundField HeaderText="Precio" DataField="Precio"/>
                    <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" HeaderText="Ver detalle"/>
                </Columns>
            </asp:GridView>

        </div>
    </div>

</asp:Content>
