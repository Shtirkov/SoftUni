function oddPositions(numbers) {
    console.log(numbers
        .filter((value, index) => index % 2 != 0)
        .map(number => number * 2)
        .reverse()
        .join(' '));
}

oddPositions([10, 15, 20, 25]);
oddPositions([3, 0, 10, 4, 7, 3]);