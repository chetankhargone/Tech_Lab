/// <reference path="../lib/angular.js" />
var app = angular.module('AppFilters', []);

app.filter('input', function () {
    return function (str) {
        var output;

        if (str != "" && str != null && isNaN(str)) {
            output = str.trim().toLowerCase();

            return output;
        }
        else {
            return str;
        }
    }
});