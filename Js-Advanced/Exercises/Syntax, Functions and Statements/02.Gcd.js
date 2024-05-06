function findGreatestCommonDivisor(firstNum, secondNum) {
    while (secondNum !== 0) {
        let temp = secondNum;
        secondNum = firstNum % secondNum;
        firstNum = temp;
    }
    console.log(firstNum);
}

findGreatestCommonDivisor(15, 5);
findGreatestCommonDivisor(2154, 458);    