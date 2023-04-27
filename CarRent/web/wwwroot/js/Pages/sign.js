var sign = (() => {

    var configs = {
        urls: {
            index: '',
            cadastrarUsuario: ''
        }
    };

    var init = ($configs) => {
        configs = $configs;
    };

    var cadastrarUsuario = () => {
            var model = $('#cadastroUsuario').serializeObject();
             $.post(configs.urls.cadastrarUsuario, model).done(() => {
                console.log('sucesso')
            });
        }

    return {
        init: init,
        cadastrarUsuario: cadastrarUsuario
    };
})();