function solve(array){
console.log(array.filter((arr, i) => i % 2 == 1).reverse().map(x => x * 2).join(' '));
}

solve([3, 0, 10, 4, 7, 3]);