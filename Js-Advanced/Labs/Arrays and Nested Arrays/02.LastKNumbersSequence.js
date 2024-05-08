function sequence(arrLength, numbersToAdd) {
    const arr = [1];

    for (let i = 0; i < arrLength - 1; i++) {
        const startIndex = arr.length - numbersToAdd < 0 ? 0 : arr.length - numbersToAdd;
        const endIndex = i + 1;
        const valueToAdd = arr.slice(startIndex, endIndex)
            .reduce((a, c) => a + c, 0);
        arr.push(valueToAdd);
    }

    return arr;
}

console.log(sequence(6, 3));
console.log(sequence(8, 2));