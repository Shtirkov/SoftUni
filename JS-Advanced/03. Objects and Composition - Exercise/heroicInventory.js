function register(heroes){
    const result = [];
    for (const entry of heroes) {
        const record = {};
        const [name, level, items] = entry.split(' / ');
        record.name = name,
        record.level = Number(level)
        record.items = items ? items.split(', ') : [];

        result.push(record);
    }

    return JSON.stringify(result);
}

console.log(register(['Isacc / 25',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
));