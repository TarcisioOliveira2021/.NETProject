// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(() => {

    $('#btn').click(function () {

        var dadosEntrada = {};
        dadosEntrada.n = parseInt($('#img-qtd').val());
        dadosEntrada.prompt = $('#texto').val();
        dadosEntrada.size = $('#img-tamanho').find(":selected").val();


        $.ajax({
            url: '/Home/GerandoImagem',
            method: 'post',
            contentType: 'application/json',
            data: JSON.stringify(dadosEntrada)

        }).done(function (data) {

            $.each(data.data, function () {
                $('#display').append(
                    '<div class="col-md-3 p-10" style="padding-top:10px">' +
                    '<img class="p-10" src = "' + this.url + '"/>' +
                    '</div>');
            });

        });
    });


});