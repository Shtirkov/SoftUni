function solve(array, firstPie, secondPie){
let newArr = [];
const firstIndex = array.indexOf(firstPie);
const secondIndex = array.indexOf(secondPie) + 1;

newArr = array.slice(firstIndex, secondIndex);

return newArr;
}

console.log(solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
));