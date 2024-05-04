function calculateCircleArea(r) {
    if (typeof (r) != 'number') {
        console.log(`We can not calculate the circle area, because we receive a ${typeof (r)}.`)
    } else {
        console.log((Math.PI * r ** 2).toFixed(2));
    }
}

calculateCircleArea(5);
calculateCircleArea('5');
calculateCircleArea('name');
