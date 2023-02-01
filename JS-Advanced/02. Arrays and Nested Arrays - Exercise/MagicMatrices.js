function solve(matrix){
let initialSumRow = 0;
let initialSumCol = 0;
let currentSumRow = 0;
let currentSumCol = 0;

for (let i = 0; i < matrix.length; i++) {
    for (let k = 0; k < matrix[i].length; k++) {
        if (i == 0) {
            initialSumRow+=matrix[i][k];
            initialSumCol+= matrix[k][i];
        }
        else{
            currentSumRow +=matrix[i][k];
            currentSumCol += matrix[k][i];
        }        
    }

    
    if ((currentSumRow != initialSumRow || currentSumCol != initialSumRow || currentSumRow != initialSumCol || currentSumCol != initialSumCol) && i !=0 ) {
        return false;
    }    
    currentSumRow = 0;
    currentSumCol = 0;
}
return true;
}

console.log(solve([[0,1],
    [1,0]
    
]
   
   
   ));