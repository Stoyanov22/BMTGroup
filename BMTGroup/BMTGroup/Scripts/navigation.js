$("a").click(function (e) {
    e.preventDefault();
    var section = $(this).attr("href");
    $("html, body").animate({
        scrollTop: $(section).offset().top
    });
});

//$(window).scroll(function () {
//    var scrolledY = $(window).scrollTop();
//    $('.parallax1').css('background-position', 'left ' + ((scrolledY)) + 'px');
//});