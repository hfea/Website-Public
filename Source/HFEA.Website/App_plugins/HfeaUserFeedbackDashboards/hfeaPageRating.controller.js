angular.module("umbraco").controller("HfeaPageRating.Controller",
    function ($scope, $http, notificationsService) {
        $scope.controls = {};
        $scope.controls.popularityFilter = {};        
        $scope.controls.popularityFilter.options = [{
            id: 'true',
            label: 'popularity descending'
        }, {
            id: 'false',
            label: 'popularity ascending'
        }];
        $scope.controls.popularityFilter.value = $scope.controls.popularityFilter.options[0];

        $scope.deletePageRatings = function (nodeId) {
            var path = '/umbraco/backoffice/api/userRatingDashboard/deletePageRatings?pageId=' + nodeId;
            $http.post(path)
            .success(function (data)
            {
                if (data == "true") {
                    $scope.setScopeData($scope.dt.currentPage);
                    var message = "All rating notes for page " + nodeId + " have been deleted";
                    $scope.showMessage(message, 3000);
                    $scope.messageType = "alert-success";
                    return true;
                } else {
                    var message = "You are not allowed to Reset/Remove ratings";
                    $scope.showMessage(message, 3000);
                    $scope.messageType = "alert-warning";
                    return true;
                }
            })
            .error(function () {
                var message = "There was a problem resetting this rating or you are not allowed to Reset/Remove ratings";
                $scope.showMessage(message, 3000);
                $scope.messageType = "alert-error";
                return true;
            })
            ;
        }

        $scope.setScopeData = function (page) {
            var path = '/umbraco/backoffice/api/userRatingDashboard/GetPage?page=' + page + '&sortDesc=' + $scope.controls.popularityFilter.value.id;
            $http.get(path).
            success(function (data, status, headers, config) {
                data.currentPage = 1;
                if (data.PaginationData && data.PaginationData.IsValid)
                {
                    var range = [];
                    for (var i = 1; i <= data.PaginationData.TotalPages; i++) {
                        range.push(i);
                    }

                    data.PaginationData.pageNumbers = range;
                    data.currentPage = data.PaginationData.Page;
                }                
                $scope.dt = data;
            }).
            error(function (data, status, headers, config) {
                //console.log('error');
                //console.log(status);
                //console.log(data);
            });
        };

        $scope.showMessage = function(message, time)
        {
            $scope.displayMessage = message;
            setTimeout(function () { $scope.displayMessage = ''; }, time)
        }

        $scope.setScopeData(1);
    });