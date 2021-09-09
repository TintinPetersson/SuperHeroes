// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let select = document.getElementById("heroes");
select.addEventListener("change", function () {
    for (var i = 0; i < select.length; i++) {
        select[i].removeAttribute("selected");
    }
    select.options[select.selectedIndex].setAttribute("selected", "selected");
})
