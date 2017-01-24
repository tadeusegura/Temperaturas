temperaturasApp.controller('criaCidadeCtrl', ['$scope', 'ChamadaAPI', function ($scope, ChamadaAPI) {
    $scope.erro = false;
    $scope.criou = false;

    $scope.criaCidade = function () {

        var nomeCidade = $scope.cidadeSelecionada;

        var jsonData = { nomeCidade: $scope.cidadeSelecionada }


        ChamadaAPI.ChamadaPOST("Cidade", "salvaCidade", JSON.stringify(nomeCidade))
                    .then(function (response) {
                        if (response === true) {
                            $scope.criou = true;
                            $scope.erro = false;
                        }
                        else {
                            $scope.criou = false;
                            $scope.erro = true;
                        }
                    });
    }
}]);