<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaProgramas.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.ListaProgramas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <%-- <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />--%>
    <link href="Recursos/DataTables/datatables.css" rel="stylesheet" />
    <link href="../Boostrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styles/sweetalert.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container my-2">
            <div class="row flex-shrink-1">
                <table id="DataTablePrograma" class="table table-striped" style="width: 100%">
                    <thead>
                        <tr>
                            <th>Nombre_Programa</th>
                            <th>Descripcion</th>
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
                        <asp:TextBox ID="txtNombrePrograma" runat="server" placeholder="Documento" class="form-control mb-3 txt-Nombre-Programa"></asp:TextBox>
                        <asp:TextBox ID="txtFicha" runat="server" placeholder="Nombre" class="form-control mb-3 txt-Ficha h-100"></asp:TextBox>
                        <asp:TextBox ID="txtDescripcion" runat="server" placeHolder="Apellido" class="form-control mb-3 txt-Descripcion"></asp:TextBox>
                    </div>

                    <div class="modal-footer">
                        <%--<asp:Button id="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" />--%>
                        <button id="btnActualizar" class="btn btn-primary" type="button">Actualizar</button>
                    </div>
                </div>
            </div>
        </div>
        <script src="Recursos/jQuery-3.6.0/jquery-3.6.0.js"></script>
        <script src="Recursos/DataTables/datatables.js"></script>
        <script src="../Boostrap/js/bootstrap.min.js"></script>
        <script src="../Boostrap/js/bootstrap.bundle.min.js"></script>
        <script src="../Scripts/sweetalert-dev.js"></script>
        <script src="../Scripts/sweetalert.min.js"></script>
        <script src="js/JavaScript_Programas.js"></script>
    </form>
</body>
</html>
