$(document).ready(function(){
    

    //$(".typeahead").tagit({
     //   availableTags: ["c++", "java", "php", "javascript", "ruby", "python", "c"]
    //});
   

    var changeSearchButton = $("#change-search");
    changeSearchButton.hide();
    $("#search-button").click(function(e){
     	e.preventDefault();
     	changeSearchButton.show().click();
        $(".results-section").show();

    })

    /*var url = "/theme/assets/js/terms.json";
    var url = "https://somewebapi.azurewebsites.net/search/centres/list";
    $.getJSON(url, {
    	format: "json"
        }).done( function(data){
            console.log(data);
    	    $('.typeahead').tagsinput({
    	  		typeahead: {
    	    		source: data
    	  		}
    		})
    	}).fail(function(e, x, t ) {
        console.log( "error" + e + " " + t + " " + x );
    });*/
   
	/*$.ajax({
        crossDomain: true,
        type:"GET",
        //contentType: "application/json; charset=utf-8",
        url: "http://somewebapi.azurewebsites.net/search/centres/list", 
        dataType: 'jsonp',
        //jsonpCallback: "myCallback",
        //jsonp: 'callback',
        success: myCallback,
        error: function(x,y,z){
            console.log(x);
            console.log(y);
            console.log(z);
        }
    });*/

   // $('.typeahead').on('itemAdded', function (event) {
     //   console.log(event);
      //  var type = $(".typeahead").val();
       // console.log(type);
	    //setTimeout(function(){
	     //   $(">input[type=text]",".bootstrap-tagsinput").val("");
	    //}, 1);
//	});

});

