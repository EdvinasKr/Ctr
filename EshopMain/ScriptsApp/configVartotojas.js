EshopApp.config(function ($stateProvider, $locationProvider) {

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

    var listas = {
        name: "PrekiuListas",
        url: '/',
        templateUrl: '/Vartotojas/PrekiuListas',
    };

    var krepselis = {
        name: "Krepselis",
        url: '/',
        templateUrl: '/Vartotojas/Krepselis',
    };

    $stateProvider
        .state(listas)
        .state(krepselis)
});

