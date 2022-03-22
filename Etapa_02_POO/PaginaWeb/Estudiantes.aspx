<%@ Page Title="Estudiantes" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.cs" Inherits="PaginaWeb.Estudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       <%-- ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ --%>
   
        <%-- ************************************************************************************************************************************************* --%>

      <div class="row">
            <h3 class="text-center fw-bold text-success">Administrar Datos Estudiantes</h3>
        </div>
     <div class="container">
        <asp:GridView ID="grdEstudiantes" class="table-responsive" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" Width="50%" EmptyDataText="No Existen Registros." HorizontalAlign="Center" GridLines="None" Height="200px" ShowFooter="True" ForeColor="#333333" OnPageIndexChanging="grdEstudiantes_PageIndexChanging">
        
                <AlternatingRowStyle BackColor="White" />
        
                <Columns>                   
                    <asp:BoundField DataField="ID_Estudiante" HeaderText="Estudiante" />
                    <asp:BoundField DataField="Nombre_Est" HeaderText="Nombre Estudiante" />
                    <asp:BoundField DataField="Primer_Apellido_Est" HeaderText="1° Apellido" />
                    <asp:BoundField DataField="Segundo_Apellido_Est" HeaderText="2° Apellido" />
                    <asp:BoundField DataField="Fecha_Nacimiento" HeaderText="Fecha Nacimiento" />                    
                    <asp:BoundField DataField="Numero_Telefonico" HeaderText="Teléfono" />
                    <asp:BoundField DataField="Correo_Electronico_Est" HeaderText="Correo" />
                    <asp:BoundField DataField="Direccion_Exacta" HeaderText="Dirección" />
                    <asp:BoundField DataField="Estado_Est" HeaderText="Estado" />

                   <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger me-2" CommandArgument='<%# Eval("ID_Estudiante").ToString() %>' OnCommand="btnEliminar_Command" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnActualizar" runat="server" CommandArgument='<%# Eval("ID_Estudiante").ToString() %>' Text="Modificar" CssClass="btn btn-outline-success me-2" data-bs-target="#modalEstudiantes" OnCommand="btnActualizar_Command" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
        
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"/>
        
                <EditRowStyle Wrap="True" BackColor="#2461BF" />
        
                <HeaderStyle HorizontalAlign="Center" Font-Bold="True" ForeColor="White" VerticalAlign="Middle" BackColor="#507CD1" Height="10px"/>
        
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
        
        </asp:GridView>
         <div>
             <asp:Button ID="btnAgregarNuevo" runat="server" Text="Agregar Nuevo" CssClass="mt-5 mx-5 btn btn-success" OnClick="btnAgregarNuevo_Click" />
         </div>
         
    </div> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
