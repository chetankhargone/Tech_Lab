/// <reference path="../lib/angular.js" />
var app = angular.module('AppServices', []);

app.service('loginService', ['$http', '$location', function ($http, $location) {
    this.userLogin = function (user) {
        $http(
       {
           url: "/api/user/login",
           method: "POST",
           data: user,
           headers: {
               "Content-Type": "application/json"
           }
       })
       .then(function (res) {
           if (res.data.StatusCode == 200) {
               $location.path("/customer");
               return;
           }
           else {
               return null;
           }
       });
    }
}]);

app.service('customerService', ['$http', function ($http) {
    var vm = this;
    this.getCustomers = function () {
        $http(
      {
          url: "/data.json",
          method: "GET",
          data: {},
          dataType: "json",
          headers: {
              "Content-Type": "application/json"
          }
      })
      .then(function (res) {
          if (res.data.status === "success") {
              console.log(res.data);
          }
          else {
              return null;
          }
      });
    }

    this.addCustomer = function () {
    }
}]);