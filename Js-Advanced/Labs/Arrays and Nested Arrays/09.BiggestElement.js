function findBiggestElement(numbers) {
    let biggest = Number.MIN_SAFE_INTEGER;

    for (let row = 0; row < numbers.length; row++) {
        for (let col = 0; col < numbers[row].length; col++) {
            const current = numbers[row][col];

            if (current > biggest) {
                biggest = current;
            }
        }
    }

    return biggest;
}

console.log(findBiggestElement([[20, 50, 10],
[8, 33, 145]]
));

console.log(findBiggestElement([[3, 5, 7, 12],
[-1, 4, 33, 2],
[8, 3, 0, 4]]
));