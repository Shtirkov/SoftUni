function catalogue(products) {
    const catalogue = {};
    const orderedProducts = products.sort((a, b) => a.localeCompare(b));

    for (const entry of orderedProducts) {
        const [product, price] = entry.split(' : ')
        const key = product[0];

        if (!Object.hasOwn(catalogue, key)) {
            catalogue[key] = [];
        }

        catalogue[key].push(product + ': ' + price);
    }

    for (const group in catalogue) {
        console.log(group);
        catalogue[group].forEach(p => console.log(`  ${p}`));
    }
}

catalogue(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
);