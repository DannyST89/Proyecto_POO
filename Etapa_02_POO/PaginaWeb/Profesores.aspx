<%@ Page Title="Profesores" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="PaginaWeb.Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
            <h3 class="text-center fw-bold text-success">Administrar Datos Profesores</h3>
        </div>
        <asp:GridView ID="grdProfesores" class="table-responsive" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" Width="50%" EmptyDataText="No Existen Registros." HorizontalAlign="Center" GridLines="None" Height="200px" ForeColor="#333333" OnPageIndexChanging="grdProfesores_PageIndexChanging" PageSize="5">
        
                <AlternatingRowStyle BackColor="White" />
        
                <Columns>                   
                    <asp:BoundField DataField="ID_Profesor" HeaderText="ID Profesor" />
                    <asp:BoundField DataField="Nombre_Profesor" HeaderText="Nombre" />
                    <asp:BoundField DataField="Primer_Apellido_Prof" HeaderText="1° Apellido" />
                    <asp:BoundField DataField="Segundo_Apellido_Prof" HeaderText="2° Apellido" />
                    <asp:BoundField DataField="Fecha_Nacimiento_Prof" HeaderText="Fecha Nacimiento" />                    
                    <asp:BoundField DataField="Numero_Telefonico" HeaderText="Teléfono" />
                    <asp:BoundField DataField="Correo_Electronico_Prof" HeaderText="Correo" />
                    <asp:BoundField DataField="Cuenta_Bancaria" HeaderText="Num. Cuenta" />
                    <asp:BoundField DataField="Direccion_Exacta" HeaderText="Dirección" />                
                    <asp:BoundField DataField="Curso_Certificado" HeaderText="Curso Certificado" />
                    <asp:BoundField DataField="Hora_Entrada" HeaderText="Hora Entrada" />
                    <asp:BoundField DataField="Hora_Salida" HeaderText="Hora Salida" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                       <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger me-2" CommandArgument='<%# Eval("ID_Profesor").ToString() %>' OnCommand="btnEliminar_Command" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnActualizar" runat="server"  Text="Modificar" CssClass="btn btn-outline-success me-2" CommandArgument='<%# Eval("ID_Profesor").ToString() %>' OnCommand="btnActualizar_Command" />
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

        <asp:Button ID="btnAgregarNuevo" runat="server" Text="Agregar Nuevo" CssClass="btn btn-success" OnClick="btnAgregarNuevo_Click" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
