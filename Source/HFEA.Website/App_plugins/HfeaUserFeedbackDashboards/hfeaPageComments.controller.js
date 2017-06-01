angular.module("umbraco").controller("HfeaPageComments.Controller",
    function ($scope, userService, $http) {
        // pre-save current user id
        userService.getCurrentUser().then(function (userObj) {
            $scope.currentUserId = userObj.email ? userObj.email : userObj.name;
        });

        $scope.controls = {};
        $scope.controls.approvalFilter = {};
        $scope.controls.approvalFilter.options = [{
            id: '0',
            label: 'all'
        }, {
            id: '1',
            label: 'approved'
        }, {
            id: '2',
            label: 'not approved'
        }];

        $scope.controls.approvalFilter.value = $scope.controls.approvalFilter.options[0];
        $scope.controls.pageFilterValue = null;

        $scope.setScopeData = function (page) {
            var path = '/umbraco/backoffice/api/userCommentsDashboard/GetPage?page=' + page + '&approvalStatus=' + $scope.controls.approvalFilter.value.id + '&pageId=';
            if ($scope.controls.pageFilterValue) {
                path += $scope.controls.pageFilterValue;
            }

            $http.get(path).
            success(function (data, status, headers, config) {
                data.currentPage = 1;


                if (data.PaginationData && data.PaginationData.IsValid) {
                    var range = [];
                    for (var i = 1; i <= data.PaginationData.TotalPages; i++) {
                        range.push(i);
                    }

                    data.PaginationData.pageNumbers = range;
                    data.currentPage = data.PaginationData.Page;

                    //for (var i = 0; i < data.Comments.length; i++) {
                    //    data.Comments[i].Text = decodeEntities(data.Comments[i].Text);
                    //}
                }
                $scope.dt = data;
            }).
            error(function (data, status, headers, config) {
                //console.log('error');
                //console.log(status);
                //console.log(data);
            });
        };
        $scope.updateComment = function (comment) {
            comment.ModifiedBy = $scope.currentUserId;
            var path = '/umbraco/backoffice/api/userCommentsDashboard/updateComment';
            $http.post(path, comment)
            .success(function (data) {
                if (data == "true") {
                    $scope.setScopeData($scope.dt.currentPage);
                    var message = "Comment " + comment.Id + " has been successfully updated";
                    $scope.showMessage(message, 1000);
                    $scope.messageType = "alert-success";
                    return true;
                } else {
                    var message = "You are not allowed to edit comments";
                    $scope.showMessage(message, 3000);
                    $scope.messageType = "alert-warning";
                    return true;
                }
            })
                        .error(function () {
                            var message = "There was a problem updating this comment";
                            $scope.showMessage(message, 3000);
                            $scope.messageType = "alert-error";
                            return true;
                        })
            ;
        }

        $scope.deleteComment = function (commentId) {
            var path = '/umbraco/backoffice/api/userCommentsDashboard/deleteComment?commentId=' + commentId;
            $http.post(path)
            .success(function (data) {
                if (data == "true") {
                    $scope.setScopeData($scope.dt.currentPage);
                    var message = "Comment " + commentId + " has been deleted";
                    $scope.showMessage(message, 3000);
                    $scope.messageType = "alert-success";
                    return true;
                } else {
                    var message = "You are not allowed to delete comments";
                    $scope.showMessage(message, 3000);
                    $scope.messageType = "alert-warning";
                    return true;
                }
            })
                        .error(function () {
                            var message = "There was a problem deleting this comment";
                            $scope.showMessage(message, 3000);
                            $scope.messageType = "alert-error";
                            return true;
                        })
            ;
        }

        $scope.showMessage = function (message, time) {
            $scope.displayMessage = message;
            setTimeout(function () { $scope.displayMessage = ''; }, time)
        }

        $scope.setScopeData(1);

    });

