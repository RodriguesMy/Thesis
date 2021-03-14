function update(type_name) {
    document.getElementById("CategorySelection").value = type_name;
}

function addToReceipt(item_name, item_id, item_price) {
    var table = document.getElementById("receipt_table");

    var alreadyExists = false;
    //check if item already exists in table
    for (i = 2; i < table.rows.length; i++) {
        var cells = table.rows.item(i).cells;

        if (cells.item(0).innerHTML == item_id) {
            //adding to quantity
            cells.item(3).innerHTML = parseInt(cells.item(3).innerHTML, 10) + 1;

            //adding to cost
            cells.item(2).innerHTML = parseFloat(cells.item(2).innerHTML) + item_price;

            alreadyExists = true;
        }
    }

    if (!alreadyExists) {
        //if item does not exist in table, add a new row
        var row = table.insertRow(-1);

        var id = row.insertCell(0);
        var descrption = row.insertCell(1);
        var price = row.insertCell(2);
        var qty = row.insertCell(3);

        id.innerHTML = item_id;
        descrption.innerHTML = item_name;
        price.innerHTML = item_price;
        qty.innerHTML = 1;
    }

    //add up to total price
    var total = 0;
    for (i = 2; i < table.rows.length; i++) {
        var cells = table.rows.item(i).cells;
        total += parseFloat(cells.item(2).innerHTML);
    }
    document.getElementById("total_price").innerHTML = "Total Price: " + total;
}

function removeFromReceipt() {

}