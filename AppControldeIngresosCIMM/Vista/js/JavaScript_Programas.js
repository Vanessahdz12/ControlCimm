﻿var idp;
var table;
var listaPrograma;


$(document).ready(function () {
    table = $('#DataTablePrograma').DataTable({
        data: jsonData,
        columns: [
            { data: 'Nombre_Programa' },
            { data: 'Ficha' },
            { data: 'Descripcion' },
            {
                "data": null,
                "defaultContent": "<div class='text-center'><div class='btn-group'><button class='btn btn-primary btn-sm btnEditar'><i class='material-icons'>edit</i></button><button class='btn btn-danger btn-sm btnBorrar'><i class='material-icons'>delete</i></button></div></div>",
            }
        ]
    })
})

$('#DataTablePrograma').on('click', '.btnEditar', function (e) {

    e.preventDefault();
    var rowData = $('#DataTablePrograma').DataTable().row($(this).closest('tr')).data();
    idp = rowData.idPrograma
    $.ajax({
        url: "ListaProgramas.aspx/mtdCargarDatos",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify({ idPrograma: idp }),

        success: function (Data) {

            var datosPrograma = Data.d;
            $('.txt-Nombre-Programa').val(datosPrograma[0]["Nombre_Programa"]);
            $('.txt-Ficha').val(datosPrograma[0]["Ficha"]);
            $('.txt-Descripcion').val(datosPrograma[0]["Descripcion"]);

            $('#editarModal').modal('show');
        },
        error: function (error) {
            console.log(error);
        }
    });
})

$('#btnActualizar').on('click', function (e) {
    e.preventDefault();

    var idPrograma = idp;
    var nombre = $('.txt-Nombre-Programa').val();
    var ficha = $('.txt-Ficha').val();
    var descripcion = $('.txt-Descripcion').val();

    var DatosActualizados = {
        idPrograma: idPrograma,
        Nombre_Programa: nombre,
        Ficha: ficha,
        Descripcion: descripcion
    };

    $.ajax({
        url: "ListaProgramas.aspx/mtdActualizarPrograma",
        type: "POST",
        data: JSON.stringify({ data: DatosActualizados }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (response) {
            recargarTabla();
            swal("¡Éxito!", "Los datos se actualizaron correctamente.", "success");
            $('#editarModal').modal('hide'); // Cierra la ventana modal
        },
        error: function (error) {
            console.log(error);
        }
    });
});

function recargarTabla() {
    $.ajax({
        url: "ListaProgramas.aspx/mtdListar",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",

        success: function (response) {
            listaPrograma = response.d;
            table.clear();
            table.rows.add(listaPrograma);
            table.draw();

            console.log(listaPrograma);
        },
        error: function (error) {
            console.log(error);
        }
    });
}

$('#DataTablePrograma').on('click', '.btnBorrar', function (e) {
    e.preventDefault();

    var rowData = $('#DataTablePrograma').DataTable().row($(this).closest('tr')).data();
    var idp = rowData.idPrograma;
    swal({
        title: "¿Estás seguro?",
        text: "Esta acción no se puede deshacer",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Sí, eliminar",
        cancelButtonText: "Cancelar"
    }, function (isConfirmed) {
        if (isConfirmed) {
            var data = {
                formData: {
                    idPrograma: idp
                }
            };
            // Realiza la petición Ajax para eliminar el registro
            $.ajax({
                url: "ListaProgramas.aspx/mtdEliminar",
                type: "POST",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (Data) {
                    if (Data) {

                        swal("¡Éxito!", "Los datos se eliminaron correctamente.", "success");
                    }
                    recargarTabla()
                },
                error: function (error) {
                    console.log(error);
                }
            });

        }
    });
});


