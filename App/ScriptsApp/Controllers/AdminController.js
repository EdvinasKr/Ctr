EshopApp.controller('AdminCtrl', function ($scope, $http) {
    $scope.prekes = [];
    $scope.errorMessage = null;
    $scope.message = null;
    $scope.loading = true;

    $scope.init = function () {
        $http.get('/api/PrekesApi').success(function (data) {
            $scope.prekes = data;
            $scope.loading = false;
        }).error(function (data) { });
    }

    $scope.pridetiNauja = function (preke) {
        $http.post('/api/PrekesApi/', preke)
            .success(function (data) {
                $scope.message = "Sekmingai prideta preke " + preke.Pavadinimas;
                $scope.errorMessage = null;
                $scope.init();
            }).error(function () {
                $scope.errorMessage = "Klaida pridedant preke";
            });
    };

    $scope.pakeistiPreke = function (preke) {
        preke.edit = !preke.edit;
    }

    $scope.uzsaugotiPakeitimus = function (preke) {
        $http.put('/api/PrekesApi/' + preke.PrekesId, preke).success(function (preke) {
            $scope.init();
        }).error(function () {
            $scope.returnMessage = "An Error has occured posting list";
        });
    }

    $scope.atsauktiPakeitimus = function (preke) {
        preke.edit = false;
    }

    $scope.istrintiPreke = function (preke) {
        $http.delete('/api/PrekesApi/' + preke.PrekesId).success(function (preke) {
            $scope.init();
        }).error(function () {
            $scope.returnMessage = "An Error has occured posting list";
        });
    }

    $scope.init();
});