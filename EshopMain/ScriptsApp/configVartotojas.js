EshopApp.config(function ($stateProvider, $locationProvider, $urlRouterProvider) {

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

    $stateProvider
        .state('PrekiuListas', {
            url: '/Vartotojas/PrekiuListas',
            templateUrl: '/Vartotojas/PrekiuListas',
            controller: 'KrepselisCtrl'
        })
       .state('Krepselis', {
           url: '/Vartotojas/Krepselis',
           templateUrl: '/Vartotojas/Krepselis',
           controller: 'KrepselisCtrl'
       });
});

