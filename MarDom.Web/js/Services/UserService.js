RetailApp.factory('UserFactory', ['$http', function($http) {

    var urlBase = '/ApplicationUsers';
    var dataFactory = {};

    dataFactory.optenerUsusarios = function () {
        //return $http.get(urlBase);
        var q = [{ Nombre: "Ricardo", Nombre: "Euring" }];
        return q;
    };


    return dataFactory;

}]);

