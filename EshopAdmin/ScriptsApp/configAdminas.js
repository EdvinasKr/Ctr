﻿EshopAdminApp.config(function ($stateProvider, $locationProvider, $urlRouterProvider) {

    $locationProvider.hashPrefix('!').html5Mode(true);

    var preke = {
        name : "Prekes",
        url: '/Admin/Prekes',
        templateUrl: '/Admin/Prekes',
        controller: 'AdminCtrl'
    };

    var naujas = {
        name : "PridetiNauja",
        url: '/Admin/PridetiNauja',
        templateUrl: '/Admin/PridetiNauja',
        controller: 'AdminCtrl'
    };

    var uzsakymas = {
        name : "Uzsakymai",
        url: '/Admin/Uzsakymas',
        templateUrl: '/Admin/Uzsakymas',
        controller: 'UzsakymaiCtrl'
    };

    $stateProvider
        .state(preke)
        .state(naujas)        
        .state(uzsakymas);

    $urlRouterProvider.otherwise('/');
});

