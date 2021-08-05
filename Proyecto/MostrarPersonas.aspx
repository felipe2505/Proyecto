<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarPersonas.aspx.cs" Inherits="Proyecto.MostrarPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <div class="row mt-5">
        <asp:GridView ID="grillaAsistentes" 
            CssClass="table table-hover table-borderred" 
            AutoGenerateColumns="false" 
            ShowHeaderWhenEmpty="true" 
            runat="server">
            <columns>
                <asp:BoundField HeaderText="Rut" DataField="rut"/>
                <asp:BoundField HeaderText="Nombre" DataField="nombre"/>
                <asp:BoundField HeaderText="Correo" DataField="correo"/>
                <asp:BoundField HeaderText="Numero de Medidor" DataField="Medidore.numeroMedidor"/>
            </columns>
        </asp:GridView>
    </div>
</asp:Content>
