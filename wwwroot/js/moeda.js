function carregaMaskMoney() {
    $('.moeda').maskMoney({ prefix: 'R$ ', allowNegative: true, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.moeda').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });
    console.log("Tipo: " + typeof (valor) + ", Valor: " + valor)

    $('.moedasemnegativo').maskMoney({ prefix: 'R$ ', allowNegative: false, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.moedasemnegativo').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });
    console.log("Tipo: " + typeof (valor) + ", Valor: " + valor)

    $('.porcentagem').maskMoney({ suffix: '%', allowNegative: false, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.porcentagem').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });

    $('.numeral').maskMoney({allowNegative: false, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.numeral').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });

    $('.centimetro').maskMoney({ suffix: ' cm', allowNegative: false, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.centimetro').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });

    $('.milimitro').maskMoney({ suffix: ' mm', allowNegative: false, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.milimitro').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });

    $('.metro').maskMoney({ suffix: ' m', allowNegative: false, thousands: ".", decimal: ",", affixesStay: true, allowZero: true });
    var valor = $('.metro').each(function () {
        $(this).maskMoney('mask', $(this).val())[0].value;
    });

}
carregaMaskMoney();
$(document).ready(function () {
    carregaMaskMoney();
});