function sortStrings(strings) {
    console.log(strings.sort((a, b) => {
        if (a.length != b.length) {
            return a.length - b.length; // If lengths are different, return the comparison result
        } else {
            return a.localeCompare(b); // If lengths are the same, compare lexicographically
        }
    }).join('\n'));
}

sortStrings(['alpha',
    'beta',
    'gamma'
]);

sortStrings(['Isacc',
    'Theodor',
    'Jack',
    'Harrison',
    'George'
]);

sortStrings(['test',
    'Deny',
    'omen',
    'Default'
]);