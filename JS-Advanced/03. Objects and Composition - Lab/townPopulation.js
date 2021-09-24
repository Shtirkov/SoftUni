function townPopulation(townsInput){
   const towns = {};

    for (const town of townsInput) {
        const[name, population] = town.split(' <-> ');

        if (towns[name]) {
            towns[name] += Number(population);
        }else{
            towns[name] = Number(population);
        }
    }
   
    for (const [name, popilation] of Object.entries(towns)) {
        console.log(`${name} : ${popilation}`);
    }
}



townPopulation(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']

);