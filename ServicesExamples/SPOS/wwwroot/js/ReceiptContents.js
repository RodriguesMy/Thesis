
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

    increaseQuantity(id, qty) {
        var index = this.items.findIndex(x => parseInt(x.id) === id);
        if(qty == null)
            this.items[index].qty = this.items[index].qty + 1;
        else
            this.items[index].qty = this.items[index].qty + qty;
    }

    deleteItem(id) {
        var index = this.items.findIndex(x => parseInt(x.id) === id);
        this.items.splice(index, 1);
    }

    quantityIsMoreThanOne(id) {
        var index = this.items.findIndex(x => parseInt(x.id) === id);
        if (this.items[index].qty > 1) return true;
        return false;
    }

    getQuantity(id) {
        var index = this.items.findIndex(x => parseInt(x.id) === id);
        return this.items[index].qty;

    }

    deleteMultiple(id, totalToDelete) {
        var index = this.items.findIndex(x => parseInt(x.id) === id);
        this.items[index].qty = this.items[index].qty - totalToDelete;

        if (this.items[index].qty <= 0) this.deleteItem(id);
    }

    getTotalPrice() {
        var total = 0;
        for (i = 0; i < this.items.length; i++) {
            total += this.items[i].price * this.items[i].qty;
        }
        return total;
    }

    deleteOneItem(id) {
        var index = this.items.findIndex(x => parseInt(x.id) === id);
        if (this.quantityIsMoreThanOne(id)) {
            this.items[index].qty = this.items[index].qty - 1;
        } else {
            this.deleteItem(id);
        }
    }
}