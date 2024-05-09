function extractSubset(numbers) {
    const output = [numbers[0]];

    for (let i = 1; i < numbers.length; i++) {

        if (numbers[i] >= output[output.length - 1]) {
            output.push(numbers[i]);
        }
    }

    return output;
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
