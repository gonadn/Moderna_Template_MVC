(function () {
    "use strict";

    angular.module('app', ['ngRoute'])


    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/Templates/forside.html'
            })
            .otherwise({
                redirectTo: '/'
            });
    }]);
}());
