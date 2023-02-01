function addItem() {
   const textBox = document.getElementById('newItemText');
   const inputText = textBox.value;
   const element = document.createElement('li');
   element.textContent = inputText;
   const ul = document.getElementById('items');
   ul.appendChild(element);
   textBox.value = '';
}