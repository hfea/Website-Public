var PAGE;
//window.IS_PROTOTYPE || (window.IS_PROTOTYPE =false)
//jQuery.noConflict();
(function ($) {
    "use strict";
    PAGE = (function () {
        function sharethis() {
            var shareicons = $(".sharethis_wrapper span").length;
            $(".sharethis_wrapper").height((shareicons * 32) + 32).hide();
            $("#share_this").hover(function () {
                $(".sharethis_wrapper").show();
            }, function () {
                $(".sharethis_wrapper").hide();
            });
        }

        function cookieMessage(){
            var cookieAccepted = Cookies.get('cookieAccepted');

            if (!cookieAccepted) {
                $('.cookie').removeClass('hidden');
            }
            else {
                $('.cookie').addClass('hidden');
            }

            $('.cookie a').click(function (e) {
                Cookies.set('cookieAccepted', true);
                $('.cookie').addClass('hidden');

                if ($(this).hasClass('cookie-close')) {
                    e.preventDefault();
                }
            });
        }

        function homepageLoadmore(){
            $('.homepage-grid .col').each(function(i){
                var totalArticles = $(this).children("article").length;
                console.log(totalArticles);
                $(this).children("article").each(function(i){
                    if ($(this).index() > 2){
                        console.log("hide "+ i);
                        $(this).hide();
                    }
                })
            })
            $('.homepage-grid button').click(function(){
                $('.homepage-grid article').fadeIn();
                $(this).fadeOut();
            })
        }

        function starRatingForm(){
            var pageId = $("#pageId").val(),
                sessionId = $("#sessionId").val(),
                tempId = $("#tempId").val(), url = "/umbraco/api/submitpagerating/do?pageid=" + pageId + "&sessionid=" + sessionId + "&tempid="+ tempId;
            // get star rating on page load
            var currentRating = 0;
            $(".star-rating-form .star").each(function (e) {
                if ($(this).find(".fill").hasClass("fill-full")) {
                    currentRating++;
                }
                var stars = "stars";
                if (currentRating < 2) {
                    stars = "star";
                }
                var text = currentRating + " " + stars + " out of 5";
                $(".star_rating_tally").text(text);
                $(".star_label").each(function (e) {
                    $(this).hide();
                    var i = $(this).index();
                    if (i == (currentRating - 1 )) {
                        $(this).show();
                    }
                })
            })
            $(".star-rating-form .star").on("mouseenter", function(){
                $(".fill").removeClass("fill-full");
                var i = $(this).index();
                $(".star-rating-form .star").each(function(e){
                    if ( $(this).index() <= i ){
                        $(this).find(".fill").addClass("fill-full");
                    }
                })
                $(".star_label").each(function (e) {
                    $(this).hide();
                    var j = $(this).index();
                    if (j == i) {
                        $(this).show();
                    }
                })
            }).on("mouseleave", function () {
                $(".fill").removeClass("fill-full");
                if (currentRating > 0) {
                    $(".star-rating-form .star").each(function (e) {
                        if ($(this).index() < currentRating) {
                            $(this).find(".fill").addClass("fill-full");
                        }
                    })
                    $(".star_label").each(function (e) {
                        $(this).hide();
                        var j = $(this).index();
                        if (j == (currentRating - 1)) {
                            $(this).show();
                        }
                    })
                }
            }).on("click", function () {
                var i = $(this).index(), index = i + 1;
                url = url + "&rating=" + index;

                $.ajax({
                    url: url,
                    success: function(data){
                        console.log(data);
                        if (data) {
                            $(".star-rating-form .star").each(function (e) {

                                if ($(this).index() <= i) {
                                    $(this).find(".fill").addClass("fill-full");
                                }
                            })
                            var stars = "stars";
                            if (index  < 2) {
                                stars = "star";
                            }
                            currentRating = index;
                            var text = index + " " + stars + " out of 5";
                            $(".star_rating_tally").text(text);
                            $(".review_tally").text("Thank you for your rating")
                            $(".star_label").each(function (e) {
                                $(this).hide();
                                var j = $(this).index();
                                if (j ==( currentRating - 1 ) ) {
                                    $(this).show();
                                }
                            })
                        }
                    },
                    error: function(e, i){
                        console.log( e + i);
                    }
                })
            })
            $(".show-more-replies-button a").click(function (e) {
                e.preventDefault();
                var parent = $(this).closest(".reply-listing");
                parent.find("li").removeClass("hidden");
                $(this).parent("li").hide();
            })
        }

        function lineChart() {

            function toNumber(array) {
                for (var i = array.length - 1; i >= 0; i--) {
                    array[i] = parseFloat(array[i]);
                };
            }

            $(".line-chart").each(function (i) {
                var chartID = $(this).attr("id");
                var chart = $(this),
                    p = chart.data('pregnancy'),
                    pregnancy = p.split(','),
                    m = chart.data('multiple'),
                    multiple = m.split(','), multipleA = [], pregnancyA = [];
                toNumber(multiple);
                toNumber(pregnancy);
                var ctx = document.getElementById(chartID).getContext("2d");

                var options = {
                    bezierCurve: false,
                    dataSetFill: false,
                    responsive: true
                }
                var data = {
                    labels: ["Jan 2015", "Apr", "Jul", "Oct", "Jan 2016", "Apr", "Jul"],
                    scaleLineColor: 'rgba(0,0,0,1)',
                    showTooltips: false,
                    datasets: [
                        {
                            label: "My First dataset",
                            fillColor: "rgba(255,255,255,0)",
                            dataSetFill:false,
                            strokeColor: "#008E90",
                            datasetStrokeWidth: 5,
                            pointColor: "rgba(255,225,225,1)",
                            pointDot: true,
                            pointStrokeColor: "#008E90",
                            pointHighlightFill: "#008E90",
                            pointHighlightStroke: "rgba(255,255,255,1)",
                            data: pregnancy
                        },
                        {
                            label: "My First dataset",
                            fillColor: "rgba(255,255,255,0)",
                            dataSetFill: false,
                            strokeColor: "#f5911e",
                            pointColor: "rgba(255,255,255,1)",
                            pointStrokeColor: "#f5911e",
                            pointHighlightFill: "#f5911e",
                            pointHighlightStroke: "rgba(255,255,255,1)",
                            data: multiple
                        }
                    ]
                }
                var myNewChart = new Chart(ctx).Line(data, options);
            });
        }
        function donutChart() {
            $('.donutChart').each(function (i) {
                var chart = $(this).attr('id'), pc = $(this).data('percentage');
                var ctx = document.getElementById(chart).getContext("2d"),
                    options = {
                        animationEasing: 'easeInCirc',
                        animationSteps: 30,
                        percentageInnerCutout: 70,
                        showTooltips: false,
                        segmentShowStroke: false,

                    };
                var data = [
                        {
                            value: pc,
                            color: "#80C242",
                        },
                        {
                            value: 100 - pc,
                            color: "transparent",
                        }
                ]
                // And for a doughnut chart
                var myDoughnutChart = new Chart(ctx).Doughnut(data, options);
            })
        }
        function pieChart() {

            $('.pieChart').each(function (i) {

                var colors = ["#C8DA2A", "#008E90", "#bcb4ab", "#E8E3DB", '#f5911e', '#F7AAA5'];
                var overViewChartData = [];
                $(this).parent().find('.pieChart-data .circle-chart-data').each(function (index) {
                    var data = { value: $(this).attr('data-value'), color: colors[$(this).attr('data-index')] };
                    overViewChartData.push(data);
                });

                var chart = $(this).attr('id');
                var ctx = document.getElementById(chart).getContext("2d"),
                    options = {
                        responsive: true,
                        animationEasing: 'easeInCirc',
                        animationSteps: 30,
                        percentageInnerCutout: 70,
                        showTooltips: false,
                        segmentShowStroke: false,

                    };
                var data = overViewChartData;
                // And for a doughnut chart
                var myDoughnutChart = new Chart(ctx).Doughnut(data, options);
            })
        }
        function rangeChart() {
            $(".rangeChart").each(function () {
                // for each chart
                var chart = $(this).closest(".dynamic-range-charts");
                var label = chart.find("label").first(),
                input = label.children("input");
                input.addClass('checked');
                // get the first set of results (data attributes on the radio button)
                setChart(label, input);
                input.click();
            });

            function setChart(dataSrc, input) {
                var parent = dataSrc.closest(".dynamic-range-charts"),
                chart = parent.find(".rangeChart"),
                range_e = chart.children(".range"),
                nat_ave_e = chart.children(".nat-ave"),
                mean_e = chart.children(".mean"),
                mean_text = mean_e.children("span"),
                nat_ave_text = nat_ave_e.children("span"),
                stats_caveat_e = parent.find(".stats-caveat"),
                consistent_e = parent.find(".consistent_text"),
                count_e = parent.find(".stat-counter"),
                statsnamelabel_e = parent.find(".stat-name"),
                statstypelabel_e = parent.find(".stat-type");


                var minRange = dataSrc.data("min-range"),
                maxRange = dataSrc.data("max-range"),
                mean = dataSrc.data("mean"),
                nat_ave = dataSrc.data("nat-ave"),
                width = maxRange - minRange,
                consistent = dataSrc.data("compare"),
                count = dataSrc.data("count"),
                stats_caveat = input.data("caveat"),
                statsnamelabel = input.data("name"),
                statstypelabel = input.data("statstypelabel");

                range_e.css({ "left": minRange + "%", "width": width + "%" });
                nat_ave_e.css({ "left": nat_ave + "%" });
                mean_e.css({ "left": mean + "%" });

                mean_text.text(mean + "%");
                nat_ave_text.text(nat_ave + "%");

                stats_caveat_e.text(stats_caveat);
                consistent_e.text(consistent);
                count_e.text(count);
                statsnamelabel_e.text(statsnamelabel);
                statstypelabel_e.text(statstypelabel);

                if (consistent == "Above") {
                    consistent_e.parent(".consistent").removeClass("below-average").removeClass("consistent-with").addClass("above-average");
                } else if (consistent == "Below") {
                    consistent_e.parent(".consistent").removeClass("above-average").removeClass("consistent-with").addClass("below-average");
                } else if (consistent == "Consistent with") {
                    consistent_e.parent(".consistent").removeClass("above-average").removeClass("below-average").addClass("consistent-with");
                }

                if (statsnamelabel == "multiple") {
                  consistent_e.parent(".consistent").addClass("reverse-icon");
                } else {
                  consistent_e.parent(".consistent").removeClass("reverse-icon");
                }

                // if mean is lower than nat ave then add lass to align text to left of mean marker
                if (mean <= nat_ave) {
                    mean_e.addClass("left");
                } else {
                    mean_e.removeClass("left");
                }
            }

             $('.chart-set label').click(function (e) {
                var a = $(this), input = a.find("input");
                setChart(a, input);
            });
             $(".statistics-chart-control .reveal-link").click(function () {
                var control = $(this).closest(".panel");
                var active = control.find(".panel-collapse");

                var input = active.find("input:checked");
                var label = input.parent("label");

                var period = $(this).attr("data-period");
                $(".dateperiod").html(period);

                setChart(label, input);
            });
        }
        function clinicMap() {
            var mapInit = true;
            $('.clinic-details-toggle').click(function () {
                if (mapInit) {
                    var myMap = $('#clinic-map');
                    var image = "/theme/assets/images/design/map-marker-teal.png";
                    var myLat = myMap.data('lat'),
                        myLng = myMap.data('lng'),
                        myLatLng = { lat: myLat, lng: myLng };
                    var myMap = new google.maps.Map(document.getElementById('clinic-map'), {
                        center: myLatLng,
                        zoom: 15
                    });
                    var marker = new google.maps.Marker({
                        position: myLatLng,
                        map: myMap,
                        icon: image
                    });
                    mapInit = false;
                }
            })
        }
        function listingMap() {
            var mapInit = false;
            // initialise the tabs for map / list

            $(".nav.switch-view a").click(function (e) {
                e.preventDefault();
                var id = $(this).attr("href");
                $(".tab-content .tab-pane").removeClass('active');
                $(".nav.switch-view a").parent().removeClass('active');
                $(this).parent().addClass('active');
                $(id).addClass('active');

                if (id == '#map-pane') {

                    // set up map

                    var infos = [];

                    var addInfoWindow = function (i, marker) {
                        marker.addListener('click', function () {
                            closeAllInfoWindows();
                            i.open(myMap, marker);
                        });
                    }

                    var closeAllInfoWindows = function () {
                        for (var i = 0; i < infos.length; i++) {
                            infos[i].close();
                        }
                    }

                    if (!mapInit) {

                        var bounds = new google.maps.LatLngBounds();
                        var image = "/theme/assets/images/design/map-marker-teal.png",
                            //greenImage = "/theme/assets/images/design/map-marker-green.png",
                            myMap = new google.maps.Map(document.getElementById('map'), {
                                zoom: 8
                            });


                        //// Set the source using green pin
                        //var srcLat = $("#map").data("source-lat"), srcLng = $("#map").data("source-lng");
                        //var srcLatLng = { lat: parseFloat(srcLat), lng: parseFloat(srcLng) };
                        //var marker = new google.maps.Marker({
                        //    position: srcLatLng,
                        //    map: myMap,
                        //    icon: greenImage
                        //});
                        //var p = marker.getPosition()
                        //bounds.extend(p);
                        for (var i = 0; i < mapDataList.length; i++) {
                            var clinic = mapDataList[i];

                            var myLatLng = { lat: parseFloat(clinic.Lat), lng: parseFloat(clinic.Long) };
                            var marker = new google.maps.Marker({
                                position: myLatLng,
                                map: myMap,
                                title: clinic.PinTitle,
                                icon: image
                            });

                            var p = marker.getPosition()
                            bounds.extend(p);

                            var fullText = "<h4>" + clinic.PinTitle + "</h4>";
                            fullText += !clinic.PinText ? "" : "<p class='pintext'>" + clinic.PinText + "</p>";
                            fullText += !clinic.ProfileUrl ? "" : "<a target='_blank' href='" + clinic.ProfileUrl + "'>View clinic</a>";
                            if (clinic.LinkList && clinic.LinkList.length > 0) {
                                fullText += "<ul>";
                                for (var j = 0; j < clinic.LinkList.length; j++) {
                                    fullText += "<li><span>" + clinic.LinkList[j].Type + " clinic for </span><a target='_blank' href='" + clinic.LinkList[j].Url + "'>" + clinic.LinkList[j].ClinicName + "</a><br /></li>"
                                }

                                fullText += "</ul>";
                            }

                            var infowindow = new google.maps.InfoWindow({
                                content: fullText
                            });
                            addInfoWindow(infowindow, marker);
                            infos.push(infowindow);
                        }

                        myMap.fitBounds(bounds);

                        // add listener to close map markers on clicking on the map

                        google.maps.event.addListener(myMap, "click", function (event) {
                            for (var i = 0; i < infos.length; i++) {  //I assume you have your infoboxes in some array
                                infos[i].close();
                            }
                        });


                        mapInit = true;
                    }
                }
            })
        }
        function timeline() {

        }

        function navigation() {

            $(".collapsed .toggle-menu").hide();
            $(".nav-toggle").each(function () {
                if ($(this).siblings("ul").length > 0 && (!$(this).parent().hasClass("hide-children"))) {
                    //console.log($(this).text());
                    // if this parent doesn't have a class collapsed then add toggle, other wise ignore as collapsed class means children are hidden
                    $(this).after("<a href='#' class='nav-toggle-button'><span class='glyphicon glyphicon-chevron-down'></span><span class='sr-only'>Toggle</span></a>");
                }
            })
            $(".nav-toggle-button").click(function (e) {
                e.preventDefault();
                $(this).toggleClass("open").siblings("ul").slideToggle();
                if ($(this).hasClass("open")) {
                    $(this).children(".glyphicon").removeClass("glyphicon-chevron-down").addClass("glyphicon-chevron-up");
                } else {
                    $(this).children(".glyphicon").removeClass("glyphicon-chevron-up").addClass("glyphicon-chevron-down");
                }
            })
        }

        function clinicSearch() {
            // If postcode field has been filled in then reveal the postcode distance section
            var pcd = $("#postcode-distance"),
                pc = $("#postcode"),
                pcdi = $("#postcode-distance-input");

            if (pc.val() == "") {
              //  pcd.hide();
            }
            //pcdi.hide();
            //pcdi.after('<input id="postcode-dummy" value="1"/>');
           // var dummy = $("#postcode-dummy");
            //dummy.hide();
            pc.keyup(function () {
                var pc = $(this),
                    pcval = pc.val(),
                    focussed = pc.is(":focus");

                // if postcode input isn't empty then reveal postcode distance
                if (pcval !== "") {
                    pcd.show();
                } else {
                    pcd.hide();
                }
            });



            // Initialise the tooltip for filter items

            $(document).tooltip();
            if ($('.clinic-name-search').length) {
                $.get("/umbraco/api/clinicsearch/autocomplete", function (clinicDataList) {
                    // Initialise the clinic name search auto complete
                    var objects = [];
                    var map = {};
                    $('.typeahead').typeahead({
                        source: function (query, process) {
                            objects = [];
                            map = {};
                            $.each(clinicDataList, function (i, object) {
                                map[object.val] = object;
                                objects.push(object.val);
                            });
                            process(objects);
                        },
                        updater: function (item) {
                            //$(".typeahead").val(map[item].id);
                            $(".loading").show();
                            $(".typeahead").val("");
                            window.location.href = map[item].desc;
                            return item;
                        }
                    });
                });
            }
        }
        function createNewOptions(data, select) {
            select.empty();
            for (var i = 0; i < data.length; i++) {
                select.append($("<option></option>")
                   .attr("value", data[i].id).text(data[i].val));
            };
        }
        function detailedStatsFilters() {

            if ($('.detailedStats-filters.finalStep').length > 0) {

                var filtersForm = $('.detailedStats-filters.finalStep').find('form');
                var dropdownRows = filtersForm.find('.filter-row');

                dropdownRows.each(function (i) {
                    var thisWrap = $(this);

                    var optionClick = false;
                    $(this).find('select').on('click', function () {

                        if (optionClick) {

                            var thisSelect = $(this);

                            dropdownRows.slice(i + 2).addClass('hide-filter');
                            dropdownRows.slice(i + 1, i + 2).removeClass('hide-filter').addClass('required-filter');
                            thisWrap.removeClass('required-filter');

                            if ($('.filter-row.hide-filter').length > 0 && $('.required-filter').length > 0) {
                                filtersForm.find('.submit-btn-wrapper input').addClass('disableBtn').on('click', function (e) {
                                    e.preventDefault();
                                });
                            } else {
                                filtersForm.find('.submit-btn-wrapper input').removeClass('disableBtn').off('click');
                            }

                            var step = i + 1;
                            switch(step) {
                                case 1:
                                    var url = '/umbraco/api/clinicstatistics/getfilters?clinicId=' + $('#detailedStats').attr('data-clinic-id') + '&year=' + $('#year').val();
                                    break;
                                case 2:
                                    var url = '/umbraco/api/clinicstatistics/getfilters?clinicId=' + $('#detailedStats').attr('data-clinic-id') + '&year=' + $('#year').val() + '&treatment=' + $('#treatment').val();
                                    break;
                                case 3:
                                    var url = '/umbraco/api/clinicstatistics/getfilters?clinicId=' + $('#detailedStats').attr('data-clinic-id') + '&year=' + $('#year').val() + '&treatment=' + $('#treatment').val() + '&age=' + $('#age').val();
                                    break;
                            }


                            $.getJSON(url,
                                function (data) {

                                    if (thisSelect.attr('id') == 'year') {
                                        createNewOptions(data.treatments, $('#treatment'));
                                    }

                                    if (thisSelect.attr('id') == 'treatment') {
                                        createNewOptions(data.ages, $('#age'));
                                    }

                                    if (thisSelect.attr('id') == 'age') {
                                        createNewOptions(data.sources, $('#source'));
                                    }

                                }
                            );

                            optionClick = false;
                        } else { optionClick = true; }

                    }).on('blur', function () { optionClick = false; });

                });


            }

        }
        function detailedStatsComparision() {

            $('.detailedStats-comparision').each(function () {

                var select = $(this).find('.detailedStats-comparisionSelect');
                var contentBlocks = $(this).find('.detailedStats-comparisionContent');

                for (var i = 0; i < contentBlocks.length; i++) {
                    if (i != 0) {
                        $(contentBlocks[i]).hide();
                    }
                };

                var optionClick = false;
                select.on('click', function () {

                    if (optionClick) {

                        var index = $(this).prop('selectedIndex');
                        $(contentBlocks).hide();
                        $(contentBlocks[index]).show();

                        optionClick = false;
                    } else { optionClick = true; }

                }).on('blur', function () { optionClick = false; });

            });

        }



        function websiteSearch() {

            $('.autocomplete').each(function () {
                if ($(this).val() != "") {
                    $(this).closest('form').find('.refine-search-link').addClass('collapsed');
                    $(this).closest('form').find('.refine-search').hide();
                } else {
                    $(this).closest('form').find('.refine-search').show(); 
                    $(this).closest('form').find('.refine-search-link').removeClass('collapsed');
                }
            });

            $('#SearchKeywords:not([autocomplete="off"]')
              // don't navigate away from the field on tab when selecting an item
              .autocomplete({
                  html: true,
                  source: function (request, response) {
                      
                      $.getJSON('/umbraco/api/tagsjson/autocomplete?term=' + request.term)
                      .done(function (data) {
                          response($.map(data, function (value, key) {
                              return {
                                  label: value.val + '<button>&plus;</button>',
                                  value: value.val,
                                  id: value.id
                              };
                          }));
                      });
                  },
                  search: function () {
                  },
                  focus: function () {
                  },
                  select: function (event, ui) {
                      var ul = $('#selected-tags');
                      $(this).val('');
                      ul.append('<li class="selected-tag">' + ui.item.value + ' <button type="button" data-id="' + ui.item.id + '">&times;</button></li>');

                      var ids = $('#tags-hidden').val();
                      var split = '';
                      if ($('#tags-hidden').val() != "") {
                          split = ',';
                      }
                      ids += split + ui.item.id;
                      $('#tags-hidden').val(ids);
                      return false;
                  }
              });

            $(document).on('click', '.selected-tag button', function () {
                $(this).parent().remove();
                var ids = $('#tags-hidden').val();
                var id = $(this).data('id').toString();
                ids = ids.replace("," + id, "").replace(id, "").replace(",,", ",");
                console.log(ids, id);
                $('#tags-hidden').val(ids);
            });
        }

        return {
            // public members
            init: function () {
                $(".hide-if-no-js").removeClass();
                $(".no-js").hide();
                $("body").addClass("js").removeClass("body-no-js");
                navigation();

                $(".main-body-section").each(function(){

                    var rowTitleClasses = 'row-title';
                    var toggle = $(this).data("collapse-row");
                    if(toggle){
                        var t = $(this).find(".toggle");
                        t.hide();
                        $(this).find(".toggle-section a").removeClass('open');
                        $(this).find(".toggle-section").addClass('t_s_closed');
                        rowTitleClasses += ' visible';
                    }


                    if ($(this).data("row-title")) {

                        var title = $(this).data("row-title");
                        var heading = $("<h2/>", {
                            html: title,
                            "class": rowTitleClasses
                        });
                        $(this).find(".central-col").prepend(heading);

                        if ($(this).find('.row-title.visible').length == 0) {
                            $(this).find('.row-title').hide();
                        }

                    }

                })

                $(".cafcsearchresults  .clinic-search").hide();
                $(".search-page-link").click(function(e){
                    e.preventDefault();
                    $(".clinic-search").slideToggle();
                })

                $(".refine-search").hide();
                $(".refine-search-link").addClass('collapsed').click(function (e) {
                    e.preventDefault();
                    $(this).toggleClass('collapsed');
                    $(this).closest('.row').find('.refine-search').stop().slideToggle();
                })

                $(".toggle-section a").click(function (e) {
                    e.preventDefault();
                    var p = $(this).closest(".main-body-section"), t = p.find(".toggle"), t_s = $(this).closest(".toggle-section"), title = p.find('.row-title');
                    t_s.toggleClass('t_s_closed');
                    t.slideToggle();
                    title.slideToggle();
                    $(this).toggleClass('open');
                    var top = p.offset().top - 20;
                    $("html, body").delay(400).animate({
                        scrollTop: top
                    })
                })

                $("a.scroll-to").click(function (e) {
                    e.preventDefault();
                    var top = $($(this).attr('href')).offset().top - 20
                    $("html, body").delay(400).animate({
                        scrollTop: top
                    })
                })

                $('.guidance-row .see-also-wrapper').hide().addClass('see-also-hidden');
                $(".see-also-toggle").click(function (e) {
                    e.preventDefault();
                    var section = $(this).parents('.guidance-row').find('.see-also-wrapper');

                    if (section.hasClass('see-also-hidden')) {
                        section.stop().slideDown('fast').removeClass('see-also-hidden');
                        $('.see-also-wrapper').not(section).slideUp('fast').addClass('see-also-hidden');
                        $('.see-also-toggle').not($(this)).text('See also >');
                    } else {
                        section.stop().slideUp('fast').addClass('see-also-hidden');
                    }

                    $(this).text((section.hasClass('see-also-hidden')) ? 'See also >' : 'Hide see also <');
                });

                $(".accordion-toggle").click(function (e) {
                    e.preventDefault();
                    var p = $(this).closest(".panel-heading"), t = p.siblings(".panel-collapse");
                    t.slideToggle();
                    $(this).toggleClass('open');
                    var top = p.offset().top - 20;
                    $("html, body").animate({
                        scrollTop: top
                    })
                })

                $(".mobile-menu").click(function(e){
                    e.preventDefault();
                    $(this).toggleClass("open");
                    $(".site-header .col-rhs").slideToggle();
                })

                $(".cop-nav-toggle").click(function(e){
                    e.preventDefault();
                    var p = $(this).closest("li");
                    p.toggleClass("open");
                    p.children("ul").slideToggle();
                })

                if ($('.treatment-search').length) {
                    $.get("/umbraco/api/treatmentSearch/treatmentsearchoptions", function (mySource) {
                        var objects = [];
                        var myMap = {};
                        $.each(mySource, function (i, object) {
                            myMap[object.id] = object;
                        });
                        // console.log(myMap);
                        $('.treatment-search').typeahead({
                            source: function (query, process) {
                                objects = [];
                                $.each(mySource, function (i, object) {
                                    objects.push(object.id);
                                });
                                process(objects);
                            },
                            updater: function (item) {
                                // console.log(myMap[item].url);
                                window.location.href = myMap[item].val;
                                return item;
                            }
                        })
                    });
                }

                if ($(".rangeChart").length > 0) {
                    rangeChart();
                }
                if ($("#map").length > 0) {
                    listingMap();
                }
                if ($("#clinic-map").length > 0) {
                    clinicMap();
                    lineChart();
                }
                if ($(".donutChart").length > 0) {
                    donutChart();
                }
                if ($(".pieChart").length > 0) {
                    pieChart();
                }
                if ($(".timeline").length > 0) {
                    timeline();
                }
                if ($(".clinic-search").length > 0) {
                    clinicSearch();
                }
                if($(".star-rating-form").length > 0){
                    starRatingForm();
                }
                if($(".homepage-grid").length > 0){
                    homepageLoadmore();
                }
                if ($(".autocomplete").length > 0) {
                    websiteSearch();
                }
                if($(".cookie").length > 0) {
                    cookieMessage();
                }
                if ($(".sharethis_wrapper").length > 0) {
                    sharethis();
                }
                if ($(".detailedStats-filters").length > 0) {
                    detailedStatsFilters();
                }
                if ($(".detailedStats-comparision").length > 0) {
                    detailedStatsComparision();
                }

				$('.umb-grid article').matchHeight({ byRow: true, property: 'height', target: null, remove: false });

                var toDesktopQuery = "screen and (max-width:1023px)",
                desktopQuery = "screen and (min-width:1024px)",
                fromTabletQuery = "screen and (min-width:768px)",
                tabletToDesktop = "screen and (min-width: 768px) and (max-width: 1023px)",
                toTablet = "screen and (max-width: 767px)";

                enquire.register(toDesktopQuery, {
                    match: function () {
                        $(".subnav").hide();
                        $(".primary-li a").each( function(e){
                            var subnav = $(this).siblings(".subnav");
                            if(subnav.length){
                                $(this).addClass("togglenav").append("<span/>");
                            }
                        });
                        $(".primary-li a").off();
                        $(".primary-li").off();

                        $(".primary-li a").on("click", function(e){
                            var subnav = $(this).siblings(".subnav");
                            if(subnav.length){
                                e.preventDefault();
                                subnav.slideToggle();
                                $(this).toggleClass("open");
                                console.log(subnav.length);
                            }
                        })
                    },
                    unmatch: function () {
                        $(".togglenav span").remove();

                    },
                    setup: function () {
                    }
                }).register(desktopQuery, {
                    deferSetup: true,
                    match: function () {
                        // Make full width spotlights on landing pages ignore container class
                        $(".bottomgrid .col-lg-12, .bottomgrid .col-md-12").closest(".container").addClass("extra-wide");
                        $(".timeline h3").first().addClass("active");
                        $(".timeline h3").on("click", function(){
                            $(".timeline h3").first().removeClass("active");
                        });

                        $(".site-header .col-rhs").show();

                        $(".subnav").show();
                        $(".primary-li").off();
                        $(".primary-li a").off();
                        $(".subnav").each(function(i){
                            var h = $(this).height(), h = h + 95;
                            $(this).closest("li").height(h);
                        })
                        $(".primary-nav a").on("focus", function(e){
                            $(".primary-li").addClass("auto_height").delay(200).addClass("show_nav");
                            var thisParent = $(this).closest(".primary-li");
                            thisParent.removeClass("auto_height").delay(200).removeClass("show_nav");
                        }).on("blur", function(e){
                            $(".primary-li").addClass("auto_height").addClass("show_nav");
                            var thisParent = $(this).closest(".primary-li");
                            thisParent.removeClass("auto_height").removeClass("show_nav");
                        })

                        $(".primary-li").on("mouseenter", function(e){
                            var thisParent = $(this).closest(".primary-li");
                            $(this).removeClass("auto_height").delay(200).removeClass("show_nav");
                        }).on("mouseleave", function(e){
                            $(".primary-li").addClass("auto_height").delay(200).addClass("show_nav");
                        })
                    },
                    unmatch: function () {
                        $(".timeline h3").first().removeClass("active");

                    },
                    setup: function () {

                    }
                }, true).register(tabletToDesktop, {
                    deferSetup: true,
                    match: function () {
                    },
                    unmatch: function () {
                    },
                    setup: function () {

                    }
                }).register(toTablet, {
                    deferSetup: true,
                    match: function () {
                    },
                    unmatch: function () {
                    }, setup: function () {

                    }
                });


            }
        };
    }());

    $(function () {
        PAGE.init();
    });
}(jQuery));


// IR Scripts
$(document).ready(function () {
    $('.stats').hide();
    var inputC = $('.stat-control input:checked').attr('class');
    $('div.' + inputC).show();
    $('.stat-control input').change(function () {
        var cl = $(this).attr("class");
        $('.stats').hide();
        $('div.' + cl).show();
    });

    var firstRadio = $('div.statistics-chart-control div.panel:first-child div.panel-collapse').find('input[type="radio"]:first-child');
    //UpdateStatus(firstRadio);
    //$(firstRadio).trigger('change');
    $('div.statistics div.dynamic-range-charts input[type="radio"]').on('change', function () {
        $(this).parents('div.panel-body').first().find('h3').text($(this).attr('data-content')); $(this).parents('div.panel-body').first().find('span.period').text($(this).attr('data-period'));
        //UpdateStatus($(this));
    });
    $('h6.panel-title > a').on('click', function () {
        $(this).parents('div.panel-body').first().find('h3').text($(this).text()); $(this).parents('div.panel-body').first().find('span.period').text($(this).attr('data-period'));
    });

    function UpdateStatus(radio) {
        if (parseInt($(radio).parent('label').attr('data-mean')) == parseInt($(radio).parent('label').attr('data-nat-ave'))) {
            $('p.consistentStatus').removeClass("below-average").removeClass("above-average")
            $('p.consistentStatus').addClass("above-average")
            $('p.consistentStatus > span.consistent_text').html('Consistent with');
        }
        else if (parseInt($(radio).parent('label').attr('data-mean')) > parseInt($(radio).parent('label').attr('data-nat-ave'))) {
            $('p.consistentStatus').removeClass("below-average").removeClass("above-average")
            $('p.consistentStatus').addClass("above-average")
            $('p.consistentStatus > span.consistent_text').html('Above');
        }
        else if (parseInt($(radio).parent('label').attr('data-mean')) < parseInt($(radio).parent('label').attr('data-nat-ave'))) {
            $('p.consistentStatus').removeClass("below-average").removeClass("above-average")
            $('p.consistentStatus').addClass("below-average")
            $('p.consistentStatus > span.consistent_text').html('Below');
        }
    }
});