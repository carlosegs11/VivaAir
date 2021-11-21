$(document).ready(function () {
    var fecha = new Date(Date.now());
    fecha.setDate(fecha.getDate() + 1);
    $(".arrivalDate").datetimepicker({ format: 'YYYY/MM/DD', minDate: fecha });
});

$("#Search").click(function () {
    if ($("#DepartureStationNameSelect").val() === $("#ArrivalStationNameSelect").val()) {

        $("#modal-body1").html("<div class='alert alert-danger'><span class='glyphicon glyphicon-remove' style='font-size:10px'></span>"
            + "<strong> The city of origin and destination cannot be the same </strong></div>");
        $("#MensajeModal").modal({ backdrop: true });
        return;
    }
    else {
        $("#modal-body1").html("");
    }

    /* Para obtener la ciudad de salida */
    var oriCity = document.getElementById("DepartureStationNameSelect");
    var selectedOri = oriCity.options[oriCity.selectedIndex].text;

    /* Para obtener la ciudad de llegada */
    var desCity = document.getElementById("ArrivalStationNameSelect");
    var selectedDes = desCity.options[desCity.selectedIndex].text;

    // CEGS 21/11/2021 - Se incluye un mensaje de "Cargando" al momento de consultar la WebAPI de vuelos disponibles.
    $.blockUI({
        css: {
            border: 'none',
            padding: '15px',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: .5,
            color: '#fff'
        },
        message: '<h1>Cargando...</h1>'
    });
    // CEGS 21/11/2021

    LoadDataDiv("divAvailableFlight", "post", {
        originCode: $("#DepartureStationNameSelect").val(),
        originName: selectedOri,
        destinationCode: $("#ArrivalStationNameSelect").val(),
        destinationName: selectedDes,
        arrivaldate: $("#arrivalDate").val()
    }, "AvailableFlights", "Home");
    // CEGS 21/11/2021 - Se incluye un mensaje de "Cargando" al momento de consultar la WebAPI de vuelos disponibles.
    $.unblockUI();
    // CEGS 21/11/2021
});

function LoadDataDiv(idDiv, metodoGetPost, data, nombreAccion, controlador) {
    var retorno = "ok";
    var url = "/" + controlador + "/" + nombreAccion;
    if (metodoGetPost == "get") {
        $.get(url, data, function (response, status) {
            if (status == "success") {
                var Arreglo = response.split('|');
                if (Arreglo[0].toString() == "error") {
                    retorno = "error";
                    $("#modal-body").html("<div class='alert alert-danger'><h4><span class='glyphicon glyphicon-remove' style='font-size:20px'></span>"
                        + "<strong> Error,</strong></span> " + Arreglo[1].toString() + "</h4></div>");
                    $("#MensajeModal").modal({ backdrop: true });
                } else {
                    idDiv = "#" + idDiv;
                    $(idDiv).html("");
                    $(idDiv).html(response);
                }
            }
            else {
                retorno = "error";
                $("#modal-body").html("<div class='alert alert-danger'><h4><span class='glyphicon glyphicon-remove' style='font-size:20px'></span>"
                    + "<strong> Error,</strong></span> No se recibió respuesta del servidor</h4></div>");
                $("#MensajeModal").modal({ backdrop: true });
            }
        });
    }
    if (metodoGetPost == "post") {
        $.post(url, data, function (response, status) {
            if (status == "success") {
                var Arreglo = response.split('|');
                if (Arreglo[0].toString() == "error") {
                    retorno = "error";
                    $("#modal-body").html("<div class='alert alert-danger'><h4><span class='glyphicon glyphicon-remove' style='font-size:20px'></span>"
                        + "<strong> Error,</strong></span> " + Arreglo[1].toString() + "</h4></div>");
                    $("#MensajeModal").modal({ backdrop: true });

                } else {
                    idDiv = "#" + idDiv;
                    $(idDiv).html("");
                    $(idDiv).html(response);
                }
            }
            else {
                retorno = "error";
                $("#modal-body").html("<div class='alert alert-danger'><h4><span class='glyphicon glyphicon-remove' style='font-size:20px'></span>"
                    + "<strong> Error,</strong></span> No se recibió respuesta del servidor</h4></div>");
                $("#MensajeModal").modal({ backdrop: true });
            }
        });
    }
    return retorno;
}