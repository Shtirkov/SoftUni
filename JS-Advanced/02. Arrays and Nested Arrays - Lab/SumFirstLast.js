function solve(array){
const firstNum = Number(array[0]);
const secondNum = Number(array[array.length-1]);

return firstNum + secondNum;
}

function solveSecondWay(array){
    const firstNum = Number(array.shift());
    const secondNum = Number(array.pop());
    
    return firstNum + secondNum;
}

console.log(solve2(['5', '10']));