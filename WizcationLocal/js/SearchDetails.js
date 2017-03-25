angular.module('wizcation').controller('SearchDetailsController', ['$scope', function ($scope) {
    $scope.seeDetals = function () {
        parent.location = '#/details'
    }
}])