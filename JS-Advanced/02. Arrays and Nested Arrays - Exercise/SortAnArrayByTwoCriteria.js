    function solve(arr){
    arr.sort((a,b) => {
        if (a.length - b.length > 0) {
            return 1;
        }
        else if(a.length - b.length < 0){
            return -1;
        }
        else{
            return a.localeCompare(b);
        }
    })

    console.log(arr.join('\n'));
    }



solve(['test', 
'Deny', 
'omen', 
'Default']
);