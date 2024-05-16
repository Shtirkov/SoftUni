function findLowestPrice(input) {
    const result = {};

    for (const entry of input) {
        const [town, product, price] = entry.split(' | ');

        if (!Object.hasOwn(result, product)) {
            result[product] = { price: Number(price), town };
        }

        if (result[product].price > Number(price)) {
            result[product] = { price: Number(price), town };
        }
    }

    for (const [product, info] of Object.entries(result)) {
        console.log(`${product} -> ${info.price} (${info.town})`)
    }
}

findLowestPrice(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']
);