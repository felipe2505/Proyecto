<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="Proyecto.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row-mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Medidor</h3>
                    <div class="card-body">
                        <div class="form-group">
                            <label for="nMedidorTxt">Numero Medidor</label>
                            <asp:TextBox ID="nMedidorTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="fechaTxt">Fecha</label>
                            <asp:TextBox ID="fechaTxt" TextMode="DateTimeLocal" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="valorTxt">Valor Consumo</label>
                            <asp:TextBox ID="valorTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        
                        <asp:Button OnClick="ingresarBtn_Click" runat="server" CssClass="btn btn-secondary" ID="ingresarBtn" Text="ingresar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
