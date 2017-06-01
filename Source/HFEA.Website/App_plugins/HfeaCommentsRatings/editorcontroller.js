angular.module("umbraco").controller("HFEACommentingAndRating", function ($scope, userService) {
    userService.getCurrentUser().then(function (userObj) {
        $scope.hideOptions = userObj.userType == 'writer' ? true : false;
    });
});
