angular.module('umbraco.resources').factory('tagsResource',
    function ($q, $http) {
        return {
            getAll: function () {
                return $http.get("/umbraco/api/tagsjson/getall");
            }
        };
    }
);

angular.module('umbraco.resources').factory('productTagsResource',
    function ($q, $http) {
        return {
            getAllProductTags: function () {
                return $http.get("/umbraco/api/tagsjson/getallproducttags");
            }
        };
    }
);