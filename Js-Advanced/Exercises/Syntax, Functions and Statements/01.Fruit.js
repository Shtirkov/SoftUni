function calculateFruitPrice(fruit, weightInGrams, pricePerKillogram) {
    let weightInKillograms = weightInGrams / 1000;
    let moneyNeeded = weightInKillograms * pricePerKillogram;

    console.log(`I need $${moneyNeeded.toFixed(2)} to buy ${weightInKillograms.toFixed(2)} kilograms ${fruit}.`);
}

calculateFruitPrice('orange', 2500, 1.80);
calculateFruitPrice('apple', 1563, 2.35);  