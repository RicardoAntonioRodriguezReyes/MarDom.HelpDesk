RetailApp.controller('ApplicationUserController', ['$scope', 'UserFactory',
        function ($scope, UserFactory) {
            $scope.Titulo = "Preuba de angular";

            $scope.status;
            $scope.usuarios;

        

            $scope.optenerUsuarios = function () {
                var self = this;
                UserFactory.optenerUsusarios()
                    .then(function (response) {
                        self.usuarios = response.data;
                    }, function (error) {
                        $scope.status = 'Error: ' + error.message;
                    });
            }

}]);