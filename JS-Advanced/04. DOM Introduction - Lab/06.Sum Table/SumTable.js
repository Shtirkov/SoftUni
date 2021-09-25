function sumTable() {
const elements = document.querySelectorAll('tbody tr');
let sum = 0;

for (let i = 1; i < elements.length - 1; i++) {
    sum += Number(elements[i].cells[1].textContent);    
}

document.getElementById('sum').textContent = sum;
}