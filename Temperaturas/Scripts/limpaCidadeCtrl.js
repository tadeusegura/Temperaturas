temperaturasApp.controller('limpaCidadeCtrl', ['$scope', 'ChamadaAPI', function ($scope, ChamadaAPI) {


    $scope.erro = false;
    $scope.limpou = false;

    $scope.limpaCidade = function () {

        var nomeCidade = $scope.cidadeSelecionada;

        ChamadaAPI.ChamadaPATCH("Cidade", "limpaHistoricoCidade", JSON.stringify(nomeCidade))
                    .then(function (response) {
                        if (response.isErro == true) {
                            $scope.limpou = false;
                            $scope.erro = true;
                        }
                        else {
                            $scope.limpou = true;
                            $scope.erro = false;
                        }
                    }),
                    function (response) {
                        $scope.erro = true;
                        $scope.limpou = false;
                    }
    }

}]);