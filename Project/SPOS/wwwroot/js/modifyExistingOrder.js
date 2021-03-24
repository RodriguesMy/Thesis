function retrieveOrder(orderId) {
    document.getElementById('selectedOrder').value = orderId;
    document.getElementById('submit').click();
    localStorage.setItem("selectedOrder", orderId);
}

function clearTable(table) {
    //clear table except the two rows on top which are the titles and details    
    for (i = table.rows.length - 1; i >= 1; i--) {
        table.deleteRow(table.rows.length - 1);
    }
}

function updateTotalPrice() {
    let receipt = new Receipt(JSON.parse(document.getElementById('jsonReceiptContents').innerHTML));

    //add up to total price
    var total = 0;
    for (i = 0; i < receipt.items.length; i++) {
        total += receipt.items[i].price * receipt.items[i].qty;
    }
    document.getElementById("total_price").innerHTML = "€" + total.toFixed(2);
}

function fillOrder() {
    var table = document.getElementById("receipt_table");
    clearTable(table);

    let receipt = new Receipt(JSON.parse(document.getElementById('jsonReceiptContents').innerHTML));

    var rowCounter = 1;
    for (i = 0; i < receipt.items.length; i++) {
        var row = table.insertRow(rowCounter++);

        var id = row.insertCell(0);
        var description = row.insertCell(1);
        var price = row.insertCell(2);
        var qty = row.insertCell(3);

        id.innerHTML = receipt.items[i].id;
        description.innerHTML = receipt.items[i].description;
        price.innerHTML = "€" + (receipt.items[i].price * receipt.items[i].qty).toFixed(2);
        qty.innerHTML = receipt.items[i].qty;   
    }
    updateTotalPrice();
}

function modifyOrder() {
    localStorage.setItem("receipt", document.getElementById('jsonReceiptContents').innerHTML);
    localStorage.setItem("currentlyModifyingOrder", "true");
    location.replace('/MainPage');
}

window.onload = function () {
        fillOrder();
}