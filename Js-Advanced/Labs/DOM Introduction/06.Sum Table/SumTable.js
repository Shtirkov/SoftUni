function sumTable() {
    const table = document.querySelector('table');
    const tableRows = table.querySelectorAll('tr');
    const total = document.getElementById('sum');
    let sum = 0;

    for (let i = 1; i < tableRows.length; i++) {
        sum += +tableRows[i].lastChild.textContent;
    }

    total.textContent = sum;
}