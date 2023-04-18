var home = (function () {
    var configs = {
        urls: {
            sign: ''
        }
    };

    var init = function ($configs) {
        configs = $configs;
    };

    var sign = function () {
        console.log(configs.urls.sign);
        $.get(configs.urls.sign).done(function () {
            location.href = (configs.urls.sign);
        });
    }

    var signup = function () {
        var model = $("#dadosLogin").SerializeObject();
        $.post(configs.urls.sign, model).done(function () {
            location.href = (configs.urls.sign);
        });
    }
    return {
        init: init,
        sign: sign
    };
})();