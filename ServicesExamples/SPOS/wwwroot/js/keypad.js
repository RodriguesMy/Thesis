
function addToCode(valueToAdd) {
    document.getElementById('code').value += valueToAdd;
}

function clearCode() {
    if (document.getElementById('code'))document.getElementById('code').value = "";
}

window.onload = function() {
    clearCode();
    localStorage.clear();
}