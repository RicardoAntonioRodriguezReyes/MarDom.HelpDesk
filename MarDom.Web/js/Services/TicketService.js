HelpDeskApp.factory('TicketFactory', ['$http', function ($http) {

    var ApiUrl = 'http://localhost:16380/api/Ticket/';
    var service = {};

    service.ObtenerTickets = function () {
        return $http.get(ApiUrl + '/ObtenerTickets');
    };

    service.ObtenerSeccionesTickets = function () {
        return $http.get(ApiUrl + '/ObtenerSeccionTickets');
    };


    return service;

}]);

