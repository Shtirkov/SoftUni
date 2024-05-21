function extractText() {
    const listItems = document.querySelectorAll('#items li');
    const outputArea = document.getElementById('result');

    [...listItems].forEach(item => {
        outputArea.textContent += item.textContent;
        outputArea.textContent += '\n'
    })
}