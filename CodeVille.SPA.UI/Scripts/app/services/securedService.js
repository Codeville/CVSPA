(function () {
    'use strict';

    app.factory('securedService', ['$http', function ($http) {
        var serviceBase = 'http://localhost:38164/';
        var securedServiceFactory = {};

        var _getItems = function () {
            return $http.get(serviceBase + 'api/secureditems').then(function (result) {
                return result;
            });
        };

        return {
            getItems: _getItems
        }
    }]);
})();