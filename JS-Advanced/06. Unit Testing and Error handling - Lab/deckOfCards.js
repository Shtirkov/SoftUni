function printCardsAndSigns(deck){
    const validCardFaces = ['2','3','4','5','6','7','8','9','10','J','Q','K','A'];
    const validCardSuits = ['S', 'H', 'D', 'C'];    
    const result = [];

    for (const card of deck) {
        let cardFace = '';
        let cardSuit = '';

        if (card.length == 2) {
          cardFace = card[0];
          cardSuit = card[1];  
        }else if(card.length == 3){
          cardFace = card[0] + card[1];
          cardSuit = card[2];
        }

        if (!validCardFaces.includes(cardFace) || !validCardSuits.includes(cardSuit)) {
            console.log(`Invalid card: ${cardFace}${cardSuit}`);
        }

        result.push({cardFace: cardFace, cardSuit: mapSuites(cardSuit)});
    }

    console.log(Object.values(result).map(x => `${x.cardFace}${x.cardSuit}`).join(' '));

    function mapSuites(cardSuit){
        const spades = '\u2660';
        const hearts = '\u2665';
        const diamonds ='\u2666';
        const clubs = '\u2663';
    
        if (cardSuit == 'S') {
            cardSuit = spades;
        }else if(cardSuit == 'H'){
            cardSuit = hearts;
        }else if(cardSuit == 'D'){
            cardSuit = diamonds;
        }else if(cardSuit == 'C'){
            cardSuit = clubs;
        }
    
        return cardSuit;
    }
}

printCardsAndSigns(['AS', '10D', 'KH', '2C']);
printCardsAndSigns(['5S', '3D', 'QD', '1C']);