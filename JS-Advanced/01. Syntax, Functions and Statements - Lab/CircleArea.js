function calculateCircleArea(r){
if(typeof(r) === 'number'){
    let circleArea = r ** 2 * Math.PI;
console.log(Math.round(circleArea * 100) / 100);
}else{
    console.log(`We can not calculate the circle area, because we receive a ${typeof(r)}.`)
}
};

calculateCircleArea('name');