(function () {
    'use strict';

    app.controller('securedController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {
        $scope.logOut = function () {

        };

        $scope.authentication = authService.authentication;
    }]);
})();