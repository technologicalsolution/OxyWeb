var Alert = new bootstrap.Alert(document.getElementById('Alert'));

var tableOptions = {
    "autoWidth": false,
    "responsive": true,
    "ordering": true,
    "dom": 'lBfrtip',
    "language": {
        "sProcessing": "Procesando...",
        "sLengthMenu": "Mostrar _MENU_ registros",
        "sZeroRecords": "No se encontraron resultados",
        "sEmptyTable": "Ningun dato disponible en esta tabla",
        "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
        "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
        "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
        "sInfoPostFix": "",
        "sSearch": "Buscar:",
        "sUrl": "",
        "sInfoThousands": ",",
        "sLoadingRecords": "Cargando...",
        "oPaginate": {
            "sFirst": "Primero",
            "sLast": "Ultimo",
            "sNext": "Siguiente",
            "sPrevious": "Anterior"
        },
        "oAria": {
            "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
            "sSortDescending": ": Activar para ordenar la columna de manera descendente"
        },
        "select": {
            "rows": " %d fila seleccionadas"
        }
    }
};

function LoadTable(TableName) {
    $("#" + TableName).DataTable(tableOptions);
}

function CrudTable(Url, typeMethod, Parameters) {    
    var Result;
    $.ajax({
        data: Parameters,
        url: Url,
        type: typeMethod,
        crossDomain: true,
        async: false,
        xhrFields: {
            withCredentials: true
        },
        success: function (result) {
            Result = result;
        },
        error: function (data) {
            $("#Alert").show();
            console.log(data);
        },
    });

    return Result;
}

function lengthText(obj, maxLen, CounTxt) {
    if (obj.value.length > maxLen) {
        obj.value = obj.value.substring(0, 10);
    } else {
        document.getElementById(CounTxt).innerHTML = obj.value.length;
    }
}

function validEmailFormat(Text) {
    var regex = /[\w-\.]{2,}@([\w-]{2,}\.)*([\w-]{2,}\.)[\w-]{2,4}/;
    return regex.test(Text);
}