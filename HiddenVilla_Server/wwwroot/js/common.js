window.ShowToastr = (type, message) => {
    if (type === "warning") {
        toastr.warning(message, "Operation successful.");
    } else if (type === "error") {
        toastr.error(message);
    } else if (type === "success") {
        toastr.success(message, "This is a success message");
    }
}

window.ShowSwal = (type, messageOne, messageTwo) => {
    if (type === "success") {
        Swal.fire(
            messageOne,
            messageTwo,
            'success'
        );
    } else if (type === "warning") {
        Swal.fire(
            messageOne,
            messageTwo,
            'warning'
        );
    } else if (type === "error") {
        Swal.fire(
            messageOne,
            messageTwo,
            'error'
        );
    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}