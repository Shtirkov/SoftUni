function parseTowns(input) {
    const output = [];

    for (let i = 1; i < input.length; i++) {
        const tokens = input[i].split(' | ');
        const town = tokens[0].slice(2);
        const latitude = +tokens[1];
        const longitude = +tokens[2].slice(0, tokens[2].length - 2);

        const currentTown = {
            Town: town,
            Latitude: +latitude.toFixed(2),
            Longitude: +longitude.toFixed(2)
        }
        output.push(currentTown);
    }

    console.log(JSON.stringify(output));
}

parseTowns(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
);