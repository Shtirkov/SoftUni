function sum(a, b) {
    let result = 0;
    let firstNum = Number(a);
    let secondNum = Number(b);

    for (let i = firstNum; i <= secondNum; i++) {
        result += i;
    }

    return result;
}

sum('1', '5');
sum('-8', '20');