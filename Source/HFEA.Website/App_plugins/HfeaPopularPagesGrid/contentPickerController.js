var setStyleDropDown = function ($scope) {
    $scope.control.value = $scope.control.value || {};
    $scope.control.value.styleItems = [{
        id: 'bg_white',
        label: 'White'
    }, {
        id: 'bg_orange',
        label: 'Orange'
    }, {
        id: 'bg_bright_blue',
        label: 'Blue'
    }, {
        id: 'bg_taupe',
        label: 'Taupe'
    }];

    if (!$scope.control.value.styleBgColor) {
        $scope.control.value.styleBgColor = $scope.control.value.styleItems[0];
    }
}

angular.module("umbraco").controller("hfea.newsItemPicker", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setContentPicker($scope, $routeParams, dialogService, entityResource);
});

angular.module("umbraco").controller("hfea.genericItemPicker", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setContentPicker($scope, $routeParams, dialogService, entityResource);
    setStyleDropDown($scope);    
});

angular.module("umbraco").controller("hfea.genericImageItemPicker", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setContentPicker($scope, $routeParams, dialogService, entityResource);
    setImagePicker($scope, dialogService);
    setStyleDropDown($scope);
});

angular.module("umbraco").controller("hfea.eventItemPicker", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setContentPicker($scope, $routeParams, dialogService, entityResource);
});

angular.module("umbraco").controller("hfea.infoBlock", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setContentPicker($scope, $routeParams, dialogService, entityResource);
});

