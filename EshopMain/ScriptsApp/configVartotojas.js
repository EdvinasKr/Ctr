EshopApp.config(function ($stateProvider, $locationProvider) {

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

    var listas = {
        name: "PrekiuListas",
        url: '/Vartotojas/PrekiuListas',
        templateUrl: '/Vartotojas/PrekiuListas',
        controller: 'KrepselisCtrl'
    };

    var krepselis = {
        name: "Krepselis",
        url: '/Vartotojas/Krepselis',
        templateUrl: '/Vartotojas/Krepselis',
        controller: 'KrepselisCtrl'
    };

    $stateProvider
        .state(listas)
        .state(krepselis)
});

