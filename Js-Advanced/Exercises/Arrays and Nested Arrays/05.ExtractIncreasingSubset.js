function extractSubset(numbers) {
    let biggest = Number.MIN_SAFE_INTEGER;
    return numbers.filter(number => {
        if (number >= biggest) {
            biggest = number;
            return true;
        }
        return false;
    });
}

console.log(extractSubset([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]
));

console.log(extractSubset([1,
    2,
    3,
    4]
));

console.log(extractSubset([20,
    3,
    2,
    15,
    6,
    1]
));
