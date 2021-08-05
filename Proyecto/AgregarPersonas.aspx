<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarPersonas.aspx.cs" Inherits="Proyecto.AgregarPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <div class="row-mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Usuario</h3>
                    <div class="card-body">
                        <div class="form-group">
                            <label for="rutTxt">Rut</label>
                            <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="nombreTxt">Nombre</label>
                            <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="correoTxt">Correo</label>
                            <asp:TextBox ID="correoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="contrasenaTxt">Contraseña</label>
                            <asp:TextBox ID="contrasenaTxt" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <br />
                        <div class="form-group">
                            <label for="medidorDDL">Selecciona el Medidor:</label>
                            <asp:DropDownList ID="medidorDDL" runat="server"></asp:DropDownList>
                        </div>
                        <br />
                        <asp:Button OnClick="ingresarBtn_Click" runat="server" CssClass="btn btn-secondary" ID="ingresarBtn" Text="ingresar" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
