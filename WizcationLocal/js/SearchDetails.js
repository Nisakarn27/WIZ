angular.module('wizcation').controller('SearchDetailsController', ['$scope', function ($scope) {
    $scope.seeDetails = function () {
        parent.location = '#/details'
    }
}])