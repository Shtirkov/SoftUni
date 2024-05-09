function sortNumbers(numbersList) {
    const result = [];
    numbersList.sort((a, b) => a - b);

    while (numbersList.length) {
        result.push(numbersList.shift());
        result.push(numbersList.pop());
    }

    return result;
}

console.log(sortNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));