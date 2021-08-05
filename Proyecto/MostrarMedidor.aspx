<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidor.aspx.cs" Inherits="Proyecto.MostrarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
      <div class="row mt-5">
       <asp:GridView ID="grillaMedidor" 
                CssClass="table table-hover table-borderred" 
                AutoGenerateColumns="false" 
                ShowHeaderWhenEmpty="true" 
                runat="server">
            <columns>
            <asp:BoundField HeaderText="Numero del 
                Medidor" DataField="numeroMedidor"/>
            <asp:BoundField HeaderText="Fecha del medidor" DataField="fecha"/>
            <asp:BoundField HeaderText="Valor Consumo del Medidor" DataField="valorMedidor"/>                   
            </columns>                    
        </asp:GridView>
          
        </div>
</asp:Content>
