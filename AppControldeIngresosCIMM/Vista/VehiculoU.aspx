<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculoU.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.VehiculoU" %>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculoU.aspx.cs" Inherits="AppControldeIngresosCIMM.Vista.VehiculoU" %>

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
                <table id="tblHistorial" class="table table-striped" style="width: 100%">
                    <thead>
                        <tr>
                            <th>TipoVehiculo</th>
                            <th>Placa</th>
                            <th>Nombre</th>
                            <th>Telefono</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
        </div>


        <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
        <script src="https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
        <script src="Script/sweetalert.min.js"></script>




        <script>
            $(document).ready(function () {
                // Use the previously registered jsonData variable
                var data = jsonData;

                initializeDataTable(data);
            });

            function initializeDataTable(data) {
                var table = $('#tblHistorial').DataTable({
                    data: data,
                    columns: [
                        { data: 'TipoVehiculo' },
                        { data: 'Placa' },
                        { data: 'Nombre' },
                        { data: 'Telefono' }
                    ]
                });
            }
        </script>
        </form>
</body>
</html>
