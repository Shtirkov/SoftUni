function solve(matrix){
let firstDiagonal = 0;
let secondDiagonal = 0;

for (let i = 0; i < matrix.length; i++) {
    for (let k = 0; k < matrix[i].length; k++) {
        if (i == k) {
            firstDiagonal += matrix[i][k];
        }        
    }    
}

for (let i = 0; i < matrix.length; i++) {
    for (let k = 0; k < matrix[i].length; k ++) {
       if (i + k == matrix.length - 1) {
          secondDiagonal += matrix[i][k];
       }
    }    
}

console.log(`${firstDiagonal} ${secondDiagonal}`);
}

solve([[3, 5, 17],
 [-1, 7, 14],
 [1, -8, 89]]

   );