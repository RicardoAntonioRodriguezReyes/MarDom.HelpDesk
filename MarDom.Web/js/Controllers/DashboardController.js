HelpDeskApp.controller('DashboardController', ['$scope', 'TicketFactory', function ($scope, TicketFactory) {
    $scope.labels = ["Departamento de Marketing", "Departamento de compras", "Departamento de Recursos Humanos"];
    $scope.data = [33, 35, 33];

    $scope.colors = ['#45b7cd', '#ff6384', '#ff8e72'];
    $scope.series = ['Series A', 'Series B', 'Serie C'];


    $scope.labels2 = ["Departamento de Marketing", "Departamento de compras", "Departamento de Recursos Humanos"];
    $scope.data2 = [
      [65, -59, 80],
      [28, 48, -40]
    ];
    $scope.datasetOverride = [
      {
          label: "Bar chart",
          borderWidth: 1,
          type: 'bar'
      },
      {
          label: "Line chart",
          borderWidth: 3,
          hoverBackgroundColor: "rgba(255,99,132,0.4)",
          hoverBorderColor: "rgba(255,99,132,1)",
          type: 'line'
      }
    ];

}]);