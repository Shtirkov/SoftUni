function isMonodigit(number) {

    let splitted = number.toString().split('');
    let isMonodigit = true;
    let sum = 0;
    let temp = splitted[0];

    for (const digit of splitted) {
        sum += Number(digit);

        if (temp != digit) {
            isMonodigit = false;
        }

        temp = digit;
    }

    console.log(isMonodigit);
    console.log(sum);
}

isMonodigit(2222222);
isMonodigit(1234);