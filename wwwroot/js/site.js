$(document).ready(function () {
    // Resize navbar when scrolling down
    $(window).scroll(function () {
        var fromTop = $(document).scrollTop();
        if (fromTop > $('.navbar').height()) $('.navbar').addClass('minimized');
        else $('.navbar').removeClass('minimized');
    });
});
