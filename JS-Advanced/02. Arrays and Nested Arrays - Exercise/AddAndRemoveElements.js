function solve(commands){
let number = 1;
let result = [];

commands.forEach((x) => {
    if(x == 'add'){
        result.push(number);
    }else{
        result.pop();
    }
    number++;
})

if (result.length == 0) {
    console.log('Empty');
}else{
    console.log(result.join('\n'));
}
}

solve(['add', 
'add', 
'remove', 
'add', 
'add']
);