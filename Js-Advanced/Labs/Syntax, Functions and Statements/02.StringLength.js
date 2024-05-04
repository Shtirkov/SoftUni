function calculateInputLength(firstArg, secondArg, thirdArg) {
    let sum = firstArg.length + secondArg.length + thirdArg.length;
    console.log(sum);
    console.log(Math.floor(sum / 3));
}

calculateInputLength('asd', 'asd', 'asd')