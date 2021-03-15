
class Item_in_Receipt {
    constructor(id, description, price, qty) {
        this.id = id;
        this.description = description;
        this.price = price;
        this.qty = qty;
    }
}

class Receipt {
    constructor(items) {
        if (items == null)
            this.items = [];
        else
            this.items = items;
    }
    addToReceipt(id, description, price, qty) {
        let item = new Item_in_Receipt(id, description, price, qty);
        this.items.push(item);
    }

    exists(item_id) {
        return this.items.some(x => x.id === item_id);
    }

    increaseQuantity(id) {
        var index = this.items.findIndex(x => x.id === id);
        this.items[index].qty = this.items[index].qty + 1;
    }

    deleteItem(id) {
        var index = this.items.findIndex(x => x.id === id);
        this.items.splice(index,1);
    }
}

function update(type_name) {
    document.getElementById("CategorySelection").value = type_name; 
}

function clearTable(table) {
    //clear table except the two rows on top which are the titles and details    
    for (i = table.rows.length - 1; i >= 2; i--) {
        table.deleteRow(table.rows.length - 1);
    }
}

function updateReceipt() {    
    var table = document.getElementById("receipt_table");
    clearTable(table);

    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    var rowCounter = 2;
    for (i = 0; i < receipt.items.length; i++) {
        var row = table.insertRow(rowCounter++);

        var id = row.insertCell(0);
        var description = row.insertCell(1);
        var price = row.insertCell(2);
        var qty = row.insertCell(3);

        id.innerHTML = receipt.items[i].id;
        description.innerHTML = receipt.items[i].description;
        price.innerHTML = receipt.items[i].price * receipt.items[i].qty;
        qty.innerHTML = receipt.items[i].qty;
    }
}

function updateTotalPrice() {
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    //add up to total price
    var total = 0;
    for (i = 0; i < receipt.items.length; i++) {
        total += receipt.items[i].price;
    }
    document.getElementById("total_price").innerHTML = "Total Price: " + total;
}

function addToReceipt(item_name, item_id, item_price) {

    //receiving the recept from the local storage
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));
    
    //check if item already exists in table
    if (receipt.exists(item_id)) {
        receipt.increaseQuantity(item_id);
    }
    else {
        //if item does not exist in table, add it into the list
        receipt.addToReceipt(item_id, item_name, item_price, 1);
    }

    //update array to local database
    localStorage.setItem("receipt", JSON.stringify(receipt.items));

    //update html context 
    updateReceipt();
    updateTotalPrice();  

    //function updates and highlights the selected row of 
    //the table when clicked
    $(function () {
        $('td').click(function () {
            $('tr').removeAttr('id');
            $(this).parent().attr('id', 'active');
        });
    });
}

function back() {
    location.replace('/MainPage');
}

function removeSelectedItem() {
    var item_id = document.getElementById("receipt_table").rows.namedItem("active").cells[0].innerHTML;

    //remove item from list--
    //receiving the recept from the local storage
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    //checking if the item has more than one quantity
    //deleting item
    receipt.deleteItem(item_id);

    //update array to local database
    localStorage.setItem("receipt", JSON.stringify(receipt.items));

    //update html context 
    updateReceipt();
    updateTotalPrice();  

    //function updates and highlights the selected row of 
    //the table when clicked
    $(function () {
        $('td').click(function () {
            $('tr').removeAttr('id');
            $(this).parent().attr('id', 'active');
        });
    });
}

window.onload = function () {
    updateReceipt();
    updateTotalPrice();
}

$(function () {
    $('td').click(function () {
        $('tr').removeAttr('id');
        $(this).parent().attr('id','active');
    });
});

var checkForSelectedRow = setInterval(function () {
    if (document.getElementById("active") != null) {
        //Check if its a valid row
        var item_id = document.getElementById("receipt_table").rows.namedItem("active").cells[0].innerHTML;
        var num = parseInt(item_id);

        if (!isNaN(num)) {
            //make remove button visible
            document.getElementById("removeBtn").style.visibility = "visible";
            return;
        }

    }

    //hide 'remove' button
    document.getElementById("removeBtn").style.visibility = "hidden";
});

