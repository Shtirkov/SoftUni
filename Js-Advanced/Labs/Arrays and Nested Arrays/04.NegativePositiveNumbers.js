function negativePositive(numbers) {
    const reordered = [];
    for (const number of numbers) {
        number < 0 ? reordered.unshift(number) : reordered.push(number);
    }

    console.log(reordered.join('\n'));
}

negativePositive([7, -2, 8, 9]);
negativePositive([3, -2, 0, -1]);