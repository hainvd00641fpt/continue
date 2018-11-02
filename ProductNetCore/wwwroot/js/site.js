// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".btnDeleteClick").click(function () {
        const currentBtn = $(this);
        console.log(currentBtn.attr("id"));
        if (confirm("Do you want delete ?")) {
            $.ajax({
                url: 'Delete?id=${currentBtn.atrr("id")}',
                method: "Delete",
                success: function (data) {
                    console.log("Delete Success!");
                    currentBtn.parent().remove();
                }
            });
        }
    });
})