RetailApp.controller('RetailController', ['$scope', 'RetailFactory', 'uiGridConstants', 'i18nService', function ($scope, RetailFactory, uiGridConstants, i18nService) {
    $scope.sales = [];
    $scope.salesReportModel = {};
    $scope.retails = [];
    $scope.RetailFileName = '';
    $scope.RetailFileAmount = '';
    $scope.RetailFileCantidad = '';
    $scope.RetailFileTimeUpload = '';
    i18nService.setCurrentLang('es');



    RetailFactory.obtenerRetails()
        .then(function (response) {

            $scope.retails = response.data.Data;
            $scope.RetailFileName = response.data.Data[0].FileName;
            $scope.RetailFileAmount = response.data.Data[0].MontoTotal;
            $scope.RetailFileCantidad = response.data.Data[0].CantidadTotal;
            $scope.RetailFileTimeUpload = response.data.Data[0].FileTimeUpload;
            $scope.gridRetails.data = response.data.Data;
            $scope.gridRetails.paginationPageSizes = calculatePageSizes(response.data.Data);
        });

    $scope.retailValidados = function (data) {
        var retailSeleccionados = data.filter(function (e) {
            return e.selected == true;
        });
        RetailFactory.agregarRetails(JSON.stringify(retailSeleccionados));
    };

    $scope.obtenerDetalleVenta = function (model) {

        RetailFactory.obtenerDetalleVentas(model).then(function (response) {
            $scope.sales = response.data.Data;
        })
    };


    $scope.gridRetails = {
        paginationPageSizes: [25, 50, 75],
        paginationPageSize: 25,
        saveFocus: false,
        saveScroll: true,
        showGridFooter: true,
        showColumnFooter: true,
        enableFiltering: true,
        saveGroupingExpandedStates: true,
        columnDefs: [
          { name: 'Airport', field: 'Airport', width: 300, displayName: 'Aeropuerto' },
          { name: 'Empresa', field: 'Company', width: 200, displayName: 'Empresa' },
          { name: 'Local', field: 'Location', width: 150, displayName: 'Tienda' },
          { name: 'Retails', field: 'Sales_Qty', width: 150, displayName: 'Cantidad', footerCellTemplate: '<div class="ui-grid-cell-contents">Total {{col.getAggregationValue() | number:2  }}</div>', aggregationType: uiGridConstants.aggregationTypes.sum },
          { name: 'Categoria', field: 'Item_Category', width: 300, displayName: 'Categoria' },
          { name: 'Monto', field: 'Amount', width: 130, displayName: 'Monto', cellFilter: 'currency', footerCellTemplate: '<div class="ui-grid-cell-contents">Total {{col.getAggregationValue()| number:2   }}</div>', aggregationType: uiGridConstants.aggregationTypes.sum }
        ],
        enableGridMenu: true,
        enableSelectAll: true,
        onRegisterApi: function (gridApi) {
            $scope.gridRetails.gridApi = gridApi;

        }
    };



    $('#cargarDatos').on('click', function () {
        
        $('#PanelcargaDatos').children('.ibox-content').toggleClass('sk-loading');
    })



    $scope.saveState = function () {
        swal({
            id: "ConfirmarRetails",
            title: "Esta seguro?",
            text: "No podra retroceder!",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#002e5d",
            confirmButtonText: "Si, procesar!",
            closeOnConfirm: true
        }, function (isConfirm) {
            var retailsSeleccionados = $scope.gridRetails.gridApi.selection.getSelectedRows().length;
            if (isConfirm) {
                if (retailsSeleccionados > 0) {
                    $('#PanelcargaDatos').children('.ibox-content').toggleClass('sk-loading');
                    RetailFactory.agregarRetails($scope.gridRetails.gridApi.selection.getSelectedRows())
                    .success(function (response) {
                        console.log(response)
                        swal("Procesado!", 'ss', "success");
                        $scope.retails = response.Data;
                        $scope.gridRetails.data = response.Data;
                    })
                     .error(function (response) {
                         console.log(response)
                         swal("Error!", response.Message, "error");
                     }).finally(function () {
                         $('#PanelcargaDatos').children('.ibox-content').toggleClass('sk-loading');

                     });
                }
                else {
                    swal("Error!", "Debe seleccionar al menos un retail.", "error");
                }
            }
        });

    };

    $scope.cerrarRetail = function () {
        swal({
            id: "CerrarRetails",
            title: "Esta seguro?",
            text: "Si cierra el archivo tendra que calgarlo otra vez!",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#002e5d",
            confirmButtonText: "Si, Cerrar!",
            closeOnConfirm: true
        }, function (isConfirm) {
            if (isConfirm) {
                RetailFactory.cerrarRetails()
                    .success(function (response) {
                        console.log(response)
                        swal("Realizado!", 'Se borraron los datos de memoria', "success");
                        location.reload();
                });


                }
               
            
        });

    };


    //#region Funciones 

    function calculatePageSizes(data) {
        var initials = [];
        return data.reduce(function (pageSizes, row) {
            var initial = String(row.name).charAt(0);
            var index = initials.indexOf(initial);
            if (index < 0) {
                index = initials.length;
                initials.push(initial);
            }
            pageSizes[index] = (pageSizes[index] || 0) + 1;
            return pageSizes;
        }, []);
    }
    function getPage(data, pageNumber) {
        var initials = [];
        return data.reduce(function (pages, row) {
            var initial = row.name.charAt(0);

            if (!pages[initial]) pages[initial] = [];
            pages[initial].push(row);

            if (initials.indexOf(initial) < 0) {
                initials.push(initial);
                initials.sort();
            }

            return pages;

        }, {})[initials[pageNumber - 1]] || [];
    }

    // #endregion

}]);