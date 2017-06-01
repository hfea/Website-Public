// functions setContentPicker and setImagePicker are used by other plugins, for example 
// by HfeaListingPagesGrid and HfeaPopularPagesGrid. Don't remove

var setContentPicker = function ($scope, $routeParams, dialogService, entityResource) {
    $scope.setContentPicker = function () {
        var config = {
            multiPicker: false,
            entityType: "Document",
            type: "content",
            treeAlias: "content"
        };

        var currentId = $routeParams.id;

        entityResource.getByQuery("$parent/ancestor-or-self::Sprog/WidgetFolder", currentId, "Document").then(function (ent) {
            dialogService.contentPicker({
                section: config.type,
                treeAlias: config.type,
                multiPicker: config.multiPicker,
                startNodeId: ent.id,
                callback: function (data) {
                    $scope.control.value = $scope.control.value || {};
                    $scope.control.value.node = data;
                }
            });
        });
    };
}

var setImagePicker = function ($scope, dialogService) {
    $scope.openMediaPicker = function () {
        dialogService.mediaPicker({
            callback: function (item) {
                $scope.control.value = $scope.control.value || {};
                $scope.control.value.image = item;
            }
        });
    };

    $scope.removePicture = function () {
        $scope.control.value.image = undefined;
    };

    $scope.removeContent = function () {
        $scope.control.value.node = undefined;
    };

    //if ($scope.control.value && $scope.control.value.node) {
    //    entityResource.getById($scope.control.value.node.id, "Media").then(function (item) {
    //        $scope.node = item;
    //    });
    //}
}

angular.module("umbraco").controller("hfea.headerAndTextSpotlight", function ($scope) {
$scope.control.styleItems = [{
	  id: 'orange',
	  label: 'Orange'
}, {
    id: 'blue',
    label: 'Blue'
}, {
    id: 'bg_bright_blue img_blockquote',
	    label: 'Bright Blue'
	}];
if (!$scope.control.styleColor) {
        $scope.control.styleColor = $scope.control.styleItems[0];
    }
});

angular.module("umbraco").controller("hfea.headerAndListingSpotlight", function($scope){
if (!$scope.control.value) {
        $scope.control.value = "<ul><li>add value 1</li><li>add value 2</li></ul>";
    }
});

angular.module("umbraco").controller("hfea.footerBlock", function ($scope) {
    if (!$scope.control.value) {
        $scope.control.value = "<p>First link...</p>";
    }
});

angular.module("umbraco").controller("hfea.fullRowSpotlight", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    $scope.control.value = $scope.control.value || {};
    $scope.control.styleItems = [{
        id: 'bg_rose',
        label: 'Rose'
    }, {
        id: 'bg_orange',
        label: 'Orange'
    }, {
        id: 'bg_+blue',
        label: 'Blue'
    }, {
        id: 'bg_bright_blue img_blockquote',
        label: 'Bright Blue'
    }];
    if (!$scope.control.styleColor) {
        $scope.control.styleColor = $scope.control.styleItems[0];
    }
    setImagePicker($scope, dialogService);
});
angular.module("umbraco").controller("hfea.themedBlockColumn", function ($scope, $rootScope, $timeout, dialogService, $routeParams, entityResource) {
    $scope.control.value = $scope.control.value || {};
    $scope.control.styleItems = [{
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
    if (!$scope.control.styleColor) {
        $scope.control.styleColor = $scope.control.styleItems[0];
    }
    setImagePicker($scope, dialogService);
});
