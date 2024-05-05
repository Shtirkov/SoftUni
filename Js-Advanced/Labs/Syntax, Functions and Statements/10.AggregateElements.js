function aggregate(numsArr) {
    let sum = 0
    let inverseSum = 0;
    let concatenated = "";

    for (let i = 0; i < numsArr.length; i++) {
        sum += numsArr[i];
        inverseSum += 1 / numsArr[i];
        concatenated += numsArr[i];
    }

    console.log(sum);
    console.log(inverseSum);
    console.log(concatenated);
}

aggregate([1, 2, 3]);
aggregate([2, 4, 8, 16]);