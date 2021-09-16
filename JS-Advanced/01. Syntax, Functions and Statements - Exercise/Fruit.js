function calculatePrice(fruit, weight, pricePerKg){
let requiredSum = weight / 1000 * pricePerKg;
console.log(`I need $${requiredSum.toFixed(2)} to buy ${(weight / 1000).toFixed(2)} kilograms ${fruit}.`)
}

calculatePrice('apple', 1563, 2.35);