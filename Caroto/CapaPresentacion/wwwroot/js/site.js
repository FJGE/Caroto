// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function cambiarStyle(variable) {
    var elemento = document.getElementById("H" + variable);

    if (elemento.className == "visible") {
        elemento.className = "invisible";
    }
    else if (elemento.className == "invisible") {
        elemento.className = "visible";
    }
}