function solve(matrix){
    let biggestNum = Number.MIN_SAFE_INTEGER;
for (let i = 0; i < matrix.length; i++) {
    for (let k = 0; k < matrix[i].length; k++) {
         if (matrix[i][k] > biggestNum) {
             biggestNum = matrix[i][k];
         }   
    }
}
return biggestNum;
}

console.log(solve([[1],
    [-2],
    [2]]
   
   
   ));