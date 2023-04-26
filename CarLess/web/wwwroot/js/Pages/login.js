var login = (() => {
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
            console.log(model)
            $.post(configs.urls.cadastrarUsuario, model).done(() => {
            });
        }

    return {
        init: init,
        cadastrarUsuario: cadastrarUsuario
    };
})();