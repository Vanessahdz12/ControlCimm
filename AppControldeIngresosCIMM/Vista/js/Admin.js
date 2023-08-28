$(document).ready(function () {
    // Fetch data and populate DataTable
    $.ajax({
        type: "POST",
        url: "AdminPersonal.aspx/mtdListar",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var data = response.d;
            initializeDataTable(data);
        },
        error: function (error) {
            console.log(error);
        }
    });
});

// Initialize DataTable with data
function initializeDataTable(data) {
    var table = $('#DataTableExplicacion').DataTable({
        data: data,
        columns: [
            { data: 'Documento' },
            { data: 'Nombre' },
            { data: 'Apellido' },
            { data: 'Correo' },
            { data: 'Clave' },
            { data: 'Telefono' },
            // Edit button
            {
                data: null,
                render: function (data, type, row) {
                    return '<button type="button" class="btn btn-primary btnEditar" data-bs-toggle="modal" data-bs-target="#editarModal" data-id="' + data.idUsuario + '">Editar</button>';
                }
            },
            // Delete button
            {
                data: null,
                render: function (data, type, row) {
                    return '<button type="button" class="btn btn-danger btnBorrar" data-bs-toggle="modal" data-bs-target="#staticBackdrop" data-id="' + data.idUsuario + '">Eliminar</button>';
                }
            }
        ]
    });
}

// Edit button click event
$('#DataTableExplicacion').on('click', '.btnEditar', function () {
    var id = $(this).data('id');
    GuardarIdPersonal(id);
    cargardatos(id);
    $('#editarModal').modal('show');
});

// Delete button click event
$('#DataTableExplicacion').on('click', '.btnBorrar', function () {
    var id = $(this).data('id');
    console.log(id);
    GuardarIdPersonal(id);
});

// Edit button within the modal
$('#editarModal').on('click', '#btnActualizar', function () {
    var idUsuario = $(this).data('id');
    var Documento = $('.txt-documento-personal').val();
    var Nombre = $('.txt-nombre-personal').val();
    // ... (similarly, gather other input values)

    var DatosActualizados = {
        idUsuario: idUsuario,
        Documento: Documento,
        Nombre: Nombre,
        // ... (similarly, include other fields)
    };

    $.ajax({
        url: "AdminPersonal.aspx/mtdActualizarPersonal", // Change to correct URL
        type: "POST",
        data: JSON.stringify({ data: DatosActualizados }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            recargarTabla();
            swal("¡Éxito!", "Los datos se actualizaron correctamente.", "success");
            $('#editarModal').modal('hide');
        },
        error: function (error) {
            console.log(error);
        }
    });
});

// Reload DataTable with updated data
function recargarTabla() {
    $.ajax({
        url: "AdminPersonal.aspx/mtdListar",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var listaPersonal = response.d;
            var table = $('#DataTableExplicacion').DataTable();
            table.clear();
            table.rows.add(listaPersonal);
            table.draw();
        },
        error: function (error) {
            console.log(error);
        }
    });
}

// Delete button within the modal
$('#editarModal').on('click', '#btnEliminar', function () {
    var idUsuario = $(this).data('id');
    swal({
        title: "¿Estás seguro?",
        text: "Esta acción no se puede deshacer",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Sí, eliminar",
        cancelButtonText: "Cancelar"
    }).then(function (isConfirmed) {
        if (isConfirmed.value) {
            var data = {
                idUsuario: idUsuario
            };
            $.ajax({
                url: "AdminPersonal.aspx/mtdEliminar",
                type: "POST",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (Data) {
                    if (Data) {
                        swal("¡Éxito!", "Los datos se eliminaron correctamente.", "success");
                        recargarTabla();
                    }
                },
                error: function (error) {
                    console.log(error);
                }
            });
        }
    });
});




