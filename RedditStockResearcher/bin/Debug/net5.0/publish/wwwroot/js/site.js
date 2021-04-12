// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    console.log("Page is ready");


    $("#addSubInput").keyup(function (event) {
        event.preventDefault();
        
        if (event.keyCode === 13) {  
            var subredditInput = $(this).val();
            var ticker = $("#tickerHeader").text();
            doAddSubreddit(subredditInput, ticker);
        }
        
    })

    $("#addSubButton").click(function (event) {
        event.preventDefault();

        var subredditInput = $("#addSubInput").val();
        var ticker = $("#tickerHeader").text();
        doAddSubreddit(subredditInput, ticker);
        

    })


    $("#sortSelect").on('change',function (event) {
        var sortBySelected = this.value;
        var ticker = $("#tickerHeader").text();
        doSortSubreddit(sortBySelected, ticker);

    })

    $("button[id*='delete']").click(function (event) {
        var subToRem = this.parentElement.id;

        if (confirm("Remove " + subToRem + "?")) {
            var ticker = $("#tickerHeader").text();
            doRemoveSubreddit(subToRem, ticker);
            $("#" + subToRem + "Card").remove();
        }
    })

    
    function doAddSubreddit(subToAdd, ticker) {

        $.ajax({
            method: "GET",
            url: "/Search/AddSubreddit",
            data: {
                "addSub": subToAdd,
                "ticker": ticker
            },
            beforeSend: function () {
                $("#filterDiv").html("");
                $("#filterDiv").addClass("spinner-border");
            }
        }).done(function (data) {
            console.log("finished");
            $("#filterDiv").removeClass("spinner-border");
            $("#filterDiv").html(data);
        });
    }


    function doSortSubreddit(sortBy, ticker) {

        $.ajax({
            method: "GET",
            url: "/Search/SortSubreddit",
            data: {
                "sortBy": sortBy,
                "ticker": ticker
            },
            beforeSend: function () {
                $("#filterDiv").html("");
                $("#filterDiv").addClass("spinner-border");
            }
        }).done(function (data) {
            console.log("finished");
            $("#filterDiv").removeClass("spinner-border");
            $("#filterDiv").html(data);
        });
    }

    function doRemoveSubreddit(subToRem, ticker) {

        $.ajax({
            method: "GET",
            url: "/Search/RemoveSubreddit",
            data: {
                "remSub": subToRem,
                "ticker": ticker
            }
        });
    }
})