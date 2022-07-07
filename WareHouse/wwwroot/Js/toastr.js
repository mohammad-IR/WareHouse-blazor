
window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, "عملیات موفق", { timeOut: 5000 });
    }
    if (type === "error") {
        toastr.error(message, "عملیات ناموفق", { timeOut: 5000 });
    }
}

