var app = angular.module('wizcation', ['ngSanitize', 'ui.router', 'angular-carousel', 'ui.bootstrap.datetimepicker']);

app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/")
    $stateProvider
        .state('/', {
            url: "/",
            templateUrl: '\Home/Home'
        })
        .state('details', {
            url: '/details',
            templateUrl: '\Home/Details',
            controller: 'DetailController'
        });
});