function getPreviousDate(year, month, day) {
    let currentDate = new Date(year, month - 1, day); // we subtract 1 from the month because the months in js are represent with indexes
    let previoutDate = new Date(currentDate.setDate(day - 1));

    console.log(`${previoutDate.getFullYear()}-${previoutDate.getMonth() + 1}-${previoutDate.getDate()}`);
}

getPreviousDate(2016, 9, 30);
getPreviousDate(2016, 10, 1);