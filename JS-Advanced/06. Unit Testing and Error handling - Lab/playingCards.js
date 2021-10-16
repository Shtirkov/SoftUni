function createCard(cardFace, cardSuit){
  
    const validCardFaces = ['2','3','4','5','6','7','8','9','10','J','Q','K','A'];
    const validCardSuits = ['S', 'H', 'D', 'C'];

    if (!validCardFaces.includes(cardFace) || !validCardSuits.includes(cardSuit)) {
        throw new Error('Error');
    }

    const card = {
        cardFace: cardFace.toUpperCase(),
        cardSuit: cardSuit.toUpperCase(),
        toString(){
            return `${cardFace}${mapSuites(cardSuit)}`;           
        }
    };

    return card;

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

const card = createCard('2', 'H');
card.toString();