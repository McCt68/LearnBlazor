// Implementing a custom js file - remember to do it also in the App.razor file

window.showToastr = function (type, message) {
    if (type == "success"){
        toastr.success(message);
    }
    if (type == "error"){
        toastr.error(message);
    }
}

window.ShowSwal = function (type, message) {
    if (type == "success"){
        swal.fire({
            title: "Good job!",
            text: message,
            icon: "success"
        });
    }
    if (type == "error"){
        swal.fire({
            title: "Task Failed",
            text: message,
            icon: "error"
        });
    }

}