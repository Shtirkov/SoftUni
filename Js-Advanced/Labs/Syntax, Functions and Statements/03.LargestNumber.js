function printLargestNumber(firstNum, secondNum, thirdNum) {
    let largestNumber;

    if (firstNum > secondNum && firstNum > thirdNum) {
        largestNumber = firstNum;
    } else if (secondNum > firstNum && secondNum > thirdNum) {
        largestNumber = secondNum;
    } else {
        largestNumber = thirdNum;
    }

    console.log(`The largest number is ${largestNumber}.`);
}

printLargestNumber(1, 5, 2);