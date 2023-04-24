

var home = (function () {
    var configs = {
        urls: {
            index: '',
        }
    };

    var init = function ($configs) {
        configs = $configs;
    };

    var chamaCarousel = function () {
        $.get(configs.urls.index).done((html) => {
            $('#carrossel').html(html);
        });
    };

    return {
        init: init,
        chamaCarousel: chamaCarousel
    };
})()