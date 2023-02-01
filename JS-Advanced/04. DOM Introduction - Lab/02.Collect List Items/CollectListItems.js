function extractText() {
   const elements = document.getElementById('items').children;
   const textBox = document.getElementById('result');

//    const elementsArr =  Array.from(elements);
//    elementsArr.forEach(el => {
//        const textToAppend = el.textContent;
//        textBox.textContent += textToAppend + '\n';
//});

const result = Array.from(elements).map(el => el.textContent).join('\n');
      textBox.value = result;
}