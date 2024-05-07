function isSpeedExceeded(speed, area) {
    const motorwaySpeedLimit = 130;
    const interstateSpeedLimit = 90;
    const citySpeedLimit = 50;
    const residentialSpeedLimit = 20;
    let allowedSpeed = 0;

    switch (area) {
        case 'motorway': allowedSpeed = motorwaySpeedLimit;
            break;
        case 'interstate': allowedSpeed = interstateSpeedLimit;
            break;
        case 'city': allowedSpeed = citySpeedLimit;
            break;
        case 'residential': allowedSpeed = residentialSpeedLimit;
            break;
    }

    const exceededSpeed = speed - allowedSpeed;

    if (exceededSpeed > 0 && exceededSpeed <= 20) {
        console.log(`The speed is ${exceededSpeed} km/h faster than the allowed speed of ${allowedSpeed} - speeding`);
    } else if (exceededSpeed > 20 && exceededSpeed <= 40) {
        console.log(`The speed is ${exceededSpeed} km/h faster than the allowed speed of ${allowedSpeed} - excessive speeding`);
    } else if (exceededSpeed > 40) {
        console.log(`The speed is ${exceededSpeed} km/h faster than the allowed speed of ${allowedSpeed} - reckless driving`);
    } else {
        console.log(`Driving ${speed} km/h in a ${allowedSpeed} zone`);
    }
}

isSpeedExceeded(40, 'city');
isSpeedExceeded(21, 'residential');
isSpeedExceeded(120, 'interstate');
isSpeedExceeded(200, 'motorway');