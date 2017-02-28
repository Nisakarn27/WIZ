var app = angular.module('wizcation', ['ngSanitize', 'ui.router']);

app.config(function ($stateProvider) {
    $stateProvider
        .state('/', {
            url: '/',
            templateUrl: '\Home/Index'
        })
        .state('home', {
            url: '/home',
            templateUrl: '\Home/Home',
        })
        .state('details', {
            url: '/details',
            templateUrl: '\Home/Details',
        });
});