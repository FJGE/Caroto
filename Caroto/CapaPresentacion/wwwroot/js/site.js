// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function cambiarStyle() {
    var element = document.getElementById("asdasd");

    if (element.className == "visible") {
        element.className = "invisible";
    }
    else if (element.className == "invisible") {
        element.className = "visible";
    }
}