(function () {
    'use strict';

    angular
        .module('deviceManager')
        .controller('authController', authController);

    authController.$inject = ['$scope', '$http']; 

    function authController($scope, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'authController';

        $scope.username = "";
        $scope.password = "";
        $scope.error = "";

        $scope.authenticate = function (username, password) {
            $http({
                method: 'GET',
                url: "http://localhost:55954/api/authenticate?userName=" + username + "&password=" + password
            }).then(function successCallback(response) {
                window.location.replace("/devicemanagement/devices");
                // this callback will be called asynchronously
                // when the response is available
            }, function errorCallback(response) {
                if (response.status == 500) {
                    $scope.error = 'Uh oh!  Something really, really bad happened.';
                }
                else if (response.status == 404) {
                    $scope.error = 'Hmmm.  I could not find the uri you specified';
                }
                else if (response.status == 403) {
                    $scope.error = 'Hmmm.  Couldn\'t locate an account with the credentials you specified.';
                } else {
                    $scope.error = 'Uh oh!  I don\'t know what happened.';
                }
            });
        };
    }
})();
