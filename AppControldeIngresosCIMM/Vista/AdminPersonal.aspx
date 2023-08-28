<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPersonal.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.AdminPersonal" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/1.11.5/css/jquery.dataTables.min.css" />
    <link href="Css/AdminPer.css" rel="stylesheet" />
    <title></title>
</head>
<body>

    <form id="form1" runat="server">

        <div class="container my-2">
            <div class="row flex-shrink-1">
                <table id="DataTableExplicacion" class="table table-striped" style="width: 100%">
                    <thead>
                        <tr>
                            <th>Documento</th>
                            <th>Nombre</th>
                            <th>Apellido</th>
                            <th>Correo</th>
                            <th>Clave</th>
                            <th>Telefono</th>
                            <th>Opciones</th>
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
                        <asp:TextBox ID="txtCorreo" runat="server" placeHolder="Correo" class="form-control mb-3 txt-correo-personal"></asp:TextBox>
                        <asp:TextBox ID="txtClave" runat="server" placeHolder="Clave" class="form-control mb-3 txt-clave-personal"></asp:TextBox>
                        <asp:TextBox ID="txtTelefono" runat="server" placeHolder="Telefono" class="form-control mb-3 txt-telefono-personal"></asp:TextBox>


                    </div>

                    <div class="modal-footer">
                        <%--<asp:Button id="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" />--%>
                        <button id="btnActualizar" class="btn btn-primary" type="button">Actualizar</button>
                    </div>
                </div>
            </div>
        </div>


        <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
        <script src="https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
        <script src="js/sweetalert.min.js"></script>
        <script src="js/Admin.js"></script>
      


</form>
</body>
</html>
