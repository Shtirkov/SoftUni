function evenPositions(numbers) {
    console.log(numbers.filter((value, index) => index % 2 == 0).join(' '));
}

evenPositions(['20', '30', '40', '50', '60']);
evenPositions(['5', '10']);