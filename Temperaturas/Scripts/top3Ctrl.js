temperaturasApp.controller('top3Ctrl', ['$scope', 'ChamadaAPI', function ($scope, ChamadaAPI) {

    $scope.erro = false;
    carregaTop3();


    function carregaTop3() {

        ChamadaAPI.ChamadaGET("Cidade", "getTop3CidadesComMaiorTemperatura")
                    .then(function (response) {
                        $scope.cidades = response;
                        $scope.erro = false;
                    }),
                    function (response) {
                        $scope.erro = false;
                    }
    }

}]);