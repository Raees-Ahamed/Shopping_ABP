function AddToCart() {

    var table = document.getElementById("CartTable");

    var ProductId = document.getElementById("ProductId").value;
    var Description = document.getElementById("Description").value;
    var Price = document.getElementById("Price").value;
    var Qty = document.getElementById("Quantity").value;

    var productId = document.createElement("input");
    productId.setAttribute("type", "text");
    productId.setAttribute("class", "form-control");   

    var productDescription = document.createElement("input");
    productDescription.setAttribute("type", "text");
    productDescription.setAttribute("class", "form-control");    

    var productUnitPrice = document.createElement("input");
    productUnitPrice.setAttribute("type", "text");
    productUnitPrice.setAttribute("class", "form-control");   

    var productQty = document.createElement("input");
    productQty.setAttribute("type", "number");
    productQty.setAttribute("class", "form-control");
    productQty.setAttribute("min", "0");

    var btn = document.createElement("input");
    btn.setAttribute("type", "button");
    btn.setAttribute("class", "btn btn-danger");
    btn.setAttribute("value", "Delete");

    productId.value = ProductId;
    productDescription.value = Description;
    productUnitPrice.value = Price;
    productQty.value = Qty;

    var row = table.insertRow(1);

    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);
    var cell6 = row.insertCell(5);

    cell1.appendChild(productId);
    cell2.appendChild(productDescription);
    cell3.appendChild(productUnitPrice);
    cell4.appendChild(productQty);
    cell5.innerHTML = subTotal;
    cell6.appendChild(btn);

}