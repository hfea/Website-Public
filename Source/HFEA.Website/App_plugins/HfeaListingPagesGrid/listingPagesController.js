var setStylesDataSource = function ($scope) {
    $scope.control.value = $scope.control.value || {};
    $scope.control.value.styleItems = [{
        id: 'bg_white',
        label: 'White'
    }, {
        id: 'bg_rose',
        label: 'Rose'
    }, {
        id: 'bg_orange',
        label: 'Orange'
    }, {
        id: 'bg_yellow',
        label: 'Yellow'
    }, {
        id: 'bg_bright_green',
        label: 'Bright green'
    }, {
        id: 'bg_mid_green',
        label: 'Mid green'
    }, {
        id: 'bg_bright_blue',
        label: 'Bright blue'
    }, {
        id: 'bg_teal',
        label: 'Teal'
    }, {
        id: 'bg_taupe',
        label: 'Taupe'
    }, {
        id: 'bg_buff',
        label: 'Buff'
    }, {
        id: 'bg_light_buff',
        label: 'Light buff'
    }, {
        id: 'bg_light_teal',
        label: 'Light teal'
    }, {
        id: 'bg_light_green',
        label: 'Light green'
    }, {
        id: 'bg_light_blue',
        label: 'Light blue'
    }];

    $scope.control.value.headerStyleItems = [{
        id: '',
        label: 'None'
    }, {
        id: 'keyline',
        label: 'Default keyline'
    }, {
        id: 'keyline_rose',
        label: 'Rose keyline'
    }, {
        id: 'keyline_yellow',
        label: 'Yellow keyline'
    }, {
        id: 'keyline_teal',
        label: 'Teal keyline'
    }, {
        id: 'keyline_white',
        label: 'White keyline'
    }];

    $scope.control.value.borderStyleItems = [{
        id: 'no-border',
        label: 'None'
    }, {
        id: 'border',
        label: 'Top and bottom'
    }];

    $scope.control.value.linkStyleItems = [{
        id: '',
        label: 'None'
    }, {
        id: 'thickline',
        label: 'Thick line'
    }, {
        id: 'bg_bright_green',
        label: 'Bright green background'
    }];

    if (!$scope.control.value.styleBgColor) {
        $scope.control.value.styleBgColor = $scope.control.value.styleItems[0];
    }

    if (!$scope.control.value.styleHeader) {
        $scope.control.value.styleHeader = $scope.control.value.headerStyleItems[0];
    }

    if (!$scope.control.value.styleLink) {
        $scope.control.value.styleLink = $scope.control.value.linkStyleItems[0];
    }

    if (!$scope.control.value.styleBorder) {
        $scope.control.value.styleBorder = $scope.control.value.borderStyleItems[0];
    }
}

angular.module("umbraco").controller("hfea.contentSpotlight", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setStylesDataSource($scope);
    setContentPicker($scope, $routeParams, dialogService, entityResource);
}); 

angular.module("umbraco").controller("hfea.contentListing", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setImagePicker($scope, dialogService);
    setContentPicker($scope, $routeParams, dialogService, entityResource);
});

angular.module("umbraco").controller("hfea.textAndImageSpotlight", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setStylesDataSource($scope);
    setImagePicker($scope, dialogService);
    setContentPicker($scope, $routeParams, dialogService, entityResource);    
});

angular.module("umbraco").controller("hfea.headerAndEditorSpotlight", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setStylesDataSource($scope);
});

angular.module("umbraco").controller("hfea.twoColumnRichTextSpotlight", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setStylesDataSource($scope);
});

angular.module("umbraco").controller("hfea.framedHeaderAndTextSpotlight", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    setStylesDataSource($scope);
});