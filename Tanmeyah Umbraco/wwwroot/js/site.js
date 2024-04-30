// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById("menuToggle").addEventListener("click", function () {
    var sideMenu = document.querySelector(".second-header");
    if (sideMenu.style.left === "0px") {
        sideMenu.style.left = "-250px"; // Hide menu
    } else {
        sideMenu.style.left = "0px"; // Show menu
    }
});
// Example to handle dropdowns on touch devices

