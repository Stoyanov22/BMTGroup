//window.location.hash = "jump_to_this_location";
//$(document).ready(function () {
//    $(".navigateContact").click(function () {
//        window.location.hash = "contact";
//});

$("nav").find("a").click(function (e) {
    e.preventDefault();
    var section = $(this).attr("href");
    $("html, body").animate({
        scrollTop: $(section).offset().top
    });
});