function sumFirstAndLast(numbers) {
    return Number(numbers.shift()) + Number(numbers.pop());
}

console.log(sumFirstAndLast(['20', '30', '40']));
console.log(sumFirstAndLast(['5', '10']));