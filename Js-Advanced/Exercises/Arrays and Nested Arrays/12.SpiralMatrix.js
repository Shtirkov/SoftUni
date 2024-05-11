function spiralMatrix(rows, cols) {
    const matrix = [];
    let direction = 'right';
    let current = 1;
    let currentRowIndex = 0;
    let currentColIndex = 0;

    for (let i = 0; i < rows; i++) {
        matrix.push(Array(cols).fill('a'));
    }

    for (let row = 0; row < rows * cols; row++) {

        while (currentRowIndex < rows && currentColIndex < cols && matrix[currentRowIndex][currentColIndex] == 'a') {
            switch (direction) {
                case 'right':
                    matrix[currentRowIndex][currentColIndex] = current;
                    currentColIndex++;
                    break;
                case 'down':
                    matrix[currentRowIndex][currentColIndex] = current;
                    currentRowIndex++;
                    break;
                case 'left':
                    matrix[currentRowIndex][currentColIndex] = current;
                    currentColIndex--;
                    break;
                case 'up':
                    matrix[currentRowIndex][currentColIndex] = current;
                    currentRowIndex--;
                    break;
            }
            current++;
        }

        switch (direction) {
            case 'right':
                direction = 'down';
                currentRowIndex++;
                currentColIndex--;
                break;
            case 'down':
                direction = 'left';
                currentRowIndex--;
                currentColIndex--;
                break;
            case 'left':
                direction = 'up';
                currentRowIndex--;
                currentColIndex++;
                break;
            case 'up':
                direction = 'right';
                currentRowIndex++;
                currentColIndex++;
                break;
        }
    }

    matrix.forEach(row => console.log(row.join(' ')));
}

spiralMatrix(5, 5);
spiralMatrix(3, 3);