var carro = (() => {
    var configs = {
        urls: {
            suv: '',
            esportivo: '',
            performace: '',
            utilitario: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var mostraPag = (div, urls) => {
        $.get(configs.urls[urls]).done((html) => {
            $('.mostrar').removeClass('mostrado');
            $(`#${div}`).addClass('mostrado');
            $('.mostrar').hide();
            $('.mostrado').show();
            $(`#${div}`).html(html);
        }); 
    };
   
    return {
        init: init,
        mostraPag: mostraPag
    };
})();