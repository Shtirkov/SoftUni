function largestNumber(num1, num2, num3){
    let biggestNumber;

    if(num1 > num2 && num1 > num3){
        biggestNumber= num1;
    }
    else if(num2 > num1 && num2 > num3){
        biggestNumber = num2;
    }
    else{
        biggestNumber = num3;
    }

    console.log(`The largest number is ${biggestNumber}.`);
};

largestNumber(-3, -5, -22.5);