function getDate(year, month, day){
let inputDate = new Date(year, month-1, day);
let previousDate = new Date(inputDate);
previousDate.setDate(previousDate.getDate()-1);

console.log(`${previousDate.getFullYear()}-${previousDate.getMonth()+1}-${previousDate.getDate()}`);
}

getDate(2016, 9, 30);