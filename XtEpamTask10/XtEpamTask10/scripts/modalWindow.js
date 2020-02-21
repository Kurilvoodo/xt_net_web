function openModalWindow(modalWindowId) {
    let modal = document.getElementById(modalWindowId);
    modal.style.display = "block";
}

function closeModalWindow(modalWindowId) {
    let modal = document.getElementById(modalWindowId);
    modal.style.display = "none";
}

function openModalWindow(modalWindowId, hiddenInputId, idElementForEdit) {
    let modal = document.getElementById(modalWindowId);
    document.getElementById(hiddenInputId).value = idElementForEdit;
    modal.style.display = "block";
}