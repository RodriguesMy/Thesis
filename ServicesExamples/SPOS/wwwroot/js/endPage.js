
window.onclick = function (event) {
    location.replace('/');  
}

function sleep(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds) {
            break;
        }
    }
}

window.onload = function() {
    var printWindow = window.open('http://localhost:8080/ReceiptToPrint','Receipt');

    $(printWindow).bind("load", function () {
        printWindow.print();
        //sleep(5000);
        //printWindow.close();
    });
    
}