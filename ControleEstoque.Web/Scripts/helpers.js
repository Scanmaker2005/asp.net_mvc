class messageBox
{
    static confirm(msg,callback)
    {
        bootbox.confirm({
            message: msg,
            buttons: {
                confirm: {
                    label: 'Sim',
                    className: 'btn-success'
                },
                cancel: {
                    label: 'Nao',
                    className: 'btn-danger'
                }
            },
            callback: function (confirmed) {
                if (confirmed)
                {
                    callback();
                }
            }
        });
    }
}



class form {


    static getData(form) {
        var form = $(form);
        var o = {};
        var a = form.serializeArray();
        $.each(a, function () {
            if (o[this.name] !== undefined) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        return o;
    }

    static submit(method, url, JSON = {}) {
        var form = "<form hidden action='" + url + "' name='___FORM___' id='___FORM___' method='" + method +"'>";
        for (var campo in JSON) {
            form += "<input id='" + campo + "' name='" + campo + "'  value='" + JSON[campo] + "'>";
        }
        form += "</form>";
        var form_ = document.createElement("h1")
        form_.innerHTML = form;
        document.body.appendChild(form_);
        document.___FORM___.submit();
    }
}
