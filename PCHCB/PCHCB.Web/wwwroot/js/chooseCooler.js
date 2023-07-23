function updateForm() {
    var currentValue = parseInt($('#Type').val());
    if (currentValue === 0) {
        $('#airForm').removeClass('d-none');
        $('#waterForm').addClass('d-none');
    } else {
        $('#airForm').addClass('d-none');
        $('#waterForm').removeClass('d-none');
    }
}