function convertWordsToUppercase(sentence) {
    const words = sentence.match(/\b\w+\b/g);
    let output = words[0].toUpperCase();

    for (let i = 1; i < words.length; i++) {
        output += `, ${words[i].toUpperCase()}`;
    }

    console.log(output);
}

convertWordsToUppercase('Hi, how are you?');
convertWordsToUppercase('hello');