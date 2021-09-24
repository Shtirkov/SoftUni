function sort(products){
const result = {};

for (const product of products) {
    const [name, price] = product.split(' : ');
   const parsedPrice = Number(price);
    const key = name[0];

    if (result[key] == undefined) {
        result[key] = [];
    }

    result[key][name] = parsedPrice;
}

const initialSort = Object.keys(result).sort((a,b) => a.localeCompare(b));

for (const key of initialSort) {
    let sorted = Object.entries(result[key]).sort((a,b) => a[0].localeCompare(b[0]));
    console.log(`${key}`);
    
    sorted.forEach((el) => console.log(`  ${el[0]}: ${el[1]}`));
}
}

sort(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
);