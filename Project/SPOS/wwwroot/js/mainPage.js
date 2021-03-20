
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

    quantityIsMoreThanOne(id) {
        var index = this.items.findIndex(x => x.id === id);
        if (this.items[index].qty > 1) return true;
        return false;
    }

    getQuantity(id) {
        var index = this.items.findIndex(x => x.id === id);
        return this.items[index].qty;
        
    }

    deleteMultiple(id, totalToDelete) {
        var index = this.items.findIndex(x => x.id === id);
        this.items[index].qty = this.items[index].qty - totalToDelete;

        if (this.items[index].qty <= 0) this.deleteItem(id);
    }

    getTotalPrice() {
        var total = 0;
        for (i = 0; i < this.items.length; i++) {
            total += this.items[i].price * this.items[i].qty;
        }
    }
}

function update(type_name) {
    document.getElementById("CategorySelection").value = type_name; 
}

function clearTable(table) {
    //clear table except the two rows on top which are the titles and details    
    for (i = table.rows.length - 1; i >= 1; i--) {
        table.deleteRow(table.rows.length - 1);
    }
}

function updateReceipt() {    
    var table = document.getElementById("receipt_table");
    clearTable(table);

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
        price.innerHTML = "€"+(receipt.items[i].price * receipt.items[i].qty).toFixed(2);
        qty.innerHTML = receipt.items[i].qty;
    }

    if (document.getElementById("ReceiptContents")) {
        document.getElementById("ReceiptContents").value = JSON.stringify(receipt.items);
    }
}

function updateTotalPrice() {
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    //add up to total price
    var total = 0;
    for (i = 0; i < receipt.items.length; i++) {
        total += receipt.items[i].price * receipt.items[i].qty;
    }
    document.getElementById("total_price").innerHTML = "€" + total.toFixed(2);
    if (document.getElementById("Total"))document.getElementById("Total").value = total.toFixed(2);
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

function openModal() {
    //First we check if the item's quantity is more than 1. If it is, we bring up the modal,
    //otherwise, we just remove the item from the receipt

    //getting the selected row to receive the selected item_id
    var item_id = parseInt(document.getElementById("receipt_table").rows.namedItem("active").cells[0].innerHTML);

    //receiving the recept from the local storage
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    if (receipt.quantityIsMoreThanOne(item_id)) {
        /*MODAL BELOW */
        // Get the modal
        var modal = document.getElementById("myModal");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("close")[0];

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = "none";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }

        modal.style.display = "block";
        document.getElementById("numberToDelete").value = receipt.getQuantity(item_id);
        document.getElementById("numberToDelete").setAttribute("max", receipt.getQuantity(item_id));
    } else {
        deleteSelectedFromReceipt()
    }
}

function deleteSelectedFromReceipt() {

    //getting the selected row to receive the selected item_id
    var item_id = parseInt(document.getElementById("receipt_table").rows.namedItem("active").cells[0].innerHTML);

    //receiving the recept from the local storage
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    //check how many items to delete(if the items are more than 1)
    var numberToDelete = parseInt(document.getElementById("numberToDelete").value);
    if (numberToDelete) {
        receipt.deleteMultiple(item_id, numberToDelete);
        document.getElementById("myModal").style.display = "none";
    } else {
        receipt.deleteItem(item_id);
    }

    //saving receipt on localstorage
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

function getTotalPrice() {
    let receipt = new Receipt(JSON.parse(localStorage.getItem("receipt")));

    return receipt.getTotalPrice();
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
            if (document.getElementById("removeBtn"))
                document.getElementById("removeBtn").style.visibility = "visible";
            return;
        }

    }
    //hide 'remove' button
    if (document.getElementById("removeBtn"))
        document.getElementById("removeBtn").style.visibility = "hidden";
});

function openModalForCash() {
    /*MODAL BELOW */
    // Get the modal
    var modal = document.getElementById("myModal");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        modal.style.display = "none";
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }

    modal.style.display = "block";
    selectPaymentMethod("CASH");
}

function selectPaymentMethod(paymentMethod) {
    document.getElementById("PaymentMethod").value = paymentMethod;
    if (paymentMethod != "CASH")
        document.getElementById("submit").click();
}