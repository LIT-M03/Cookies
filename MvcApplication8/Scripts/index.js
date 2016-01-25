$(function() {
    $("#clickme").on('click', function() {
        var number = $("#override").val();
        $.cookie('number', number);
        window.location.reload();
    });

    $("#delete").on('click', function() {
        $.removeCookie('number');
        window.location.reload();
    });
})