var site = (function () {
    var config = {
    };

    var init = function ($config) {
        config = $config;
    }

    $(function () {
        $(document).on('submit', 'form', function (e) {
            e.preventDefault();
            return false;
        });
    });

    (function () {
        $.fn.serializeObject = function (extraValidations) {
            var form = $(this),
                array = this.serializeArray(),
                obj = {};

            $.each(array, function () {
                if (!obj[this.name]) {
                    obj[this.name] = this.value;
                    return;
                }

                if (!Array.isArray(obj[this.name]))
                    obj[this.name] = [obj[this.name]];

                obj[this.name].push(this.value);
            });

            form.find('.uk-form-controls, .uk-inline').find('input, select, textarea').trigger('input');

            obj.isValid = !form.find('.uk-form-controls.error, .uk-inline.error').length;
            if (obj.isValid && typeof extraValidations === 'function')
                obj.isValid = extraValidations(form, obj);

            obj.isEmpty = true;
            for (var prop in obj)
                if (typeof obj[prop] === 'string' && obj[prop].trim()) {
                    obj.isEmpty = false;
                    break;
                }

            return obj;
        };
    })();

    return {
        init: init
    };
})();
