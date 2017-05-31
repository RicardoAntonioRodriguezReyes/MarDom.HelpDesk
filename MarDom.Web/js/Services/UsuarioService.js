HelpDeskApp.factory('UsuarioFactory', ['$http', function ($http) {

    var ApiUrl = 'http://localhost:16380/Account/';
    var service = {};

    service.OptenerUsuarios = function () {
        return $http.get(ApiUrl + '/OptenerUsuarios');
    };


    return service;

}]);