function equalNeighbours(matrix) {
    let pairs = 0;
    let pairsIncremented = false;

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {
            const previousElement = matrix[row][col - 1];
            const currentElement = matrix[row][col];
            const nextElement = matrix[row][col + 1];
            let elementAbove = '';
            let elementBelow = '';

            if (row > 0) {
                elementAbove = matrix[row - 1][col];
            }

            if (row != matrix.length - 1) {
                elementBelow = matrix[row + 1][col];
            }

            if (currentElement === previousElement) {
                pairs++;
                pairsIncremented = true;
            }
            if (currentElement === nextElement) {
                pairs++;
                pairsIncremented = true;
            }
            if (currentElement === elementAbove) {
                pairs++;
                pairsIncremented = true;
            }
            if (currentElement === elementBelow) {
                pairs++;
                pairsIncremented = true;
            }

            if (pairsIncremented) {
                matrix[row][col] = '';
                pairsIncremented = false;
            }
        }
    }
    return pairs;
}

// console.log(equalNeighbours([['2', '3', '4', '7', '0'],
// ['4', '0', '5', '3', '4'],
// ['2', '3', '5', '4', '2'],
// ['9', '8', '7', '5', '4']]
// ));

// console.log(equalNeighbours([['test', 'yes', 'yo', 'ho'],
// ['well', 'done', 'yo', '6'],
// ['not', 'done', 'yet', '5']]
// ));

// console.log(equalNeighbours([[2, 2, 5, 7, 4], [4, 0, 5, 3, 4], [2, 5, 5, 4, 2]]))

console.log(equalNeighbours([[2, 2]]))