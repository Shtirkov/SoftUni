function addItem() {
    const textBox = document.getElementById('newItemText');
    const inputText = textBox.value;

  if (inputText.length > 0) {
    const element = document.createElement('li');
    element.textContent = inputText;

    const button = document.createElement('a');
    button.textContent = '[Delete]';
    button.href = '#';
    button.addEventListener('click',onClick);

    element.appendChild(button);
  
    document.getElementById('items').appendChild(element);  
  }  

    textBox.value = '';

    function onClick(ev){     
        ev.target.parentNode.remove();
    }
}