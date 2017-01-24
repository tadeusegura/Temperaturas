temperaturasApp.config(['$locationProvider', '$routeProvider', function ($locationProvider, $routeProvider) {

    $routeProvider.when('/', {
        redirectTo: '/home'
    })
    .when('/home', {
        templateUrl: 'Views/Home.html',
        controller: 'HomeCtrl'
    })
    .when('/visualizaCidade', {
        templateUrl: 'Views/visualizaCidade.html',
        controller: 'visualizaCidadeCtrl'
    })
    .when('/criaCidade', {
        templateUrl: 'Views/criaCidade.html',
        controller: 'criaCidadeCtrl'
    })
    .when('/deletaCidade', {
        templateUrl: 'Views/deletaCidade.html',
        controller: 'deletaCidadeCtrl'
    })
    .when('/limpaCidade', {
        templateUrl: 'Views/limpaCidade.html',
        controller: 'limpaCidadeCtrl'
    })
    .when('/topCidade', {
        templateUrl: 'Views/top3.html',
        controller: 'top3Ctrl'
    })
    .otherwise({
        redirectTo: '/home'
    });

    $locationProvider.html5Mode(true);
}]);
