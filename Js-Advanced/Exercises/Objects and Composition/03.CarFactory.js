function carFactory(carSpecifications) {
    const car = {
        model: carSpecifications.model
    };

    addEngine(car, carSpecifications.power);
    car.carriage = { type: carSpecifications.carriage, color: carSpecifications.color };
    carSpecifications.wheelsize % 2 == 0 ? carSpecifications.wheelsize-- : carSpecifications.wheelsize;
    car.wheels = [0, 0, 0, 0].fill(carSpecifications.wheelsize, 0, 4);

    function addEngine(car, power) {
        if (power <= 90) {
            car.engine = { power: 90, volume: 1800 }
        } else if (power > 90 && power <= 120) {
            car.engine = { power: 120, volume: 2400 }
        } else {
            car.engine = { power: 200, volume: 3500 }
        }

        return car;
    }

    return car;
}

console.log(carFactory({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}
));