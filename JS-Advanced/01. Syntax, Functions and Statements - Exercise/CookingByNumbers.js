function calculateNumber(num, op1, op2, op3, op4, op5){
    let operations = [op1, op2, op3, op4, op5];

    operations.forEach(o => {
        switch (o) {
            case 'chop':num /= 2;                
                break;
            case 'dice': num = Math.sqrt(num);
                break;
            case 'spice':num += 1;                
                break;
            case 'bake': num *= 3;                
                break;
            case 'fillet': num = num - num * 0.2;                
                break;
            default:
                break;
        }
        console.log(num);        
    });
}

calculateNumber('9', 'dice', 'spice', 'chop', 'bake', 'fillet');