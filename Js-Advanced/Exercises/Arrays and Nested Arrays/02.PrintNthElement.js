function printNthElement(strings, step) {
    const output = [];

    for (let i = 0; i < strings.length; i += step) {
        output.push(strings[i]);
    }

    return output;
}

console.log(printNthElement(['5',
    '20',
    '31',
    '4',
    '20'],
    2
));

console.log(printNthElement(['dsa',
    'asd',
    'test',
    'tset'],
    2
));

console.log(printNthElement(['1',
    '2',
    '3',
    '4',
    '5'],
    6
));