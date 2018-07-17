$(".submitBtn").click(function () {
    if ($("input[name ^= 'semail']").val().length === 0) {
        alert("The email field cannot be empty!");
        return false;
    }
});

