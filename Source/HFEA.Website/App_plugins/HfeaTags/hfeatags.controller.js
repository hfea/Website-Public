angular.module("umbraco")
	.controller("HFEA.TagsController", function ($scope, tagsResource) {
	    tagsResource.getAll().then(function (response) {
	        $scope.tags = response.data;
	        $scope.model.value = $scope.model.value || [];

	        $scope.isChecked = function (tag) {
	            var result = $scope.model.value.indexOf(tag.id) != -1;
	            return result;
	        };

	        $scope.toggleCheck = function (tag) {
	            if ($scope.model.value.indexOf(tag.id) === -1) {
	                $scope.model.value.push(tag.id);
	            } else {
	                $scope.model.value.splice($scope.model.value.indexOf(tag.id), 1);
	            }
	        };

	    });
	});

angular.module("umbraco")
	.controller("HFEA.ProductTagsController", function ($scope, productTagsResource) {
	    productTagsResource.getAllProductTags().then(function (response) {
	        $scope.tags = response.data;
	        $scope.model.value = $scope.model.value || [];

	        $scope.isChecked = function (tag) {
	            var result = $scope.model.value.indexOf(tag.id) != -1;
	            return result;
	        };

	        $scope.toggleCheck = function (tag) {
	            if ($scope.model.value.indexOf(tag.id) === -1) {
	                $scope.model.value.push(tag.id);
	            } else {
	                $scope.model.value.splice($scope.model.value.indexOf(tag.id), 1);
	            }
	        };
	    });
	});