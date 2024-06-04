function addItem() {
    const ulElement = document.getElementById('items');
    const liElement = document.createElement('li');
    liElement.textContent = document.getElementById('newItemText').value;
    ulElement.appendChild(liElement);
}