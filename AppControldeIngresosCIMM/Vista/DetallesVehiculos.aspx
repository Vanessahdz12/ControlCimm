<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Site3.Master" AutoEventWireup="true" CodeBehind="DetallesVehiculos.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.DetallesVehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3">
        <%--<div class="form-group row">
    <label for="ddlRol" class="col-sm-2 col-form-label">Tipo Persona</label>
    <div class="col-sm-4">
        <asp:DropDownList ID="ddlRol" runat="server" class="form-control"></asp:DropDownList>
    </div>
    <div class="col-sm-2">
        <asp:Button ID="btnBuscar" runat="server" Text="Button" class="btn btn-primary" OnClick="BtnBuscar_Click" />
    </div>
</div>

<div class="form-group row">
    <label for="txtFicha" class="col-sm-2 col-form-label">Ficha</label>
    <div class="col-sm-4">
        <asp:TextBox ID="txtFicha" runat="server" class="form-control" placeholder="N° Ficha"></asp:TextBox>
    </div>
    <div class="col-sm-2">
        <asp:Button ID="btnBuscarFicha" runat="server" Text="Button" class="btn btn-primary" OnClick="btnBuscarFicha_Click" />
    </div>
</div>

<div class="mt-3">
    <asp:Button ID="btnGenerarReporte" runat="server" Text="Generar Reporte" OnClick="BtnGenerarInforme_Click" class="btn btn-success" />
    <asp:Button ID="btnActualizarTabla" runat="server" Text="ActualizarTabla" OnClick="btnActualizarTabla_Click" class="btn btn-success" />
</div>--%>

        <div class="mt-3">
            <h3>Listado Control de ingreso, salida de articulos y personal porteria peatonal</h3>
        </div>

        <div class="container mt-3">
            <asp:GridView ID="gvLista" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
                <Columns>
                    <asp:BoundField DataField="TipoVehiculo" HeaderText="Tipo Vehiculo" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                    <asp:BoundField DataField="Placa" HeaderText="Placa" />
                    <asp:BoundField DataField="NombreCompleto" HeaderText="Propietario" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
