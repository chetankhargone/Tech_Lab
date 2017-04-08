/// <reference path="lib/angular.js" />
"use strict";
var app = angular.module('AppRoutes', ['ngRoute']);

app.config(['$routeProvider', '$locationProvider',function ($routeProvider,$locationProvider) {

    $locationProvider.html5Mode(true);

    $routeProvider
    .when("/",
    {
        templateUrl: "/Templates/Home/index.html",
        controller: "homeCtrl",
        caseInsensitiveMatch: true
    })
    .when("/customer/",
    {
        templateUrl: "/Templates/Customer/index.html",
        controller: "custCtrl",
        caseInsensitiveMatch: true
    })
    .when("/customer/add",
    {
        templateUrl: "/Templates/Customer/add.html",
        controller: "custCtrl",
        caseInsensitiveMatch: true
    })
    .when("/customers",
    {
        templateUrl: "/Templates/Customer/get.html",
        controller: "custCtrl",
        caseInsensitiveMatch: true
    })
    .otherwise({ redirectTo: '/' });
}])