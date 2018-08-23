formataCnpjCpf();
$(document).ready(function () { formataCnpjCpf(); });

function formataCnpjCpf() {
    var SPMaskBehavior = function (val) {
        return val.replace(/\D/g, '').length > 11 ? '00.000.000/0000-00' : '000.000.000-009';
    },
        spOptions = {
            onKeyPress: function (val, e, field, options) {
                field.mask(SPMaskBehavior.apply({}, arguments), options);
            }
        };
    $('.cnpjcpf').mask(SPMaskBehavior, spOptions);
    $('.cnpjcpf').mask(SPMaskBehavior, spOptions);
    $('.cpf').mask('000.000.000-00', { reverse: true });
    $('.cnpj').mask('00.000.000/0000-00', { reverse: true });
}

