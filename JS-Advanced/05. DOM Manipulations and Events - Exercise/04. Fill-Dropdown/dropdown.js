function addItem() {
    const select = document.createElement('select')
    select.id = 'menu';  
      
        const text = document.getElementById('newItemText').value;
        const value = document.getElementById('newItemValue').value;
        if (text != '' && value != '') {
            const option = document.createElement('option');
            option.textContent = text;
            option.value = value;
            document.getElementById('menu').appendChild(option);
            document.getElementById('newItemText').value = '';
            document.getElementById('newItemValue').value = '';
        
    }
}