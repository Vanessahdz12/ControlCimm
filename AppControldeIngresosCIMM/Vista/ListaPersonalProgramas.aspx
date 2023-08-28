<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Site3.Master" AutoEventWireup="true" CodeBehind="ListaPersonalProgramas.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.ListaPersonalProgramas1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Recursos/DataTables/datatables.css" rel="stylesheet" />
    <link href="../Boostrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styles/sweetalert.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-2">
        <div class="row flex-shrink-1">
            <table id="DataTableExplicacion" class="table table-striped" style="width: 100%">
                <thead>
                    <tr>
                        <th>Documento</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Telefono</th>
                        <th>Programa</th>
                        <th>Ficha</th>
                    </tr>
                </thead>
                <tbody></tbody>
            </table>
        </div>
    </div>

    <div class="modal fade venmodal" id="editarModal" tabindex="-1" role="dialog" aria-labelledby="editarModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="editarModalLabel">Editar Registro</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>

                <div class="modal-body">
                    <asp:TextBox ID="txtDocumento" runat="server" placeholder="Documento" class="form-control mb-3 txt-documento-personal"></asp:TextBox>
                    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control mb-3 txt-nombre-personal h-100"></asp:TextBox>
                    <asp:TextBox ID="txtApellido" runat="server" placeHolder="Apellido" class="form-control mb-3 txt-apellido-personal"></asp:TextBox>
                    <asp:TextBox ID="txtTelefono" runat="server" placeHolder="Ciudad" class="form-control mb-3 txt-telefono-personal"></asp:TextBox>
                    <asp:TextBox ID="txtNombrePrograma" runat="server" placeHolder="Telefono" class="form-control mb-3 txt-nombre-programa"></asp:TextBox>
                    <asp:TextBox ID="txtFicha" runat="server" placeHolder="Telefono" class="form-control mb-3 txt-ficha-programa"></asp:TextBox>
                </div>

                <div class="modal-footer">
                    <%--<asp:Button id="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" />--%>
                    <button id="btnActualizar" class="btn btn-primary" type="button">Actualizar</button>
                </div>
            </div>
        </div>
    </div>

    <script src="../Recursos/jQuery-3.6.0/jquery-3.6.0.js"></script>
    <script src="../Recursos/DataTables/datatables.js"></script>
    <script src="../bootstrap-5.0.2-dist/js/bootstrap.min.js"></script>
    <script src="../bootstrap-5.0.2-dist/js/bootstrap.bundle.min.js"></script>
    <script src="../Scripts/sweetalert-dev.js"></script>
    <script src="../Scripts/sweetalert.min.js"></script>
    <script src="js/JavaScript_PersonalPrograma.js"></script>
</asp:Content>
