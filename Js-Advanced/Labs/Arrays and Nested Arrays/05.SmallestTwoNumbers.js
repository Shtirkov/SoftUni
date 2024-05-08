function smallestNumbers(numbers) {

    console.log(numbers
        .sort((a, b) => a - b)
        .slice(0, 2)
        .join(' '));
}

smallestNumbers([30, 15, 50, 5]);
smallestNumbers([3, 0, 10, 4, 7, 3]);