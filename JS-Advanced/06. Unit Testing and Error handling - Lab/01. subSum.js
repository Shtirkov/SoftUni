function sum(numbers, startIndex, endIndex){
    
    if (!Array.isArray(numbers)) {
        return NaN;
    }

    let sum = 0;

    if (startIndex < 0) {
        startIndex = 0;
    }

    if (endIndex > numbers.length - 1) {
        endIndex = numbers.length - 1;
    }

    for (let i = startIndex; i <= endIndex; i++) {        
        sum+=Number(numbers[i]);
    }

    return sum;
}

console.log(sum([10, 20, 30, 40, 50, 60], 3, 300));
console.log(sum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));
console.log(sum([10, 'twenty', 30, 40], 0, 2));
console.log(sum([], 1, 2));
console.log(sum('text', 0, 2));
