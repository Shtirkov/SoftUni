function solve(arr, numberOfRotations){
for (let i = 0; i < numberOfRotations; i++) {
arr.unshift(arr.pop());
}
console.log(arr.join(' '));
}

solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
);