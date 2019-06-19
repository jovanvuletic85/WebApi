var app = angular.module("BrandApplication", []);

app.controller("BrandsController", function ($scope, $http) {

    var request = $http.get("/api/brand")
    request.then(Success, Error)
    function Success(content) {
        $scope.brandList = content.data;
    }
    function Error(Err) {
        $scope.er1 = Err.StatusText;
    }
});

app.controller("BrandController", function ($scope, $http) {
    $scope.DisplayBrand = function (IdB) {
        var request = $http.get("/api/brand/" + IdB);

        request.then(Success, Error);
        function Success(content) {
            $scope.b1 = content.data;
        }
        function Error(er1) {
            $scope.er2 = er1.StatusText;
        }
    }
});