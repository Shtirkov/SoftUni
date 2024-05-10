function isMagic(matrix) {
    const magicSum = matrix[0].reduce((accumulator, value) => accumulator + value);

    const rowsSum = matrix.reduce((accumulator, row) => {
        accumulator.push(row.reduce((sum, value) => sum += value))
        return accumulator;
    }, [])

    const colsSum = matrix.reduce((accumulator, row) => {
        row.forEach((value, index) => {
            accumulator[index] = (accumulator[index] || 0) + value;
        });
        return accumulator;
    }, []);

    const rowsAreEquivalent = rowsSum.every((value) => value == magicSum);
    const colsAreEquivalent = colsSum.every((value) => value == magicSum);

    if (rowsAreEquivalent && colsAreEquivalent) {
        return true;
    }
    return false;
}

// isMagic([[4, 5, 6],
// [6, 5, 4],
// [5, 5, 5]
// ]);

isMagic([[0, 1, 2],
[3],
[0, 2, 1, 0, 0]
]);

// isMagic([[11, 32, 45],
// [21, 0, 1],
// [21, 1, 1]
// ]);

// isMagic([[1, 0, 0],
// [0, 0, 1],
// [0, 1, 0]
// ]);