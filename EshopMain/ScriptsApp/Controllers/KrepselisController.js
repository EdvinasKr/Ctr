EshopApp.controller('KrepselisCtrl', function ($scope, $http) {
    $scope.prekes = [];

    $scope.loadData = function () {
        $http.get('/api/PrekesApi').success(function (data) {
            $scope.prekes = data;
        }).error(function (data) { });
    }

    $scope.items = [];

    //local storage
    $scope.load = function () {
        var todosJSON = localStorage.getItem("prekesStorage");
        if (todosJSON != null) {
            $scope.items = JSON.parse(todosJSON);
        } else {
            return $scope.items = [];
        }
    }

    $scope.add = function (item) {
        var index = $scope.items.indexOf(item);
        if (index > -1) {
            $scope.items[index].KiekPerku += 1;
        } else {
            $scope.items.push(item);
        }
        $scope.addToLocalStorage();
    };

    $scope.delete = function (item) {
        var index = $scope.items.indexOf(item);

        $scope.items[index].KiekPerku -= 1;

        if ($scope.items[index].KiekPerku == 0) {
            $scope.items.splice(index, 1);
        }
        $scope.addToLocalStorage();
    };

    $scope.clearCart = function () {
        $scope.items = [];
        localStorage.clear();
        $scope.loadData();
    }

    $scope.addToLocalStorage = function () {
        localStorage.setItem("prekesStorage", JSON.stringify($scope.items));
    };

    $scope.suma = function () {
        var total = 0;
        for (count = 0; count < $scope.items.length; count++) {
            total += $scope.items[count].Kaina * $scope.items[count].KiekPerku;
        }
        return total;
    };

    $scope.pirkti = function (items) {
        $http.post('api/UzsakymasApi', items).success(function (data) {
            $scope.clearCart();
        }).error(function () {
            $scope.returnMessage = "An Error has occured posting list";
        });
    }

    $scope.loadData();
    $scope.load();
});