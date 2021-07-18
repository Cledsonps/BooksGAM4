// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// var botaoAdicionar = document.querySelector("#btnGravar");
// botaoAdicionar.addEventListener("click", function(event) {

//     event.defaultPrevented;
//     var conteudo = document.querySelector("[name='txtstart']").value = "valor";
//     conteudo.textContent = "valor";
//     console.log(conteudo);
// });

var botaoAdicionar = document.querySelector("#btnGravar");

function addTexto() {
    var conteudo = document.querySelector("[name='txtstart']").value = "valor";
    conteudo.textContent = "valor";
    console.log(conteudo);
};

function existeImagem() {
    var conteudo = document.querySelector("[name='txtstart']").value;
    conteudo.textContent = "valor";
    if (conteudo == "" || console == null) {
        alert("Escolha uma imagem para upload.");
    }
}


$(document).ready(function() {
    $(window).scroll(function() {
        if ($(this).scrollTop() > 100) {
            $('a[href="#top"]').fadeIn();
        } else {
            $('a[href="#top"]').fadeOut();
        }
    });

    $('a[href="#top"]').click(function() {
        $('html, body').animate({ scrollTop: 0 }, 800);
        return false;
    });
});