<%@ Page Title="Administrar Estudiantes" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarNuevoEstudiante.aspx.cs" Inherits="PaginaWeb.AgregarNuevoEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="form-control">
        <h2 class="align-content-center">Administrar Estudiantes</h2>
        <asp:Label ID="lblIdEstudiante" runat="server" Text="ID Estudiante"></asp:Label>
        <asp:TextBox ID="txtIdEstudiante" runat="server" ReadOnly="true" class="form-control w-25"></asp:TextBox>

        <asp:Label ID="lblNombre" runat="server" Text="Nombre" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="El campo &quot;Nombre&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtNombre" runat="server" class="form-control w-25" placeholder="Nombre"></asp:TextBox>

        <asp:Label ID="lblPrimerApellido" runat="server" Text="1° Apellido" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="El campo &quot;1° Apellido&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtPrimerApellido" runat="server" class="form-control w-25" placeholder="Primer Apellido"></asp:TextBox>

        <asp:Label ID="lblSegundoApellido" runat="server" Text="2° Apellido" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSegundoApellido" ErrorMessage="El campo &quot;2° Apellido&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtSegundoApellido" runat="server" class="form-control w-25" placeholder="Segundo Apellido"></asp:TextBox>

        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha Nacimiento" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtFechaNacimiento" ErrorMessage="El campo &quot;Fecha Nacimiento&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtFechaNacimiento" runat="server" class="form-control w-25" type="date"></asp:TextBox>

        <asp:Label ID="lblTelefono" runat="server" Text="Teléfono" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTelefono" ErrorMessage="El campo &quot;Teléfono&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtTelefono" runat="server" class="form-control w-25" placeholder="Teléfono"></asp:TextBox>

        <asp:Label ID="lblCorreo" runat="server" Text="Correo Electrónico" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCorreo" ErrorMessage="El campo &quot;Correo Electrónico&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtCorreo" runat="server" class="form-control w-25" placeholder="ejemplo@gmail.com"></asp:TextBox>

         <asp:Label ID="lblDireccion" runat="server" Text="Dirección" ></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtDireccion" ErrorMessage="El campo &quot;Dirección&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="txtDireccion" runat="server" class="form-control w-25" placeholder="Dirección"></asp:TextBox>
    </div>
    <div class="container align-content-center">
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-success" OnClick="btnGuardar_Click" ValidationGroup="ValidarFormulario"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-warning" OnClick="btnCancelar_Click"/>
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server" >
</asp:Content>
