function extract(content) {
const elementText = document.getElementById(content).textContent;
const regex = /\((.+?)\)/g;
 let match = regex.exec(elementText);
 let result = '';

 while (match !=null) {
     result+=`${match[1]}; `;
     match = regex.exec(elementText);
 }

return result.trimEnd();
}