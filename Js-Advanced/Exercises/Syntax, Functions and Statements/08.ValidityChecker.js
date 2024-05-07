function checkValidity(x1, y1, x2, y2) {
    const firstCoordinate = Math.sqrt((0 - x1) ** 2 + (0 - y1) ** 2); // {x1,y1} {0,0}
    const secondCoordinate = Math.sqrt((x2 - 0) ** 2 + (y2 - 0) ** 2); // {x2,y2} {0,0}
    const thirdCoordinate = Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2); // {x1,y1} {x2,y2}

    if (Number.isInteger(firstCoordinate)) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`)
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`)
    }

    if (Number.isInteger(secondCoordinate)) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`)
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`)
    }

    if (Number.isInteger(thirdCoordinate)) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`)
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`)
    }
}

checkValidity(3, 0, 0, 4);
checkValidity(2, 1, 1, 1);