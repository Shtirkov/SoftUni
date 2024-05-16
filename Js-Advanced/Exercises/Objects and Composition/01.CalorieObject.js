function calorieObject(elements) {
    const result = {};

    for (let i = 0; i < elements.length - 1; i += 2) {
        const food = elements[i];
        const calories = Number(elements[i + 1]);
        result[food] = calories;
    }

    console.log(result);
}

calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);