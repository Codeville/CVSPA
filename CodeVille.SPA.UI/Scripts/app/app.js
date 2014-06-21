/// <reference path="../angular.js" />

var app = angular.module('app',
    ['ngRoute'
        , 'LocalStorageModule',
        'angular-loading-bar'
    ]);

app.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        controller: 'homeController',
        templateUrl: '/scripts/app/views/home.html'
    });

    $routeProvider.when("/login", {
        controller: 'loginController',
        templateUrl: '/scripts/app/views/login.html'
    });

    $routeProvider.when("/signup", {
        controller: 'signupController',
        templateUrl: '/scripts/app/views/signup.html'
    });

    $routeProvider.when("/secured", {
        controller: 'securedController',
        templateUrl: '/scripts/app/views/orders.html'
    });

    $routeProvider.otherwise({ redirectTo: '/home' });
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

app.run(['authService', function (authService) {
    authService.fillAuthData();
}]);