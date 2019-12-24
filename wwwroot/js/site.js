// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var checkbox = document.getElementById("fc");
var showfield = document.getElementById("fields");


checkbox.addEventListener('change', function () {
    if (this.checked) {

        showfield.style.display = "inline";
        // Checkbox is checked..
    } else {

        showfield.style.display = "none";
        // Checkbox is not checked..
    }
});