function calculateDiagonalSums(numbers) {
    let firstDiagonal = 0;
    let secondDiagonal = 0;

    for (let row = 0; row < numbers.length; row++) {
        firstDiagonal += numbers[row][row];
        secondDiagonal += numbers[row][numbers[row].length - (row + 1)];
    }

    console.log(`${firstDiagonal} ${secondDiagonal}`);
}

calculateDiagonalSums([[20, 40], [10, 60]]);
calculateDiagonalSums([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);