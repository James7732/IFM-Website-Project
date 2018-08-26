$(document).ready(function () {

    // Function to change the nav-bar on scroll
    $(window).scroll(function () {
        ($(window).scrollTop() >= 100) ? (
            $('.navbar').addClass('scrolled')
        ) : (
                $('.fixed-nav-bar').removeClass('scrolled')
            );
    });

});
