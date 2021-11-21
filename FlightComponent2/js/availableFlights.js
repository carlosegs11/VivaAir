$(".FlightRows").click(function () {
    var departureStation = $('#departureStation').html();
    var arrivalStation = $('#arrivalStation').html();
    var departureDate = $('#departureDate').html();
    departureDate = departureDate.substring(0, 10);
    departureDate = departureDate.replace('/', '-');
    departureDate = departureDate.replace('/', '-');
    var price = $('#price').html();
    price = parseInt(price);
    console.log(price);
    var flightNumber = $('#flightNumber').html();
    var currency = $('#currency').html();

    console.log(departureStation, arrivalStation, departureDate, price, flightNumber, currency);

    LoadDataDiv("divAvailableFlight", "post", {
        departureStation: departureStation,
        arrivalStation: arrivalStation,
        departureDate: departureDate,
        price: price,
        flightNumber: flightNumber,
        currency: currency
    }, "SaveReservation", "Home");
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