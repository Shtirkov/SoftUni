function speedCheck(speed, zone){
    let message;
    let status;

    switch (zone) {
        case 'motorway':
            if (speed <= 130) {
                message = `Driving ${speed} km/h in a 130 zone`
            }
            else if(speed > 130 && speed <= 150){
                status = 'speeding';
                message = `The speed is ${speed - 130} km/h faster than the allowed speed of 130 - ${status}`
            }
            else if(speed > 150 && speed <= 170){
                status = 'excessive speeding';
                message = `The speed is ${speed - 130} km/h faster than the allowed speed of 130 - ${status}`
            }
            else if(speed > 170){
                status = 'reckless driving';
                message = `The speed is ${speed - 130} km/h faster than the allowed speed of 130 - ${status}`
            }
            break;
        case 'interstate':
            if (speed <= 90) {
                message = `Driving ${speed} km/h in a 90 zone`
            }
            else if(speed > 90 && speed <= 110){
                status = 'speeding';
                message = `The speed is ${speed - 90} km/h faster than the allowed speed of 90 - ${status}`
            }
            else if(speed > 90 && speed <= 130){
                status = 'excessive speeding';
                message = `The speed is ${speed - 90} km/h faster than the allowed speed of 90 - ${status}`
            }
            else if(speed > 130){
                status = 'reckless driving';
                message = `The speed is ${speed - 90} km/h faster than the allowed speed of 90 - ${status}`
            }
            break;
        case 'city':
            if (speed <= 50) {
                message = `Driving ${speed} km/h in a 50 zone`
            }
            else if(speed > 50 && speed <= 70){
                status = 'speeding';
                message = `The speed is ${speed - 50} km/h faster than the allowed speed of 50 - ${status}`
            }
            else if(speed > 70 && speed <= 90){
                status = 'excessive speeding';
                message = `The speed is ${speed - 50} km/h faster than the allowed speed of 50 - ${status}`
            }
            else if(speed > 90){
                status = 'reckless driving';
                message = `The speed is ${speed - 50} km/h faster than the allowed speed of 50 - ${status}`
            }            
            break;
        case 'residential':
            if (speed <= 20) {
                message = `Driving ${speed} km/h in a 20 zone`
            }
            else if(speed > 20 && speed <= 40){
                status = 'speeding';
                message = `The speed is ${speed - 20} km/h faster than the allowed speed of 20 - ${status}`
            }
            else if(speed > 20 && speed <= 60){
                status = 'excessive speeding';
                message = `The speed is ${speed - 20} km/h faster than the allowed speed of 20 - ${status}`
            }
            else if(speed > 60){
                status = 'reckless driving';
                message = `The speed is ${speed - 20} km/h faster than the allowed speed of 20 - ${status}`
            }
            break;        
    }
    console.log(message);
}

speedCheck(200, 'motorway');