function solve(array){
const firstSmallestNum = Math.min(...array);

const indexToRemove = array.indexOf(firstSmallestNum);
array.splice(indexToRemove, 1);

const secondSmallestNum = Math.min(...array);
console.log(`${firstSmallestNum} ${secondSmallestNum}`);
}

solve([3, 0, 10, 4, 7, 3]);