function createObject(input){

    const result = {};

    for(let i =0; i < input.length; i+= 2){
        let food = input[i];
        let calories = Number(input[i+1]);

        result[food] = calories;
    }

    console.log(result);    
}

solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);