EshopApp.config(function ($stateProvider, $locationProvider) {

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

    var preke = {
        name: "Prekes",
        url: '/Admin',
        templateUrl: '/Admin/Prekes',
        controller: 'AdminCtrl'
    };

    var naujas = {
        name: "PridetiNauja",
        url: '/Admin',
        templateUrl: '/Admin/PridetiNauja',
        controller: 'AdminCtrl'
    };

    var uzsakymas = {
        name: "Uzsakymai",
        url: '/Admin',
        templateUrl: '/Admin/Uzsakymas',
        controller: 'UzsakymaiCtrl'
    };

    $stateProvider
        .state(preke)
        .state(naujas)
        .state(uzsakymas);
});

