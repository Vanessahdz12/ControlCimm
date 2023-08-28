﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Site1.Master" AutoEventWireup="true" CodeBehind="ListaIngresoVehicular.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.ListaIngresoVehicular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="form1" runat="server">
        <div class="container mt-3">
            <div class="form-group row">
                <label for="ddlRol" class="col-sm-2 col-form-label">Tipo Persona</label>
                <div class="col-sm-4">
                    <asp:DropDownList ID="ddlRol" runat="server" class="form-control"></asp:DropDownList>
                </div>
                <div class="col-sm-2">
                    <asp:Button ID="btnBuscar" runat="server" Text="Button" class="btn btn-primary" OnClick="btnBuscar_Click" />
                </div>
            </div>

            <div class="form-group row">
                <label for="lblPorteria" class="col-sm-2 col-form-label">Porteria</label>
                <div class="col-sm-4">
                    <asp:RadioButton ID="RbPeatonal" runat="server" Text="Peatonal" GroupName="Opcion" />
                    <asp:RadioButton ID="RbVehicular" runat="server" Text="Vehicular" GroupName="Opcion" />
                </div>
                <div class="col-sm-2">
                    <asp:Button ID="btnBuscarPorteria" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscarPorteria_Click" />
                </div>
            </div>

            <div class="mt-3">
                <h3>Listado Control de ingreso, salida de articulos y personal porteria peatonal</h3>
            </div>

            <div class="container mt-3">
                <asp:GridView ID="gvLista" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
                    <Columns>
                        <asp:BoundField DataField="Documento" HeaderText="Documento" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="TipoVehiculo" HeaderText="TipoVehiculo" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" />
                        <asp:BoundField DataField="Placa" HeaderText="Placa" />
                        <asp:BoundField DataField="Fecha_Ingreso" HeaderText="Fecha_Ingreso" />
                        <asp:BoundField DataField="Fecha_Salida" HeaderText="Fecha_Salida" />
                        <asp:BoundField DataField="Tipo_Porteria" HeaderText="Tipo_Porteria" />
                    </Columns>
                </asp:GridView>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>

            <div class="mt-3">
                <asp:Button ID="btnGenerarReporte" runat="server" Text="Generar Reporte" OnClick="btnGenerarReporte_Click" class="btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
