function rotateArray(strings, rotationsCount) {
    for (let i = 0; i < rotationsCount; i++) {
        strings.unshift(strings.pop());
    }

    console.log(strings.join(' '));
}

rotateArray(['1',
    '2',
    '3',
    '4'],
    2
);

rotateArray(['Banana',
    'Orange',
    'Coconut',
    'Apple'],
    15
);