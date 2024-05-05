function printRectangle(size = 5) {
    let output = "";
    for (let i = 0; i < size; i++) {
        for (let k = 0; k < size; k++) {
            output += '* ';
        }
        output += '\n';
    }
    return output.trim();
}

console.log(printRectangle());