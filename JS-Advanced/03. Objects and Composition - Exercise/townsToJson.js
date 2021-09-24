function towns(arr){
    const result = [];
    const splitted = arr[0].split('|');
    const town = splitted[1].trim();
    const latitude = splitted[2].trim();   
    const longitude = splitted[3].trim();

   for (let i = 1; i < arr.length; i++) {
    const objToAdd = {};

    let splittedRow = arr[i].split('|');
    const currentTown = splittedRow[1].trim();
    let currentLatitude = splittedRow[2].trim();
    let currentLongitude = splittedRow[3].trim();
    objToAdd[town] = currentTown;
    objToAdd[latitude] = Number(Number(currentLatitude).toFixed(2));
    objToAdd[longitude] = Number(Number(currentLongitude).toFixed(2));

    result.push(objToAdd);
   }

   return JSON.stringify(result);
}

console.log(towns(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
));