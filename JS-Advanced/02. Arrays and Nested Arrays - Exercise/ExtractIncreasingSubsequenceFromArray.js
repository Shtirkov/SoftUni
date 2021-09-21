function solve(arr){
let number = Number.MIN_SAFE_INTEGER;
let result = [];

arr.forEach(x => {
    if (x >= number) {
        result.push(x);
        number = x;
    }
})

return result;
}

solve([20, 
    3, 
    2, 
    15,
    6, 
    1]
    );