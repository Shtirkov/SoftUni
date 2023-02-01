function sameDigits(num){
    let numAsString = num.toString().split('');
    let isSame = true;
    let digitsSum=0;
    let firstDigit = numAsString[0];
    
    numAsString.forEach(d => {
       digitsSum +=+ d;
       if (d != firstDigit) {
           isSame = false
       }
   });

    console.log(isSame);
    console.log(digitsSum);
}

    sameDigits(2);


