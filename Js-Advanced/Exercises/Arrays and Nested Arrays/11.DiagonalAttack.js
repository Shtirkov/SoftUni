function diagonalAttack(input) {
    const matrix = input.map((row) => row.split(' ').map((el) => Number(el)));

    let firstDiagonal = 0;
    let secondDiagonal = 0;

    for (let row = 0; row < matrix.length; row++) {
        firstDiagonal += matrix[row][row];
        secondDiagonal += matrix[row][matrix[row].length - (row + 1)];
    }

    if (firstDiagonal == secondDiagonal) {
        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                if (row != col && col != matrix[row].length - (row + 1)) {
                    matrix[row][col] = firstDiagonal;
                }
            }
        }
    }
    matrix.forEach(row => console.log(row.join(' ')));
}

diagonalAttack(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']
);

diagonalAttack(['1 1 1',
    '1 1 1',
    '1 1 0']
);  