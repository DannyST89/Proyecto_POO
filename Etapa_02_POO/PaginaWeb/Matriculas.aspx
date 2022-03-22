<%@ Page Title="Matrículas" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Matriculas.aspx.cs" Inherits="PaginaWeb.Matriculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
          <div class="row">
            <h3 class="text-center fw-bold text-success">Administrar Datos Matrículas</h3>
        </div>
        <asp:GridView ID="grdMatriculas" class="table-responsive" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" Width="50%" EmptyDataText="No Existen Registros." HorizontalAlign="Center" GridLines="None" Height="200px" ForeColor="#333333" OnPageIndexChanging="grdMatriculas_PageIndexChanging" PageSize="6">
        
                <AlternatingRowStyle BackColor="White" />
        
                <Columns>                   
                    <asp:BoundField DataField="ID_Matricula" HeaderText="ID Matrícula" />
                    <asp:BoundField DataField="ID_Estudiante" HeaderText="ID Estudiante" />
                    <asp:BoundField DataField="Nombre_Est" HeaderText="Nombre" />
                    <asp:BoundField DataField="Primer_Apellido_Est" HeaderText="1° Apellido" />
                    <asp:BoundField DataField="Segundo_Apellido_Est" HeaderText="2° Apellido" />
                    <asp:BoundField DataField="Numero_Telefonico" HeaderText="Teléfono" />
                    <asp:BoundField DataField="Correo_Electronico_Est" HeaderText="Correo" />
                    <asp:BoundField DataField="Direccion_Exacta" HeaderText="Dirección" />
                    <asp:BoundField DataField="Curso_Matriculado" HeaderText="Curso" />
                    <asp:BoundField DataField="Intensidad" HeaderText="Intensidad" />
                    <asp:BoundField DataField="Fecha_Inicio" HeaderText="Fecha Inicio" />
                    <asp:BoundField DataField="Fecha_Final" HeaderText="Fecha Final" />
                    <asp:BoundField DataField="Horas_Clase_Asin" HeaderText="H. Sincrónicas" />
                    <asp:BoundField DataField="Horas_Clase_Sin" HeaderText="H. Asincrónicas" />
                    <asp:BoundField DataField="Total_horas_Clases" HeaderText="Horas Curso" />
                    <asp:BoundField DataField="Horas_Por_Dia" HeaderText="Horas Por Clase" />
                     <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger me-2" CommandArgument='<%# Eval("ID_Matricula").ToString() %>' OnCommand="btnEliminar_Command" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnActualizar" runat="server" CommandArgument='<%# Eval("ID_Matricula").ToString() %>' Text="Modicicar" CssClass="btn btn-outline-success me-2" OnCommand="btnActualizar_Command" />
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
  <asp:Button ID="btnAgregarNueva"  class="btn btn-outline-success" runat="server" Text="Crear Matrícula" OnClick="btnAgregarNueva_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
