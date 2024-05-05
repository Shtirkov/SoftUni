function getDaysInMonth(month, year) {
    return new Date(year, month, 0).getDate();
}

getDaysInMonth(2, 2021);