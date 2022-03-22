<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="PaginaWeb.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="row">
            <h3 class="text-center fw-bold text-success">Administrar Datos Cursos</h3>
        </div>


     <div class="container">
        <asp:GridView ID="grdCursos" class="table-responsive" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" Width="50%" EmptyDataText="No Existen Registros." HorizontalAlign="Center" GridLines="None" Height="200px" ForeColor="#333333" OnPageIndexChanging="grdCursos_PageIndexChanging">
        
                <AlternatingRowStyle BackColor="White" />
                <Columns>                   
                    <asp:BoundField DataField="ID_Curso" HeaderText="Curso" />
                    <asp:BoundField DataField="Nombre_Curso" HeaderText="Nombre Curso" />
                    <asp:BoundField DataField="Cantidad_Horas" HeaderText="Cantidad de Horas" />
                    <asp:BoundField DataField="Precio_Hora" HeaderText="Precio Hora" />
                    <asp:BoundField DataField="Estado_Curso" HeaderText="Estado" />

                     <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-outline-danger me-2" CommandArgument='<%# Eval("ID_Curso").ToString() %>' OnCommand="btnEliminar_Command" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnActualizar" runat="server" CommandArgument='<%# Eval("ID_Curso").ToString() %>' Text="Modificar" CssClass="btn btn-outline-success me-2" OnCommand="btnActualizar_Command" />
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
     <asp:Button ID="btnAgregarNuevo"  class="btn btn-success" runat="server" Text="Agregar Nuevo" OnClick="btnAgregarNuevo_Click" />
    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
