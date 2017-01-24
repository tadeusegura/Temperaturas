var temperaturasServicos = angular.module('temperaturasServicos', []);
temperaturasServicos.service('ChamadaAPI', ['$http', function ($http) {

    var resultado = null;

    this.ChamadaGET = function (nomeController, nomeMetodo, params) {
        var paramsWrapper = {};
        if (params) {
            paramsWrapper.params = params;
        }
        return $http.get('api/' + nomeController + '/' + nomeMetodo, paramsWrapper)
            .then(function (response) {
                resultado = response.data;
                return resultado;
            },
            function (responseErro) {
                responseErro.data.isErro = true;
                return responseErro.data;
            });
    };

    this.ChamadaPOST = function (nomeController, nomeMetodo, params) {
        var paramsWrapper = {};
        if (params) {
            paramsWrapper.params = params;
        }
        return $http.post('api/' + nomeController + '/' + nomeMetodo, params)
            .then(function (response) {
                resultado = response.data;
                return resultado;
            },
            function (responseErro) {
                responseErro.data.isErro = true;
                return responseErro.data;
            });
    };

    this.ChamadaDELETE = function (nomeController, nomeMetodo, params) {
        var paramsWrapper = {};
        if (params) {
            paramsWrapper.params = params;
        }
        return $http.delete('api/' + nomeController + '/' + nomeMetodo, paramsWrapper)
            .then(function (response) {
                resultado = response.data;
                return resultado;
            },
            function (responseErro) {
                responseErro.data.isErro = true;
                return responseErro.data;
            });
    };

    this.ChamadaPATCH = function (nomeController, nomeMetodo, params) {

        return $http.patch('api/' + nomeController + '/' + nomeMetodo,  params )
            .then(function (response) {
                resultado = response.data;
                return resultado;
            },
            function (responseErro) {
                responseErro.data.isErro = true;
                return responseErro.data;
            });
    };

    return resultado;

}]);