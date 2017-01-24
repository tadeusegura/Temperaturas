var temperaturasApp = angular.module('temperaturasApp', ['ngMaterial', 'ngAnimate', 'temperaturasServicos', 'ngRoute', 'ngMessages']);

temperaturasApp.controller('TemperaturasCtrl', ['$scope', 'ChamadaAPI', '$location', '$window', function ($scope,ChamadaAPI, $location, $window) {

    redireciona();
    $scope.servicoligado = false;

    function redireciona() {
        $location.path("/");
    }

    $scope.visualizaCidade = function(){
        $location.path('/visualizaCidade');
    }

    $scope.criaCidade = function(){
        $location.path('/criaCidade');
    }

    $scope.deletaCidade = function(){
        $location.path('/deletaCidade');
    }

    $scope.limpaCidade = function(){
        $location.path('/limpaCidade');
    }

    $scope.topCidade = function () {
        $location.path('/topCidade');
    }

    $scope.servicoLigado = false;
    

    $scope.iniciaColetor = function () {

        ChamadaAPI.ChamadaGET("HgBrasil", "comecaColetor")
                    .then(function (response) {
                        $scope.servicoligado = true;
                    }),
                    function (response) {
                        $scope.servicoligado = false;
                    }
    };
}]);