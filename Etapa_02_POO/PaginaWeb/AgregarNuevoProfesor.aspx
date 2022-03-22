<%@ Page Title="Administrar Profesores" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarNuevoProfesor.aspx.cs" Inherits="PaginaWeb.AgregarNuevoProfesor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Administrar Profesores</h1>
     <br />
    <div class="container small">
        
            <asp:Label ID="lblId" runat="server" Text="Id Profesor"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
          
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombreProfesor" ErrorMessage="El campo &quot;Nombre&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtNombreProfesor" runat="server" placeholder="Nombre" CssClass="form-control w-25"></asp:TextBox>
        
            <asp:Label ID="lblPrimerApellido" runat="server" Text="1° Apellido"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="El campo &quot;1° Apellido&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtPrimerApellido" runat="server" placeholder="Primer Apellido" CssClass="form-control w-25"></asp:TextBox>

            <asp:Label ID="lblSegundoApellido" runat="server" Text="2° Apellido"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El campo &quot;2° Apellido&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtSegundoApellido">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtSegundoApellido" runat="server" placeholder="Segundo Apellido" CssClass="form-control w-25"></asp:TextBox>

           <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha Nacimiento"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="El campo &quot;Fecha Nacimiento&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtFechaNacimiento">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtFechaNacimiento" runat="server" type="Date" CssClass="form-control w-25"></asp:TextBox>
            
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="El campo &quot;Teléfono&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtTelefono">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtTelefono" runat="server" placeholder="Teléfono" CssClass="form-control w-25"></asp:TextBox>

              <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electrónico"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="El campo &quot;Correo Electrónico&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtCorreo">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo Electrónico" CssClass="form-control w-25"></asp:TextBox>

            <asp:Label ID="lblCuentaBancaria" runat="server" Text="Cuenta Bancaria"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="El campo &quot;Cuenta Bancaria&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtCuentaBancaria">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtCuentaBancaria" runat="server" placeholder="Número de cuenta" CssClass="form-control w-25"></asp:TextBox>  
        
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="El campo &quot;Dirección&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtDireccion">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtDireccion" runat="server" placeholder="Dirección" CssClass="form-control w-25"></asp:TextBox>       

            <asp:Label ID="lblCursoCertificado" runat="server" Text="Curso Certificado"></asp:Label>
           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ddElegirCursoCertificado" ErrorMessage="El campo &quot;Curso Certificado&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
           
            <asp:DropDownList ID="ddElegirCursoCertificado" runat="server" CssClass="form-control w-25">
            </asp:DropDownList>
           

            <asp:Label ID="lblHoraEntrada" runat="server" Text="Hora de Entrada"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="El campo &quot;Hora de Entrada&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtHoraEntrada">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtHoraEntrada" runat="server" type="time" CssClass="form-control w-25" ></asp:TextBox>

            <asp:Label ID="lblHoraSalida" runat="server" Text="Hora de Salída"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="El campo &quot;Hora de Salída&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario" ControlToValidate="txtHoraSalida">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtHoraSalida" runat="server" type="time" CssClass="form-control  w-25" ></asp:TextBox>

           
            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" ValidationGroup="ValidarFormulario" OnClick="btnGuardar_Click"  />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning" OnClick="btnCancelar_Click"  />

    </div>
   
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
