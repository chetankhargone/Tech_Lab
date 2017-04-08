/// <reference path="../lib/angular.js" />
var app = angular.module('AppCtrls', ['AppServices','AppFilters']);

app.controller('homeCtrl', ['$scope', 'loginService', 'inputFilter', function ($scope, loginService, $filterInput) {
    $scope.login = function (user) {
        debugger;
        user.username = $filterInput(user.username);
        var data = loginService.userLogin(user);
    }
}]);

app.controller('custCtrl', ['$scope', 'customerService',function ($scope, $custService) {
    //$custService.getCustomers();
}]);
