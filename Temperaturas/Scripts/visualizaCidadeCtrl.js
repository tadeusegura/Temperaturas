temperaturasApp.controller('visualizaCidadeCtrl', ['$scope', 'ChamadaAPI', function ($scope, ChamadaAPI) {

    $scope.erro = false;
    carregaCidades();


    function carregaCidades() {

        ChamadaAPI.ChamadaGET("Cidade", "getCidades")
                    .then(function (response) {
                        $scope.cidades = response;
                        $scope.erro = false;
                    }),
                    function (response) {
                        $scope.erro = false;
                    }
    }

}]);