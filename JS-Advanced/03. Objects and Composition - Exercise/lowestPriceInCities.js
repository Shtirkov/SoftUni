function prices(data){
    const result = {};

for (const entry of data) {        
    const [town, product, price] = entry.split(' | ');
  
    if (result[product] == undefined) {
        result[product] = {};
    }
    result[product][town] = Number(price);
}
let products = Object.entries(result);

for (const product of products) {
    let sorted = Object.entries(product[1]).sort((a,b) => a[1] - b[1]);
    console.log(`${product[0]} -> ${sorted[0][1]} (${sorted[0][0]})`);
}
}

prices(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);