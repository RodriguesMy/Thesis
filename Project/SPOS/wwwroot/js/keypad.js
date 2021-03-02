
function addToCode(valueToAdd) {
    document.getElementById('code').value += valueToAdd;
}

function clearCode() {
    document.getElementById('code').value = "";
}

window.onload = function() {
    clearCode();
}