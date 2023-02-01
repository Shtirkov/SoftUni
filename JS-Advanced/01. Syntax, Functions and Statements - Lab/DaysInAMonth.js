function numberOfDaysInAMonth(month, year){
    let result = new Date(year, month, 0).getDate();
    console.log(result);
};

numberOfDaysInAMonth(2, '2008');