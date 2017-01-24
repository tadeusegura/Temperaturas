temperaturasApp.controller('deletaCidadeCtrl', ['$scope', 'ChamadaAPI', function ($scope, ChamadaAPI) {


    $scope.erro = false;
    $scope.deletou = false;

    $scope.deletaCidade = function () {

        var nomeCidade = $scope.cidadeSelecionada;

        ChamadaAPI.ChamadaDELETE("Cidade", "deletaCidade", {nomeCidade : $scope.cidadeSelecionada})
                    .then(function (response) {
                        if (response.isErro == true) {
                            $scope.deletou = false;
                            $scope.erro = true;
                        }
                        else {
                            $scope.deletou = true;
                            $scope.erro = false;
                        }
                    }),
                    function (response) {
                        $scope.erro = true;
                        $scope.deletou = false;
                    }
    }
}]);