RetailApp.factory('RetailFactory', ['$http', function ($http) {

    var ApiUrl = 'http://localhost:50446/Retail/';
    var ApiDashboard = 'http://localhost:50446/Dashboards/';
    var service = {};

    service.GetSalesByConcessionaireAirport = function () {
        return $http.get(ApiDashboard + '/GetSalesByConcessionaireAirport');
    };


    service.obtenerRetails = function () {
        return $http.get(ApiUrl + '/getRetails');
    };


    service.agregarRetails = function (data) {
        return $http({
            method: "POST",
            headers: { 'Content-Type': 'application/json' },
            dataType: "json",
            url: ApiUrl + 'AgregarRetail',
            data: data
        });

    };


    service.cerrarRetails = function () {
        return $http({
            method: "POST",
            headers: { 'Content-Type': 'application/json' },
            dataType: "json",
            url: ApiUrl + 'CerrarArchivoCargado'
        
        });

    };


    service.obtenerDetalleVentas = function (busquedaVentaModel) {

        return $http({
            method: "POST",
            headers: { 'Content-Type': 'application/json' },
            dataType: "json",
            url: ApiUrl + 'GetSalesDetails',
            data: busquedaVentaModel
        });
    };



    return service;

}]);

