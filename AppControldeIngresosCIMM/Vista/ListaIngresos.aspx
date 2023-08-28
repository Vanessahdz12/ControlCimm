﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Site3.Master" AutoEventWireup="true" CodeBehind="ListaIngresos.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.ListaIngresos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <link href="Css/Style_ListaIngreso.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3">
        <div class="form-group row">
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
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
                    <asp:BoundField DataField="Programa" HeaderText="Programa" />
                    <asp:BoundField DataField="Ficha" HeaderText="Ficha" />
                    <asp:BoundField DataField="Rol" HeaderText="Rol" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
