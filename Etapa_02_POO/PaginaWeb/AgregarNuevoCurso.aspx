<%@ Page Title="Nuevo Curso" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarNuevoCurso.aspx.cs" Inherits="PaginaWeb.AgregarNuevoCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container small">
        <form  class="form-control ">
            <asp:Label ID="lblId" runat="server" Text="Id Curso"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
            <br />
            <asp:Label ID="txtNombre" runat="server" Text="Nombre del Curso"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombreCurso" ErrorMessage="El campo &quot;Nombre del curso&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtNombreCurso" runat="server" placeholder="Nombre" CssClass="form-control w-25"></asp:TextBox>
            <br />
            <asp:Label ID="lblTotalHoras" runat="server" Text="Total de Horas"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCantidadHoras" ErrorMessage="El campo &quot;Total de Horas&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtCantidadHoras" runat="server" placeholder="Horas" CssClass="form-control w-25"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrecioHora" runat="server" Text="Precio Por Hora"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPrecioHora" ErrorMessage="El campo &quot;Precio Por Hora&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtPrecioHora" runat="server" placeholder="Precio Hora" CssClass="form-control w-25"></asp:TextBox>
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" ValidationGroup="ValidarFormulario" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning" OnClick="btnCancelar_Click" />

        </form>

    </div>
    

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
