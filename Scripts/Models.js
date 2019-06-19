var app = angular.module("ModelApplication", []);
app.controller("ModelController", function ($scope, $http) {
    $scope.DispayBrand = function () {
        var request = $http.get("/api/brand");

        request.then(Success, Error);
        function Success(content) {
            $scope.brandList = content.data;
        }
        function Error(err) {
            $scope.err1 = err.statusText;
        }
    }

    $scope.DispayModels = function (idB) {
        var request = $http.get("/api/model/" + idB);

        request.then(Success, Error);
        function Success(content) {
            $scope.modelsList = content.data;
        }
        function Error(err) {
            $scope.err1 = err.statusText;
        }
    }
})