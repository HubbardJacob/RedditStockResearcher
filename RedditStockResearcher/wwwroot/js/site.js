// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    console.log("Page is ready");


    $("#addSubInput").keyup(function (event) {
        event.preventDefault();
        
        if (event.keyCode === 13) {
            console.log("input was entered");
            var subredditInput = $(this).val();
            var ticker = $("#tickerHeader").text();
            doAddSubreddit(subredditInput, ticker);
        }
        
    })

    function doAddSubreddit(subToAdd, ticker) {
        $.ajax({
            method: "GET",
            url: "/Search/AddSubreddit",
            data: {
                "addSub": subToAdd,
                "ticker": ticker
            }
        }).done(function (data) {
            console.log("finished");
            $("#filterDiv").html(data);
        });
    }
})