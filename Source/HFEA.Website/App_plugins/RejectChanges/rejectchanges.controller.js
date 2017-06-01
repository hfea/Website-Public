angular.module('umbraco').controller("Umbraco.Editors.Content.RejectChangesController", RejectChangesController);

function RejectChangesController($scope, $routeParams, userService, $http) {
    var pageId = $scope.currentNode.id;
    var pathGetUsers = '/Umbraco/Api/UmbExtendApi/GetUsers?pageNode=' + pageId;
    $http.get(pathGetUsers).
        success(function (users) {
            $scope.userList = users;
        });

    $scope.checkUserListCount = function () {
        if ($scope.userList.length > 0) {
            return false;
        }
        else {
            return true;
        }
    }

    $scope.sendRejectEmail = function () {
        var message = $scope.commentModel;
        var path = '/Umbraco/Api/UmbExtendApi/SendEmail?comment=' + message + '&pageNodeId=' + pageId + '&receiverId=' + $scope.selectedUser.id;
        $http.post(path)
        .success(function () {
            nav.hideDialog();
        });
    };
}
