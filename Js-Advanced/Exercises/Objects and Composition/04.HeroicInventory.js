function heroes(input) {
    const result = [];

    input.forEach(entry => {
        const tokens = entry.split(' / ')
        const name = tokens[0];
        const level = Number(tokens[1]);
        const items = tokens[2] != undefined ? tokens[2].split(', ') : [];

        const hero = {
            name,
            level,
            items
        }

        result.push(hero);
    })

    return JSON.stringify(result);
}

console.log(heroes(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']));

console.log(heroes(['Jake / 1000 / Gauss, HolidayGrenade']));