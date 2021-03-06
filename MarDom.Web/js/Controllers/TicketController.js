﻿HelpDeskApp.controller('TicketController', ['$scope', 'TicketFactory', 'UsuarioFactory', function ($scope, TicketFactory,UsuarioFactory) {
    $scope.usuarios = [];
    $scope.Tickets = [];
    $scope.Secciones = [];
    $scope.NombreUsuario = '';
    $scope.CodigoUsuario = '';
    TicketFactory.ObtenerTickets()
       .then(function (response) {
           console.log(response)
           $scope.Tickets = response.data;

       });

    TicketFactory.ObtenerSeccionesTickets()
       .then(function (response) {
        
           $scope.Secciones = response.data;

       });



    $scope.guardarTicket = function () {
       
        swal({
            id: "ConfirmarGuardarTicket",
            title: "Esta seguro que decea crear una nueva solicitud?",
            text: "No podra retroceder!",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#002e5d",
            confirmButtonText: "Si, crear!",
            closeOnConfirm: true
        }, function (isConfirm) {
           
            if (isConfirm) {

                swal("Solicitud creada correctamente!", '', "success");
                return false;
            }
            else {
                swal("Error!", "Error al crear una nueva solicitud.", "error");
            }
        });
    };
        




      var options = {
        url: "http://localhost:16380/api/Usuario/ObtenerUsuarios",
        getValue: "Nombres",
        list: {
            onSelectItemEvent: function() {
                var NombreUsuario = $("#NombreBuscarUsuario").getSelectedItemData().Nombres;
               

                $("#NombreUsuario").val(NombreUsuario).trigger("change");
            },

            match: {
                enabled: true
            }
        }
};

      $("#NombreBuscarUsuario").easyAutocomplete(options);



    $(document).ready(function () {
        //Dropdownlist Selectedchange event  
        $("#Secciones").change(function () {
         
            $("#Categorias").empty();
           
            $.ajax({
                type: 'GET',
                url: 'http://localhost:16380/api/Ticket/ObtenerCategoriaTickets',
                dataType: 'json',
                data: { seccion: $("#Secciones").val() },
                success: function (Secciones) {
                 
                    $.each(Secciones, function (i, Categoria) {
                        $("#Categorias").append('<option value="'
+ Categoria.Id + '">'
+ Categoria.Descripcion + '</option>');
                    });
                    $("#Categorias").change();
                },
                error: function (ex) {
                    alert('Error cargando data' + ex);
                }
            });
            $("#Problemas").empty();
            return false;
          
        })



        $("#Categorias").change(function () {
            $("#Problemas").empty();
            $.ajax({
                type: 'GET',
                url: 'http://localhost:16380/api/Ticket/ObtenerProblemaTickets',
                dataType: 'json',
                data: { Categoria: $("#Categorias").val() },
                success: function (Categorias) {
                 
                    $.each(Categorias, function (i, Problemas) {
                        $("#Problemas").append('<option value="'
+ Problemas.Id + '">'
+ Problemas.Descripcion + '</option>');
                    });
                },
                error: function (ex) {
                   
                }
            });
            return false;
        })

    });

}]);