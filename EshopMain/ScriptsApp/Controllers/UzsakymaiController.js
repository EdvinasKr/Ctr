EshopApp.controller('UzsakymaiCtrl', function ($scope, $http) {
    $scope.uzsakymai = [];
    $scope.loading = true;

    $scope.getUzsakymai = function () {
        $http.get('/api/UzsakymasApi').success(function (data) {
            $scope.uzsakymai = data;
            $scope.loading = false;
        }).error(function (data) { });
    }

    $scope.suma = function (uzsakymas) {
        var total = 0;
        for (count = 0; count < uzsakymas.Krepselis.length; count++) {
            total += uzsakymas.Krepselis[count].Kaina * uzsakymas.Krepselis[count].Kiekis;
        }
        return total;
    };

    $scope.getUzsakymai();
});