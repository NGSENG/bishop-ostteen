(function () {
    'use strict';

    angular
        .module('deviceManager')
        .controller('deviceController', deviceController);

    deviceController.$inject = ['$scope', '$http']; 

    function deviceController($scope, $http) {
        $scope.title = 'deviceController';
        $scope.error = '';
        $scope.devices = [];
        $scope.selecteddevice = null;
        $scope.info = '';

        $scope.getAllDevices = function() {
            $http({
                method: 'GET',
                url: "http://localhost:55954/api/devices"
            }).then(function successCallback(response) {
                $scope.devices = response.data;
                $scope.info = "Got devices successful.";
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

        $scope.getDeviceById = function(deviceId) {
            $scope.info = 'You will need to implement this functionality as part of the challenge.';
        }
    }
})();
