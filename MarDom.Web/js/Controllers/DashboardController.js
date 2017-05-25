RetailApp.controller('DashboardController', ['$scope', 'RetailFactory', function ($scope, RetailFactory) {
    $scope.salesSumary = [];
    $scope.colors = ['#45b7cd', '#ff6384', '#ff8e72'];
    $scope.labels = ['AZS', 'POP', 'SDQ'];
    $scope.data = [[400000, 11910, 26854],[36366.00, 216453.60, 794244.15]
    ];
    $scope.datasetOverride = [
      {
          label: "Cantidad de ventas",
          borderWidth: 1,
          type: 'bar'
      },
      {
          label: "Monto en ventas",
          borderWidth: 3,
          hoverBackgroundColor: "rgba(255,99,132,0.4)",
          hoverBorderColor: "rgba(255,99,132,1)",
          type: 'line'
      }];
    var Concecionario = {};

   

    function groupBy(array, f) {
        var groups = {};
        array.forEach(function (o) {
            var group = JSON.stringify(f(o));
            groups[group] = groups[group] || [];
            groups[group].push(o);
        });
        return Object.keys(groups).map(function (group) {
            return groups[group];
        })
    }

    $scope.GetSalesSumary = function () {
        RetailFactory.GetSalesByConcessionaireAirport()
        .then(function (response) {

 

            var groupsConcecionario = {};
            var cantidadVentas = [];
            for (var i = 0; i < response.data.Data.length; i++) {
                var groupConcecionario = response.data.Data[i].Concesionario;
              
                if (!groupsConcecionario[groupConcecionario]) {
                    groupsConcecionario[groupConcecionario] = [];
                }
               
                groupsConcecionario[groupConcecionario].push(response.data.Data[i].CodAeropuerto);
          
            }

               
            myArray = [];


            for (var groupConcecionario in groupsConcecionario) {
                myArray.push({ Concesionario: groupConcecionario, CodAeropuerto: groupsConcecionario[groupConcecionario], CantidadVentas: cantidadVentas });
            }



            console.log(myArray)
       
      
         
            //var group_to_values = response.data.Data.reduce(function (obj, item) {
            //    obj[item.group] = obj[item.Concesionario] || [];
            //    obj[item.group].push(item.CodAeropuerto);
            //    return obj;
            //}, {});

            //var groups = Object.keys(group_to_values).map(function (key) {
            //    return { group: key, CodAeropuerto: group_to_values[key] };
            //});

            //console.log(groups)


          
        });

    };

  

}]);