<%@ Page Title="Nueva Matrícula" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarNuevaMatricula.aspx.cs" Inherits="PaginaWeb.AgregarNuevaMatricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     
    <br />
    <div class="container small">
            <asp:Button ID="btnBuscarEstudiante" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="btnBuscarEstudiante_Click"  />
            <br />
            <asp:Label ID="lblId" runat="server" Text="Ingrese el ID del estudiante que desea matrícular"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtId" ErrorMessage="El campo &quot;ID Estudiante&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control w-25" placeholder="ID Estudiante"></asp:TextBox>
            
            <asp:Label ID="lblIdMatricula" runat="server" Text="ID Matrícula"></asp:Label>
            <asp:TextBox ID="txtIdMatricula" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
          
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtNombreEstudiante" ErrorMessage="El campo &quot;Nombre&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtNombreEstudiante" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
        
            <asp:Label ID="lblPrimerApellido" runat="server" Text="Primer Apellido"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtPrimerApellido" ErrorMessage="El campo &quot;Primer Apellido&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtPrimerApellido" runat="server"  CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>

            <asp:Label ID="lblSegundoApellido" runat="server" Text="Segundo Apellido"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtSegundoApellido" ErrorMessage="El campo &quot;Segundo Apellido&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtSegundoApellido" runat="server"  CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
            
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtTelefono" ErrorMessage="El campo &quot;Teléfono&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>

              <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electrónico"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtCorreo" ErrorMessage="El campo &quot;Correo Electronico&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
        
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtDireccion" ErrorMessage="El campo &quot;Dirección&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control w-25" ReadOnly="true"></asp:TextBox>
            
            <asp:Label ID="lblCursoMatriculado" runat="server" Text="Curso Matriculado"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddCursoMatriculado" ErrorMessage="El campo &quot;Curso Matriculado&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddCursoMatriculado" runat="server" CssClass="form-control w-25" OnSelectedIndexChanged="ddCursoMatriculado_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Elija un curso</asp:ListItem>
            </asp:DropDownList>
        

            <asp:Label ID="lblIntensidad" runat="server" Text="Intensidad"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddIntensidad" ErrorMessage="El campo &quot;Intensidad&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:DropDownList ID="ddIntensidad" runat="server" CssClass="form-control w-25" OnSelectedIndexChanged="ddIntensidad_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Bajo</asp:ListItem>
                <asp:ListItem>Medio</asp:ListItem>
                <asp:ListItem>Alto</asp:ListItem>
                <asp:ListItem>Intensivo</asp:ListItem>
            </asp:DropDownList>
           
             <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha Inicio"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFechaInicio" ErrorMessage="El campo &quot;Fecha Inicio&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtFechaInicio" runat="server" type="Date" CssClass="form-control w-25" TextMode="Date" OnTextChanged="txtFechaInicio_TextChanged"></asp:TextBox>

            <asp:Label ID="lblFechaFinal" runat="server" Text="Fecha Final"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFechaFinal" ErrorMessage="El campo &quot;Fecha Final&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtFechaFinal" runat="server" type="Date" CssClass="form-control w-25" ></asp:TextBox>

            <asp:Label ID="lblHoraClaseAsin" runat="server" Text="Horas Clase Asincrónica"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtHoraAsin" ErrorMessage="El campo &quot;Horas Clase Asincrónica&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtHoraAsin" runat="server"  CssClass="form-control w-25" AutoPostBack="True" OnTextChanged="txtHoraAsin_TextChanged" ReadOnly="True" ></asp:TextBox>
        
            <asp:Label ID="lblHoraClaseSin" runat="server" Text="Hora Clase Sincrónica"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtHoraSin" ErrorMessage="El campo &quot;Hora Clase Sincrónica&quot; es requerido." ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtHoraSin" runat="server"  CssClass="form-control w-25" AutoPostBack="True" OnTextChanged="txtHoraSin_TextChanged" ReadOnly="True" ></asp:TextBox>
            
            <asp:Label ID="lblTotalHoras" runat="server" Text="Total Horas Clase"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTotalHorasClase" ErrorMessage="El campo &quot;Total horas clase&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtTotalHorasClase" runat="server" CssClass="form-control w-25" OnTextChanged="txtTotalHorasClase_TextChanged" ReadOnly="True" ></asp:TextBox>

            <asp:Label ID="lblHorasXClase" runat="server" Text="Horas Por Clase"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtHorasXClase" ErrorMessage="El campo &quot;Horas por clase&quot; es requerido" ForeColor="Red" ValidationGroup="ValidarFormulario">*</asp:RequiredFieldValidator>
            <asp:TextBox ID="txtHorasXClase" runat="server" CssClass="form-control w-25" OnTextChanged="txtHorasXClase_TextChanged" ReadOnly="True"  ></asp:TextBox>

            <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" ValidationGroup="ValidarFormulario"  />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning" OnClick="btnCancelar_Click"  />


        

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="ValidarFormulario" />


        

    </div>
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
