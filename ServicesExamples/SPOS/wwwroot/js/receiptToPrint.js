function updateTotalPrice(receipt) {
    //add up to total price
    var total = 0;
    for (i = 0; i < receipt.items.length; i++) {
        total += receipt.items[i].price * receipt.items[i].qty;
    }
    document.getElementById("total_price").innerHTML = "€" + total.toFixed(2);
}

function fillOrder() {
    var table = document.getElementById("receipt_table");

    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

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
    updateTotalPrice(receipt);
}

window.onload = function () {
    fillOrder();
}