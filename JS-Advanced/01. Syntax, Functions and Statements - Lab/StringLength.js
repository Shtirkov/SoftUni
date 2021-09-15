function calculateStringLength(str1, str2, str3){
    let stringsLength = str1.length + str2.length + str3.length;
    let averageLength = Math.round(stringsLength / 3);

    console.log(stringsLength);
    console.log(averageLength);
};

calculateStringLength('chocolate', 'ice cream', 'cake');