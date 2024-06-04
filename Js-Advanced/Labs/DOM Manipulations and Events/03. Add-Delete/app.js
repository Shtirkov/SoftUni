function addItem() {
    const ulElement = document.getElementById('items');
    const liElement = document.createElement('li');
    liElement.textContent = document.getElementById('newItemText').value;

    const aElement = document.createElement('a');
    aElement.textContent = '[Delete]';
    aElement.href = '#';
    aElement.addEventListener('click', (ev) => ev.target.parentNode.remove());

    liElement.appendChild(aElement);
    ulElement.appendChild(liElement);
}