function produceCar(carRequirements){
    const car = {};
    let color = '';

    for (const entry in carRequirements) {
       const requirement = entry;
       let value = carRequirements[entry];
        if (requirement == 'model') {
            car[requirement] = value;
        }else if(requirement == 'power'){
            if (value <= 90) {
                car.engine = {
                    power: 90,
                    volume: 1800
                }
            }else if(value > 90 && value <= 120){
                car.engine = {
                    power: 120,
                    volume: 2400
                }
            }else if(value > 120){
                car.engine = {
                    power: 200,
                    volume: 3500
                }
            }
        }else if(requirement == 'color'){
            color = value;
        }
        else if(requirement == 'carriage'){
            if (value == 'hatchback') {
                car.carriage = {
                    type: 'hatchback',
                    color: color
                }
            } else if(value == 'coupe') {
                car.carriage = {
                    type: 'coupe',
                    color: color
                }
            }
        }else if (requirement == 'wheelsize'){
            if (value % 2 == 0) {
                value--;
            }

            const arr = [value, value, value, value];

            car.wheels = arr;
        }
    }

    return car;
}


console.log(produceCar({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
));




