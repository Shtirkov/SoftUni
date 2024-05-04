function calculate(firstNum, secondNum, operation) {
    let result;

    if (operation == '+') {
        result = firstNum + secondNum;
    } else if (operation == '-') {
        result = firstNum - secondNum;
    } else if (operation == '*') {
        result = firstNum * secondNum;
    } else if (operation == '/') {
        result = firstNum / secondNum;
    }
    else if (operation == '%') {
        result = firstNum % secondNum;
    }
    else if (operation == '**') {
        result = firstNum ** secondNum;
    }

    console.log(result);
}

calculate(5, 6, '+');
calculate(3, 5.5, '*');