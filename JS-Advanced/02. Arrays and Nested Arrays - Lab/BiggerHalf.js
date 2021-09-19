function solve(array){
array.sort((a, b) => a-b);
const newArr = array.splice(0, array.length / 2);

if (newArr.length == array.length) {
    console.log(newArr);
}else{
    console.log(array);
}
}

solve([3, 19, 14, 7, 2, 19, 6]);

