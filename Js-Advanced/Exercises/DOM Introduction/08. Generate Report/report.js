function generateReport() {
    const checkBoxes = document.querySelectorAll('tr input[type="checkbox"');
    const tableRows = document.querySelectorAll('tbody tr');
    const outputArea = document.getElementById('output');
    const indexes = [];
    const output = [];

    checkBoxes.forEach((checkbox, index) => {
        if (checkbox.checked) {
            indexes.push(index);
        }
    });

    tableRows.forEach(row => {
        const rowObject = {};

        indexes.forEach(index => {
            const headerName = [...checkBoxes][index].name;
            const value = row.children[index].textContent;
            rowObject[headerName] = value;
        })

        output.push(rowObject);
    })

    outputArea.textContent = JSON.stringify(output, null, 4);
}